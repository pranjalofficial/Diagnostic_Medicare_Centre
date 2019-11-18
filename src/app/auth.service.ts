import { Injectable } from '@angular/core';
import { LoginRegistrationService } from './login-registration.service';
import { loginDetails } from './login-page/loginFetchDetails.module';
import { patientLogin } from './patientlogin.module';
import { Router } from '@angular/router';
import { doctorLogin } from './doctorLogin';
import { doctorLoginDetails } from './doctor-login/doctorLoginDetails';

@Injectable({
  providedIn: 'root'
})
export class AuthService {

  constructor(private loginser:LoginRegistrationService,private router:Router) { }
  fetchDetails:loginDetails;
  fetchDoctor:doctorLoginDetails;
  loggedIn = false;
  msg:string;
  logOut():void{
    
    this.loggedIn=false;
  }
  login(loginDat:patientLogin){
    this.loginser.login(loginDat).subscribe((res:loginDetails)=>{
      this.fetchDetails =res;
      if(this.fetchDetails==null)
      {
         this.loggedIn = false;
      }
      else{
         this.loggedIn =true;
      }
      if(this.loggedIn)
        {
          this.router.navigate(['Patient']);
          
        }
        else
        {
          this.msg = "Invalid Credentials";
        }          
    }  
    ) 
  }

  doctorLogin(drLoginData:doctorLogin){
    this.loginser.doctorLogin(drLoginData).subscribe((res:doctorLoginDetails)=>{
      this.fetchDoctor =res;
      if(this.fetchDoctor==null)
      {
         this.loggedIn = false;
      }
      else{
         this.loggedIn =true;
      }
      if(this.loggedIn)
        {
          this.router.navigate(['Doctor']);
          
        }
        else
        {
          this.msg = "Invalid Credentials";
        }          
    }  
    ) 
  }
}
