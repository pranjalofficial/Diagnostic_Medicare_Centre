import { Component, OnInit } from "@angular/core";
import { Router } from "@angular/router";
import { AuthGuardService } from "../auth-guard.service";
import { AuthService } from "../auth.service";
import { doctorLogin } from "../doctorLogin";

@Component({
  selector: "app-doctor-login",
  templateUrl: "./doctor-login.component.html",
  styleUrls: ["./doctor-login.component.css"]
})
export class DoctorLoginComponent implements OnInit {
  constructor(private _router: Router, private _authService: AuthService) {}

  ngOnInit() {}

  drLoginProvided: doctorLogin = {
    drUserID: null,
    drPassword: null
  };

  onSubmit(username: string, password: string) {
    this.drLoginProvided.drUserID = username;
    this.drLoginProvided.drPassword = password;
    this._authService.doctorLogin(this.drLoginProvided);
  }
}
