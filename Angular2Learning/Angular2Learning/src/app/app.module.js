"use strict";
var __decorate = (this && this.__decorate) || function (decorators, target, key, desc) {
    var c = arguments.length, r = c < 3 ? target : desc === null ? desc = Object.getOwnPropertyDescriptor(target, key) : desc, d;
    if (typeof Reflect === "object" && typeof Reflect.decorate === "function") r = Reflect.decorate(decorators, target, key, desc);
    else for (var i = decorators.length - 1; i >= 0; i--) if (d = decorators[i]) r = (c < 3 ? d(r) : c > 3 ? d(target, key, r) : d(target, key)) || r;
    return c > 3 && r && Object.defineProperty(target, key, r), r;
};
Object.defineProperty(exports, "__esModule", { value: true });
var core_1 = require("@angular/core");
var platform_browser_1 = require("@angular/platform-browser");
var forms_1 = require("@angular/forms");
var http_1 = require("@angular/http");
var router_1 = require("@angular/router");
var app_component_1 = require("./app.component");
var employeeComponent_1 = require("./employee/employeeComponent");
var employeeListComponent_1 = require("./employee/employeeListComponent");
var employeeTitlePipe_1 = require("./employee/employeeTitlePipe");
var employeeCountComponent_1 = require("./employee/employeeCountComponent");
var homeComponent_1 = require("./home/homeComponent");
var pageNotFoundComponent_1 = require("./others/pageNotFoundComponent");
//import { EmployeeDetailsComponent } from './employeeDetailsComponent';
var employeeService_1 = require("./employee/employeeService");
var userPreferencesService_1 = require("./employee/userPreferencesService");
var appRoutes = [
    { path: 'home', component: homeComponent_1.HomeComponent },
    { path: 'employees', component: employeeListComponent_1.EmployeeLisComponent },
    { path: 'employees/:code', component: employeeComponent_1.EmployeeComponent },
    { path: '', redirectTo: '/home', pathMatch: 'full' },
    { path: '**', component: pageNotFoundComponent_1.PageNotFoundComponent }
];
var AppModule = /** @class */ (function () {
    function AppModule() {
    }
    AppModule = __decorate([
        core_1.NgModule({
            imports: [platform_browser_1.BrowserModule, forms_1.FormsModule, http_1.HttpModule, router_1.RouterModule.forRoot(appRoutes, { useHash: true })],
            declarations: [app_component_1.AppComponent, employeeComponent_1.EmployeeComponent, employeeListComponent_1.EmployeeLisComponent,
                employeeTitlePipe_1.EmployeeTitlePipe, employeeCountComponent_1.EmployeeCountComponent, homeComponent_1.HomeComponent,
                pageNotFoundComponent_1.PageNotFoundComponent],
            bootstrap: [app_component_1.AppComponent],
            providers: [employeeService_1.EmployeeService, userPreferencesService_1.UserPreferencesService]
        })
    ], AppModule);
    return AppModule;
}());
exports.AppModule = AppModule;
//# sourceMappingURL=app.module.js.map