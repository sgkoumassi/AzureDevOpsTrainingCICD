"use strict";
var __decorate = (this && this.__decorate) || function (decorators, target, key, desc) {
    var c = arguments.length, r = c < 3 ? target : desc === null ? desc = Object.getOwnPropertyDescriptor(target, key) : desc, d;
    if (typeof Reflect === "object" && typeof Reflect.decorate === "function") r = Reflect.decorate(decorators, target, key, desc);
    else for (var i = decorators.length - 1; i >= 0; i--) if (d = decorators[i]) r = (c < 3 ? d(r) : c > 3 ? d(target, key, r) : d(target, key)) || r;
    return c > 3 && r && Object.defineProperty(target, key, r), r;
};
var __metadata = (this && this.__metadata) || function (k, v) {
    if (typeof Reflect === "object" && typeof Reflect.metadata === "function") return Reflect.metadata(k, v);
};
Object.defineProperty(exports, "__esModule", { value: true });
var core_1 = require("@angular/core");
var employeeService_1 = require("./employeeService");
var userPreferencesService_1 = require("./userPreferencesService");
var EmployeeLisComponent = /** @class */ (function () {
    function EmployeeLisComponent(_employeeService, _userPrefencesService) {
        this._employeeService = _employeeService;
        this._userPrefencesService = _userPrefencesService;
        //This propertie is going to keep tack of with radio button is selected
        this.selectedEmployeeCountRadioButton = 'All';
        this.statusMessage = " Loading data. Please wait ...";
    }
    Object.defineProperty(EmployeeLisComponent.prototype, "colour", {
        get: function () {
            return this._userPrefencesService.colourPreference;
        },
        set: function (value) {
            this._userPrefencesService.colourPreference = value;
        },
        enumerable: true,
        configurable: true
    });
    EmployeeLisComponent.prototype.ngOnInit = function () {
        var _this = this;
        this._employeeService.getEmployees().subscribe(function (employeeData) { return _this.employees = employeeData; }, function (error) {
            _this.statusMessage = 'Probleme of the service please retry again later';
            console.error(error);
        });
    };
    EmployeeLisComponent.prototype.trackbyEmpCode = function (index, employee) {
        return employee.code;
    };
    EmployeeLisComponent.prototype.getTotalEmployeesCount = function () {
        return this.employees.length;
    };
    EmployeeLisComponent.prototype.getMaleEmployeesCount = function () {
        return this.employees.filter(function (e) { return e.gender === "Male"; }).length;
    };
    EmployeeLisComponent.prototype.getFemaleEmployeesCount = function () {
        return this.employees.filter(function (e) { return e.gender === "Female"; }).length;
    };
    // Methode to call when our custom child component even is rised
    EmployeeLisComponent.prototype.onEmployeeCountRadioButtonChange = function (selectedRadioButtonValue) {
        this.selectedEmployeeCountRadioButton = selectedRadioButtonValue;
    };
    EmployeeLisComponent = __decorate([
        core_1.Component({
            selector: 'listEmployee',
            templateUrl: 'app/employee/employeeListComponent.html',
            styleUrls: ['app/employee/employeeListComponent.css'],
        }),
        __metadata("design:paramtypes", [employeeService_1.EmployeeService,
            userPreferencesService_1.UserPreferencesService])
    ], EmployeeLisComponent);
    return EmployeeLisComponent;
}());
exports.EmployeeLisComponent = EmployeeLisComponent;
//# sourceMappingURL=employeeListComponent.js.map