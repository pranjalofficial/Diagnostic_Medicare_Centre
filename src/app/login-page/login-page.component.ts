import { Component, OnInit } from "@angular/core";
import { LoginRegistrationService } from "../login-registration.service";
import { Router } from "@angular/router";
import { patientLogin } from "../patientlogin.module";
import { Observable } from "rxjs";
import { loginDetails } from "./loginFetchDetails.module";
import { AuthService } from "../auth.service";
import { debug } from "util";

@Component({
  selector: "app-login-page",
  templateUrl: "./login-page.component.html",
  styleUrls: ["./login-page.component.css"]
})
export class LoginPageComponent implements OnInit {
  constructor(private router: Router, private _authService: AuthService) {}
  ngOnInit() {}
  loginDetailsProvided: patientLogin = {
    ptUserId: null,
    ptPassword: null
  };

  check: Boolean;
  userIdFetch: string;
  onSubmit(username: string, password: string) {
    this.loginDetailsProvided.ptUserId = username;
    this.loginDetailsProvided.ptPassword = password;
    this._authService.login(this.loginDetailsProvided);
  }
}
