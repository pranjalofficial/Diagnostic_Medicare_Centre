import { Component } from '@angular/core';
import { RouterLink, Router } from '@angular/router';
import { InitialPageComponent } from './initial-page/initial-page.component';
import { patientLogin } from './patientlogin.module';
import { loginDetails } from './login-page/loginFetchDetails.module';
import { AuthService } from './auth.service';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent {
  title = 'MedicareCentre';

  constructor(private router:Router,private _authService: AuthService) { }
  ngOnInit(){
    this._authService.fetchDetails;
    this._authService.loggedIn;
    this.router.navigate(['Initial']);
  }
  patient:loginDetails=
  {
    ptUserId:null,
    ptFirstName:null,
    ptLastName:null,
    ptEmail:null

  };
}


