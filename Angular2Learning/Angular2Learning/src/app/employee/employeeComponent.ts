//employeeComponent.ts
import { Component, OnInit } from '@angular/core';
import { IEmployee } from './employeeInterface';
import { ActivatedRoute, Router } from '@angular/router';
import { EmployeeService } from './employeeService';
import 'rxjs/add/operator/retry';
import 'rxjs/add/operator/retryWhen';
import 'rxjs/add/operator/delay';
import 'rxjs/add/operator/scan';


@Component({
    selector: 'my-employee',
    templateUrl: 'app/employee/employeeComponent.html',
    styleUrls: ['app/employee/employeeComponent.css']
})

export class EmployeeComponent implements OnInit {
    employeeI: IEmployee;
    statusMessage: string ='Loading data please wait ...';

    constructor(private _employeeService: EmployeeService,
        private _activateRoute: ActivatedRoute,
        private _router: Router) { }

    onBackButtonlick(): void {
        this._router.navigate(['/employees']);
    }
    ngOnInit() {
        let empCode: string = this._activateRoute.snapshot.params['code'];
        //Use then() instead of subscribr()
        this._employeeService.getEmployeeBycode(empCode)
            .retryWhen((err) => {
                return err.scan((retryCount) => {
                    retryCount += 1;
                    if (retryCount < 6) {
                        this.statusMessage = 'retrying .... Attempt # ' + retryCount;
                        return retryCount;
                    }
                    else {
                        throw (err);
                    }
                }, 0).delay(1000)
            })
            .subscribe(
            (employeeData) => {
                if (employeeData == null) {
                    this.statusMessage = 'Employee with the specified code does not exist';
                } else {
                    this.employeeI = employeeData;
                        }
            },
            (error) => {
                this.statusMessage = 'Problem with the server !! Please try again later';
                console.log(error);
            })
    }

   
} 