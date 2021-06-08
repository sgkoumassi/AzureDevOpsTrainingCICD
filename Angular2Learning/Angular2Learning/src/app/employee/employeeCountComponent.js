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
var EmployeeCountComponent = /** @class */ (function () {
    function EmployeeCountComponent() {
        // this propertie is going to keep track of the selected radio button value 
        this.selectedRadioButtonValue = 'All';
        // Even payload : our custom even
        this.countRadiobuttonSelectionChanged = new core_1.EventEmitter();
    }
    // the  methode witch rise our custom even and passing radionbutton value as even playload
    EmployeeCountComponent.prototype.onRadiobuttonSelectionChange = function () {
        this.countRadiobuttonSelectionChanged.emit(this.selectedRadioButtonValue);
        console.log(this.selectedRadioButtonValue);
    };
    __decorate([
        core_1.Output(),
        __metadata("design:type", core_1.EventEmitter)
    ], EmployeeCountComponent.prototype, "countRadiobuttonSelectionChanged", void 0);
    __decorate([
        core_1.Input(),
        __metadata("design:type", Number)
    ], EmployeeCountComponent.prototype, "all", void 0);
    __decorate([
        core_1.Input(),
        __metadata("design:type", Number)
    ], EmployeeCountComponent.prototype, "male", void 0);
    __decorate([
        core_1.Input(),
        __metadata("design:type", Number)
    ], EmployeeCountComponent.prototype, "female", void 0);
    EmployeeCountComponent = __decorate([
        core_1.Component({
            selector: 'employeeCount',
            templateUrl: 'app/employee/employeeCountComponent.html',
            styleUrls: ['app/employee/employeeCountComponent.css']
        })
    ], EmployeeCountComponent);
    return EmployeeCountComponent;
}());
exports.EmployeeCountComponent = EmployeeCountComponent;
//# sourceMappingURL=employeeCountComponent.js.map