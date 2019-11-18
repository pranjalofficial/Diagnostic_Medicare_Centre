import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { LoginPageComponent } from './login-page/login-page.component';
import { LoginRegisterPageComponent } from './login-register-page/login-register-page.component';
import { InitialPageComponent } from './initial-page/initial-page.component';
import { PatientHomePageComponent } from './patient-home-page/patient-home-page.component';
import { AuthGuardService } from './auth-guard.service';
import { DoctorHomePageComponent } from './doctor-home-page/doctor-home-page.component';
import { DoctorLoginComponent } from './doctor-login/doctor-login.component';


const routes: Routes = [
  {
    path:'Login',
    component:LoginPageComponent
  },
  {
    path:"Register",
    component:LoginRegisterPageComponent
  },
  {
    path:"Initial",
    component:InitialPageComponent
  },
  {
    path:"Patient",
    component:PatientHomePageComponent,
    canActivate:[AuthGuardService]
  },
  {
    path:"Doctor",
    component:DoctorHomePageComponent
  },
  {
    path:"DoctorLogin",
    component:DoctorLoginComponent
  }
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
