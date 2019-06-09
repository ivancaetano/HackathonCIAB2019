import {Component, OnInit, ViewChild} from '@angular/core';
import {MatButton} from "@angular/material";
import {Router} from "@angular/router";
import {LoginMockService} from "../login-mock.service";
import {LoginService} from "../login.service";

@Component({
  selector: 'app-login',
  templateUrl: './login.component.html',
  styleUrls: ['./login.component.scss']
})
export class LoginComponent implements OnInit {

  user = 'ivancaetano@gmail.com';
  password: string;
  client = 'cli-uni-cef';
  loading = false;
  success = false;

  @ViewChild('btn', {static: false}) btn: MatButton;

  constructor(private loginService: LoginService, private router: Router) {
  }

  ngOnInit() {
  }

  login() {
    this.loading = true;
    this.loginService.login(this.user, this.password, this.client).subscribe(value => {
      this.loading = false;
      this.success = true;
      this.btn.ripple.launch({
        centered: true
      });
      setTimeout((v) => this.router.navigate(['termo'], {state: {token: v.accessToken}}), 400, value);
    });
  }
}
