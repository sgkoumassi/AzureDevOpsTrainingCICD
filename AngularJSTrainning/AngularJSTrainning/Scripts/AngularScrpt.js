/// <reference path="angular.min.js" />
// creating the module and
// the controller and register the controler with 
// the module in one line by methode chainning

var myApp = angular
    .module("MyModule", [])
    .controller("myControler", function ($scope, $http, $log, StringService) {
        //Consuming asp net web service in Angualar
        $http({
            method :'GET',
            url:'EmployeeService.asmx/GetEmployees'})
            .then(function (response) {
                $scope.employeesWS = response.data;
                $log.info(response);
            });

        // Consuming angular service

        $scope.transformString = function (input) {
           
            $scope.output = StringService.processString(input);
        };
        $scope.message = "AngularJs Tuto";

        var country = {
            Name: "Niger",
            Capital: "Niamey",
            flag: "/Images/Niger.png"
        };
        var employees = [
            {
                firstName: "Laure",
                lastName: "Paillous",
                dateOfBirth: new Date("Februry 04,1988"),
                gender: "Female",
                salary: "100000"
            },
            {
                firstName: "Mamane",
                lastName: "Koumassi",
                dateOfBirth: new Date("Jun 19,1989"),
                gender: "Male",
                salary: "200000"
            },
            {
                firstName: "Souley",
                lastName: "Koumassi",
                dateOfBirth: new Date("August 19,1986"),
                gender: "Male",
                salary: "400000"
            }

        ];

        var countries = [
            {
                name :"UK",
                cities: [
                    { name: "London" },
                    { name: "Mancheter" }
                ]
            },
            {
                name: "Niger",
                cities: [
                    { name: "Niamey" },
                    { name: "Tahoua" }
                ]
            }

        ];
        var technologies=[

            { name:"C#", likes:0, dislikes:0 },
            { name:"ASP.NET", likes:0, dislikes:0 },
            { name:"SQL Server", likes:0, dislikes:0 },
            { name:"Angular JS", likes:0, dislikes:0 }
            
        ];
        $scope.countries = countries;
        $scope.employees = employees;
        $scope.employeeView = "EmployeeTable.html";
        $scope.rowLimit = 2;
        $scope.country = country;
        $scope.sortColumn = "firstName";
        $scope.reverseSort = false;
        
        $scope.technologies = technologies;
        $scope.incrementLikes = function (technology) {
            technology.likes++;
        };
        $scope.incrementDislikes = function (technology) {
            technology.dislikes++;
        };
        $scope.sortData = function (column) {
            $scope.reverseSort = ($scope.sortColumn == column) ? !$scope.reverseSort : false;
            $scope.sortColumn = column;
        };

        $scope.getSortClass = function (column) {
            if ($scope.sortColumn == column) {
                return $scope.reverseSort ? 'arrow-down' : 'arrow-up';
            }
            return '';

        };

       

    });
