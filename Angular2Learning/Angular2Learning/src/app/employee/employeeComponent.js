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
//employeeComponent.ts
var core_1 = require("@angular/core");
var router_1 = require("@angular/router");
var employeeService_1 = require("./employeeService");
require("rxjs/add/operator/retry");
require("rxjs/add/operator/retryWhen");
require("rxjs/add/operator/delay");
require("rxjs/add/operator/scan");
var EmployeeComponent = /** @class */ (function () {
    function EmployeeComponent(_employeeService, _activateRoute, _router) {
        this._employeeService = _employeeService;
        this._activateRoute = _activateRoute;
        this._router = _router;
        this.statusMessage = 'Loading data please wait ...';
    }
    EmployeeComponent.prototype.onBackButtonlick = function () {
        this._router.navigate(['/employees']);
    };
    EmployeeComponent.prototype.ngOnInit = function () {
        var _this = this;
        var empCode = this._activateRoute.snapshot.params['code'];
        //Use then() instead of subscribr()
        this._employeeService.getEmployeeBycode(empCode)
            .retryWhen(function (err) {
            return err.scan(function (retryCount) {
                retryCount += 1;
                if (retryCount < 6) {
                    _this.statusMessage = 'retrying .... Attempt # ' + retryCount;
                    return retryCount;
                }
                else {
                    throw (err);
                }
            }, 0).delay(1000);
        })
            .subscribe(function (employeeData) {
            if (employeeData == null) {
                _this.statusMessage = 'Employee with the specified code does not exist';
            }
            else {
                _this.employeeI = employeeData;
            }
        }, function (error) {
            _this.statusMessage = 'Problem with the server !! Please try again later';
            console.log(error);
        });
    };
    EmployeeComponent = __decorate([
        core_1.Component({
            selector: 'my-employee',
            templateUrl: 'app/employee/employeeComponent.html',
            styleUrls: ['app/employee/employeeComponent.css']
        }),
        __metadata("design:paramtypes", [employeeService_1.EmployeeService,
            router_1.ActivatedRoute,
            router_1.Router])
    ], EmployeeComponent);
    return EmployeeComponent;
}());
exports.EmployeeComponent = EmployeeComponent;
//# sourceMappingURL=employeeComponent.js.map