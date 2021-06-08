/// <reference path="scripts/angular.min.js" />
/// <reference path="scripts/angular-route.min.js" />
var app = angular.module("RouteModule", ["ngRoute"])
    .config(function ($routeProvider, $locationProvider) {
        $routeProvider.caseInsensitiveMatch= true;
        $routeProvider
            .when("/RHome", {
                templateUrl: "Template/RHome.html",
                controller: "RhomeControler"
            })
            .when("/Rcourses", {
                templateUrl: "Template/Rcourses.html",
                controller: "RcoursesControler",
                controllerAs: "coursesCtrl"
            })
            .when("/REmplyeesList", {
                templateUrl: "Template/REmplyeesList.html",
                controller: "REmplyeesListControler",
                controllerAs: "employeesCtrl",
                resolve: {
                    employeeRouteList: function ($http) {
                        return $http.get("EmployeeService.asmx/GetEmployees")
                            .then(function (resp) {
                                return resp.data;
                            })
                    }
                }
            })
            .when("/REmplyeesList/:id", {
                templateUrl: "Template/REmplyeeDetail.html",
                controller: "REmplyeeDetailControler"

            })
            .when("/REmplyeeSearch/:name?", {
                templateUrl: "Template/REmplyeeSearch.html",
                controller: "REmplyeeSearchControler",
                controllerAs: "emplyeeSearchCtrl"

            })
            .otherwise({
                redirectTo: "/RHome"
            })
        $locationProvider.html5Mode(true);

    })
    .controller("RhomeControler", function ($scope) {
        $scope.message = "Home Page";

    })
    .controller("RcoursesControler", function () {
        var vm = this;
        vm.courses = ["C#", "VB.NET", "SQL Server", "ASP.NET"];

    })
    .controller("REmplyeesListControler", function (employeeRouteList, $location, $route, $scope) {
        $scope.$on("$locationChangeStart", function (event, next, current) {
            if (!confirm("Are you sure you wante to navigate away from this page ??? to " + next)) {
                event.preventDefault();
            }
        })
        var vm = this;
        vm.seachEmployee = function () {
            if (vm.Name) {
                $location.url("/REmplyeeSearch/" + vm.Name);
            }
            else {
                $location.url("/REmplyeeSearch");
            }
        }
        vm.reloadData = function () {
            $route.reload();
        }
        vm.employees = employeeRouteList;   
    })
    .controller("REmplyeeDetailControler", function ($scope, $http, $routeParams) {
            $http({
                url: "EmployeeService.asmx/GetEmployeesById",
                params: {id:$routeParams.id},
                method: "get"
            })
              .then(function (response) {
                  $scope.employeeDetail = response.data;
                })
    })
    .controller("REmplyeeSearchControler", function ($scope, $http, $routeParams) {
        var vm = this;
        if ($routeParams.name) {
            $http({
                url: "EmployeeService.asmx/GetEmployeesByName",
                params: { name: $routeParams.name },
                method: "get"
            })
                .then(function (response) {
                    vm.employees = response.data;
                })
        }
        else {
            $http.get("EmployeeService.asmx/GetEmployees")
                .then(function (resp) {
                    vm.employees = resp.data;
                })
        }
        
        
    })
