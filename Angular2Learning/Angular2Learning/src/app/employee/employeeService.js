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
var http_1 = require("@angular/http");
var Observable_1 = require("rxjs/Observable");
require("rxjs/add/operator/map");
require("rxjs/add/operator/catch");
require("rxjs/add/Observable/throw");
require("rxjs/add/operator/toPromise");
// allow us to inject any dependencies in in our service class
var EmployeeService = /** @class */ (function () {
    function EmployeeService(_http) {
        this._http = _http;
    }
    EmployeeService.prototype.getEmployees = function () {
        return this._http.get("http://localhost:57069/api/Employees")
            .map(function (response) { return response.json(); })
            .catch(this.handleError);
    };
    EmployeeService.prototype.getEmployeeBycode = function (empCode) {
        return this._http.get("http://localhost:57069/api/Employees/" + empCode)
            .map(function (response) { return response.json(); })
            .catch(this.handleError);
    };
    // Etant donné que le service ne peut pas offrir une interface pour afficher 
    //les erreurs  aux users, on renvoit les erreurs via un Catch. De cette facon,
    // tout composant ayant souscrit au service pourrait recuperer les erreurs et les afficher.
    // ensuite, dans le parramettre Erreur du souscripteur, on peut creer un fonction 
    // gerer les erreur.
    EmployeeService.prototype.handleError = function (error) {
        console.error(error);
        return Observable_1.Observable.throw(error);
    };
    //Methde that handle the Promise error
    EmployeeService.prototype.handlePromiseError = function (error) {
        console.error(error);
        throw (error);
    };
    EmployeeService = __decorate([
        core_1.Injectable(),
        __metadata("design:paramtypes", [http_1.Http])
    ], EmployeeService);
    return EmployeeService;
}());
exports.EmployeeService = EmployeeService;
//# sourceMappingURL=employeeService.js.map