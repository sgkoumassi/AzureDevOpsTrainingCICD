import { Component, OnInit } from '@angular/core';
import { IEmployee } from './employeeInterface';
import { EmployeeService } from './employeeService';
import { UserPreferencesService } from './userPreferencesService';


@Component({
    selector: 'listEmployee',
    templateUrl: 'app/employee/employeeListComponent.html',
    styleUrls: ['app/employee/employeeListComponent.css'],
    
})

export class EmployeeLisComponent implements OnInit {
    employees: IEmployee[];
    //This propertie is going to keep tack of with radio button is selected
    selectedEmployeeCountRadioButton: string = 'All';
    statusMessage: string = " Loading data. Please wait ...";

    constructor(private _employeeService: EmployeeService,
        private _userPrefencesService: UserPreferencesService) {

    }


    get colour(): string {
        return this._userPrefencesService.colourPreference;
    }

    set colour(value: string) {
        this._userPrefencesService.colourPreference = value;
    }
  
    

    ngOnInit() {
        this._employeeService.getEmployees().subscribe((employeeData) => this.employees = employeeData,
            (error) => {
            this.statusMessage = 'Probleme of the service please retry again later';
                console.error(error);
            });
    }
   
    trackbyEmpCode(index: number, employee: any): string {
        return employee.code;
    }

    getTotalEmployeesCount(): number {
    return this.employees.length;
    }

    getMaleEmployeesCount(): number {
        return this.employees.filter(e => e.gender === "Male").length;
    }

    getFemaleEmployeesCount(): number {
        return this.employees.filter(e => e.gender === "Female").length;
    }


    // Methode to call when our custom child component even is rised
    onEmployeeCountRadioButtonChange(selectedRadioButtonValue: string): void {
        this.selectedEmployeeCountRadioButton = selectedRadioButtonValue;
    }

}

