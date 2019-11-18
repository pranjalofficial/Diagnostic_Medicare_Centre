import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { InitialPageComponent } from './initial-page/initial-page.component';
import { LoginRegisterPageComponent } from './login-register-page/login-register-page.component';
import { LoginPageComponent } from './login-page/login-page.component';
import {FormsModule} from '@angular/forms';
import {HttpClientModule} from '@angular/common/http';
import { PatientHomePageComponent } from './patient-home-page/patient-home-page.component';
import { AdminLoginPageComponent } from './admin-login-page/admin-login-page.component';
import { DoctorHomePageComponent } from './doctor-home-page/doctor-home-page.component';
import { DoctorLoginComponent } from './doctor-login/doctor-login.component';

@NgModule({
  declarations: [
    AppComponent,
    InitialPageComponent,
    LoginRegisterPageComponent,
    LoginPageComponent,
    PatientHomePageComponent,
    AdminLoginPageComponent,
    DoctorHomePageComponent,
    DoctorLoginComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    FormsModule,
    HttpClientModule,
    
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
