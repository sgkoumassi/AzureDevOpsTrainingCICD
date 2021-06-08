import { Component } from '@angular/core';
import { UserPreferencesService } from '../employee/userPreferencesService';

@Component({
    template: `<h1> This is the home Page</h1>
              <div>
                    Colour Prerence : 
                     <input type ='text' [(ngModel)]='colour' [style.background]='colour' />
               </div>

`
})

export class HomeComponent {
   

    constructor(private _userPrefencesService: UserPreferencesService) {
      
    }

    get colour(): string {
        return this._userPrefencesService.colourPreference;
    }

    set colour(value: string) {
        this._userPrefencesService.colourPreference = value;
    }
}
