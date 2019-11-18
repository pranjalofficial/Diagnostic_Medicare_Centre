import { Component, OnInit } from '@angular/core';
import { LoginRegistrationService } from '../login-registration.service';
import { Router } from '@angular/router';
import { patientDetails } from './patientDetails.module';

@Component({
  selector: 'app-login-register-page',
  templateUrl: './login-register-page.component.html',
  styleUrls: ['./login-register-page.component.css']
})
export class LoginRegisterPageComponent implements OnInit {

  constructor(private Register:LoginRegistrationService,private_router:Router) { }

  ngOnInit() {
  }
  patientDetails:patientDetails = {
    ptFirstName:null,
    ptLastName:null,
    ptAge:null,
    ptGender:null,
    ptDob:null,
    ptContactNo:null,
    ptAltContactNo:null,
    ptEmail:null,
    ptPassword:null,
    ptAddress1:null,
    ptAddress2:null,
    ptCity:null,
    ptState:null,
    ptZipcode:null,
    ptStatus:null
  };

  onSubmit(){
    this.Register.registration(this.patientDetails).subscribe();
    console.log(this.patientDetails);
  }
}
