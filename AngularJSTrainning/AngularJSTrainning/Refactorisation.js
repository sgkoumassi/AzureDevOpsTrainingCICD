
angular.module('Penguins')
    .controller('PenguinsController', ['$scope', '$http', function ($scope, $http) {
        $scope.Penguin = null;
        $scope.editingPenguin = false;
        $scope.PenguinQuery = null;
        $scope.Penguins = [];

        // Edit a Penguin database entry
        $scope.editPenguin = function (Penguin) {
            $scope.Penguin = Penguin;
            $scope.editingPenguin = true;
        };

        // Save a Penguin database entry
        $scope.savePenguin = function () {
            $http.post('/Penguins', $scope.Penguin)
                .then(function () {
                    $http.get('/Penguins')
                        .then(function (response) {
                            $scope.Penguin = null;
                            $scope.Penguins = response.data;
                            $scope.editingPenguin = false;
                        });
                });
        };
        // Discard an edit of a Penguin database entry
        $scope.cancelPenguin = function () {
            $scope.editingPenguin = false;
        };

        // Search the Penguin database
        $scope.searchPenguins = _.debounce(function (query) {
            $http.get('/Penguins/search/' + query)
                .then(function (response) {
                    $scope.Penguins = response.data;
                });
        }, 300);
        // Initially load the Penguins
        $http.get('/Penguins')
            .then(function (response) {
                $scope.Penguins = response.data;
            });
    }]);
    

