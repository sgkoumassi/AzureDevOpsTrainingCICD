"use strict";
var __decorate = (this && this.__decorate) || function (decorators, target, key, desc) {
    var c = arguments.length, r = c < 3 ? target : desc === null ? desc = Object.getOwnPropertyDescriptor(target, key) : desc, d;
    if (typeof Reflect === "object" && typeof Reflect.decorate === "function") r = Reflect.decorate(decorators, target, key, desc);
    else for (var i = decorators.length - 1; i >= 0; i--) if (d = decorators[i]) r = (c < 3 ? d(r) : c > 3 ? d(target, key, r) : d(target, key)) || r;
    return c > 3 && r && Object.defineProperty(target, key, r), r;
};
Object.defineProperty(exports, "__esModule", { value: true });
var core_1 = require("@angular/core");
var AppComponent = /** @class */ (function () {
    function AppComponent() {
        // properties binding
        this.pageHeader = "Employee Details";
        this.imagePath = 'http://pragimtech.com/images/logo.jpg';
        this.isDisabled = true;
        this.firstName = 'Gani';
        this.lastName = 'Koumassi';
        // class biding
        this.classToApply = 'italicsClass boldClass';
        this.applyColorToClass = true;
        this.applyItalicsClass = false;
        // Two way data biding
        this.name = 'Razak';
    }
    AppComponent.prototype.addClasses = function () {
        var classes = {
            boldClass: this.applyColorToClass,
            italicsClass: this.applyItalicsClass
        };
        return classes;
    };
    AppComponent.prototype.getFullName = function () {
        return this.firstName + ' ' + this.lastName;
    };
    AppComponent = __decorate([
        core_1.Component({
            selector: 'my-app',
            // in the template  properti we use the selector 'my-employee'
            //  of EmployeeComponent as a directive
            template: "\n            <div>\n               <h1>{{pageHeader}}</h1>\n                <h2>{{getFullName()}}</h2>\n               <img src='{{imagePath}}'/>\n               <my-employee></my-employee> \n               <button [disabled] ='isDisabled'> properties binding </button>\n               <button class =\"colorClass\" > class from css: no biding used </button>\n               <button [class]='classToApply'> class biding from component propertie </button>\n               <br/> <br/>\n              <button [class]='classToApply' [class.colorClass]='!applyColorToClass'> class biding from component propertie </button>\n             <br/> <br/>\n             <button [ngClass]='addClasses()'> class biding from component propertie using ngClass </button>\n            <br/> <br/>\n             Name :<input [(ngModel)] ='name'/>\n            <br/>\n           Your entered : {{name}}\n</div>\n<br/>\n<h2> Employee List using ngFor</h2>\n<br/>\n<listEmployee><listEmployee> <br/>\n<br/>\n<h2> Router </h2>\n<div style =\"padding:5px\">\n    <ul class=\"nav nav-tabs\">\n       <li routerLinkActive=\"acitve\"> <a  routerLink =\"home\">Home</a> </li>      \n       <li routerLinkActive=\"acitve\"> <a routerLink =\"Employees\"> Employees</a> </li>\n   </ul>\n    <router-outlet></router-outlet>\n</div>\n"
        })
    ], AppComponent);
    return AppComponent;
}());
exports.AppComponent = AppComponent;
//# sourceMappingURL=app.component.js.map