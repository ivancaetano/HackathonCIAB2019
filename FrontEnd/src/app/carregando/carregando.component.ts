import {Component, OnInit, ViewChild} from '@angular/core';
import {MatButton} from "@angular/material";
import {LoginService} from "../login.service";
import {Router} from "@angular/router";
import {LoginMockService} from "../login-mock.service";

@Component({
  selector: 'app-carregando',
  templateUrl: './carregando.component.html',
  styleUrls: ['./carregando.component.scss']
})
export class CarregandoComponent implements OnInit {

  loading = false;
  success = false;
  token: string;

  constructor(private loginService: LoginService, private router: Router) {
    this.token = this.router.getCurrentNavigation().extras.state.token;
  }

  ngOnInit() {
    setTimeout(()=> {
      this.router.navigate(['sucesso'], {state: {token: this.token}});
    }, 5000);
  }

}
