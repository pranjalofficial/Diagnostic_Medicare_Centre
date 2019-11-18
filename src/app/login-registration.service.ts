import { Injectable } from '@angular/core';
import { HttpClient,HttpHeaders } from  '@angular/common/http';
import { Observable, observable } from 'rxjs';
import { patientLogin } from './patientlogin.module';
import { patientDetails } from './login-register-page/patientDetails.module';
import { loginDetails } from './login-page/loginFetchDetails.module';
import { doctorLogin } from './doctorLogin';
import { doctorLoginDetails } from './doctor-login/doctorLoginDetails';

@Injectable({
  providedIn: 'root'
})
export class LoginRegistrationService {

  constructor(private http: HttpClient) { }
  checkLogin:boolean;
  fetchDetails:loginDetails;
  loginUrl:string = "http://localhost:30983/api/login";
  registrationUrl:string = "http://localhost:30983/api/Registration";
  doctorLoginUrl:string = "http://localhost:30983/api/DoctorLogin";
   login (login:patientLogin): Observable<loginDetails> {
    return this.http.post<loginDetails>(this.loginUrl,login,{headers: new HttpHeaders({'Content-type': 'application/json'})  
  } 
   )
  }

 registration(details:patientDetails){

   return this.http.post(this.registrationUrl,details)
 }

 doctorLogin (drlogin:doctorLogin): Observable<doctorLoginDetails> {
  return this.http.post<doctorLoginDetails>(this.doctorLoginUrl,drlogin,{headers: new HttpHeaders({'Content-type': 'application/json'})  
} 
 )
}


}
