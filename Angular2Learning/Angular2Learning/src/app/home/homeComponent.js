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
var userPreferencesService_1 = require("../employee/userPreferencesService");
var HomeComponent = /** @class */ (function () {
    function HomeComponent(_userPrefencesService) {
        this._userPrefencesService = _userPrefencesService;
    }
    Object.defineProperty(HomeComponent.prototype, "colour", {
        get: function () {
            return this._userPrefencesService.colourPreference;
        },
        set: function (value) {
            this._userPrefencesService.colourPreference = value;
        },
        enumerable: true,
        configurable: true
    });
    HomeComponent = __decorate([
        core_1.Component({
            template: "<h1> This is the home Page</h1>\n              <div>\n                    Colour Prerence : \n                     <input type ='text' [(ngModel)]='colour' [style.background]='colour' />\n               </div>\n\n"
        }),
        __metadata("design:paramtypes", [userPreferencesService_1.UserPreferencesService])
    ], HomeComponent);
    return HomeComponent;
}());
exports.HomeComponent = HomeComponent;
//# sourceMappingURL=homeComponent.js.map