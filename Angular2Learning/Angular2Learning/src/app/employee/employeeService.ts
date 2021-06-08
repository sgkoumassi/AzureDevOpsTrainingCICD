import { Injectable } from '@angular/core';
import { IEmployee } from './employeeInterface';
import { Http, Response } from '@angular/http';
import { Observable } from 'rxjs/Observable';
import 'rxjs/add/operator/map';
import 'rxjs/add/operator/catch';
import 'rxjs/add/Observable/throw';
import 'rxjs/add/operator/toPromise';



 
// allow us to inject any dependencies in in our service class
@Injectable()
export class EmployeeService {

    constructor(private _http: Http) { }

    getEmployees(): Observable<IEmployee[]> {
        
        return this._http.get("http://localhost:57069/api/Employees")
            .map((response: Response) => <IEmployee[]>response.json())
            .catch(this.handleError);
    }

    getEmployeeBycode(empCode: string): Observable<IEmployee> {
        return this._http.get("http://localhost:57069/api/Employees/" + empCode)
            .map((response: Response) => <IEmployee>response.json())
            .catch(this.handleError);
    }

    // Etant donné que le service ne peut pas offrir une interface pour afficher 
    //les erreurs  aux users, on renvoit les erreurs via un Catch. De cette facon,
    // tout composant ayant souscrit au service pourrait recuperer les erreurs et les afficher.
    // ensuite, dans le parramettre Erreur du souscripteur, on peut creer un fonction 
    // gerer les erreur.
    
    handleError(error: Response) {
        console.error(error);
        return Observable.throw(error);
    }

    //Methde that handle the Promise error
    handlePromiseError(error: Response) {
        console.error(error);
        throw(error);
    }
}