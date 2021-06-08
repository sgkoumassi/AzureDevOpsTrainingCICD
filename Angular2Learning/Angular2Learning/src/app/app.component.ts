import { Component } from "@angular/core";
@Component({
    selector: 'my-app', // the selector become a directive on any html page : 
    // in the template  properti we use the selector 'my-employee'
    //  of EmployeeComponent as a directive
    template: `
            <div>
               <h1>{{pageHeader}}</h1>
                <h2>{{getFullName()}}</h2>
               <img src='{{imagePath}}'/>
               <my-employee></my-employee> 
               <button [disabled] ='isDisabled'> properties binding </button>
               <button class ="colorClass" > class from css: no biding used </button>
               <button [class]='classToApply'> class biding from component propertie </button>
               <br/> <br/>
              <button [class]='classToApply' [class.colorClass]='!applyColorToClass'> class biding from component propertie </button>
             <br/> <br/>
             <button [ngClass]='addClasses()'> class biding from component propertie using ngClass </button>
            <br/> <br/>
             Name :<input [(ngModel)] ='name'/>
            <br/>
           Your entered : {{name}}
</div>
<br/>
<h2> Employee List using ngFor</h2>
<br/>
<listEmployee><listEmployee> <br/>
<br/>
<h2> Router </h2>
<div style ="padding:5px">
    <ul class="nav nav-tabs">
       <li routerLinkActive="acitve"> <a  routerLink ="home">Home</a> </li>      
       <li routerLinkActive="acitve"> <a routerLink ="Employees"> Employees</a> </li>
   </ul>
    <router-outlet></router-outlet>
</div>
`
})
export class AppComponent {
    // properties binding
    pageHeader: string = "Employee Details";
    imagePath: string = 'http://pragimtech.com/images/logo.jpg';
    isDisabled: boolean = true;

    firstName: string = 'Gani';
    lastName: string = 'Koumassi';
    // class biding
    classToApply: string = 'italicsClass boldClass';
    applyColorToClass: boolean = true;
    applyItalicsClass: boolean = false;
    addClasses() {
        let classes = {
            boldClass: this.applyColorToClass,
            italicsClass: this.applyItalicsClass
        };
        return classes;
    }

    // Two way data biding
    name: string = 'Razak';


    getFullName(): string {
        return this.firstName + ' ' + this.lastName;
    }
}
