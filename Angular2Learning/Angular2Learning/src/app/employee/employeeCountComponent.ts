import { Component,Input,Output,EventEmitter } from '@angular/core';

@Component({

    selector: 'employeeCount',
    templateUrl: 'app/employee/employeeCountComponent.html',
    styleUrls: ['app/employee/employeeCountComponent.css']
})

export class EmployeeCountComponent {

    // this propertie is going to keep track of the selected radio button value 
    selectedRadioButtonValue: string = 'All';
    // Even payload : our custom even
    @Output()
    countRadiobuttonSelectionChanged: EventEmitter<string> = new EventEmitter<string>();


    // Input decorateur permet d'exporter une proprieté de la class 
    //dans un element html  
    @Input() all: number ;
    @Input() male: number;
    @Input() female: number;

    // the  methode witch rise our custom even and passing radionbutton value as even playload
    onRadiobuttonSelectionChange() {
        this.countRadiobuttonSelectionChanged.emit(this.selectedRadioButtonValue);
        console.log(this.selectedRadioButtonValue);
    }

}