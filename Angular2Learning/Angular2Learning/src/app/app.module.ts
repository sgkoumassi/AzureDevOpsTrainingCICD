import { NgModule }      from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { FormsModule } from '@angular/forms';
import { HttpModule } from '@angular/http';
import { RouterModule, Routes } from '@angular/router';

import { AppComponent } from './app.component';
import { EmployeeComponent } from './employee/employeeComponent';
import { EmployeeLisComponent } from './employee/employeeListComponent';
import { EmployeeTitlePipe } from './employee/employeeTitlePipe';
import { EmployeeCountComponent } from './employee/employeeCountComponent';
import { HomeComponent } from './home/homeComponent';
import { PageNotFoundComponent } from './others/pageNotFoundComponent';
//import { EmployeeDetailsComponent } from './employeeDetailsComponent';
import { EmployeeService } from './employee/employeeService'
import { UserPreferencesService } from './employee/userPreferencesService';


const appRoutes: Routes = [
    { path: 'home', component: HomeComponent },
    { path: 'employees', component: EmployeeLisComponent },
    { path: 'employees/:code', component: EmployeeComponent },
    { path: '', redirectTo: '/home', pathMatch: 'full' },
    { path: '**', component: PageNotFoundComponent }
]

@NgModule({
    imports: [BrowserModule, FormsModule, HttpModule, RouterModule.forRoot(appRoutes, { useHash: true })],
    declarations: [AppComponent, EmployeeComponent, EmployeeLisComponent,
        EmployeeTitlePipe, EmployeeCountComponent, HomeComponent,
        PageNotFoundComponent],
    bootstrap: [AppComponent],
    providers: [EmployeeService, UserPreferencesService]
})
export class AppModule { }

