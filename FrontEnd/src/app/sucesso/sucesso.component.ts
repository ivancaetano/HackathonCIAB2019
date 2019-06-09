import { Component, OnInit } from '@angular/core';
import {LoginService} from "../login.service";
import {Router} from "@angular/router";
import {LoginMockService} from "../login-mock.service";

@Component({
  selector: 'app-sucesso',
  templateUrl: './sucesso.component.html',
  styleUrls: ['./sucesso.component.scss']
})
export class SucessoComponent implements OnInit {

  loading = false;
  success = false;
  token: string;

  constructor(private loginService: LoginService, private router: Router) {
    this.token = this.router.getCurrentNavigation().extras.state.token;
  }

  ngOnInit() {
  }

  avancar() {

  }
}
