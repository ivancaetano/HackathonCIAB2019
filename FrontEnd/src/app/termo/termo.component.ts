import {Component, OnInit, ViewChild} from '@angular/core';
import {MatButton} from "@angular/material";
import {LoginService} from "../login.service";
import {Router} from "@angular/router";
import {LoginMockService} from "../login-mock.service";

@Component({
  selector: 'app-termo',
  templateUrl: './termo.component.html',
  styleUrls: ['./termo.component.scss']
})
export class TermoComponent implements OnInit {

  loading = false;
  success = false;
  token: string;

  @ViewChild('btn', {static: false}) btn: MatButton;

  constructor(private loginService: LoginService, private router: Router) {
    this.token = this.router.getCurrentNavigation().extras.state.token;
  }

  ngOnInit() {
  }

  avancar() {
    this.loading = true;
    this.loginService.assinarTermo(this.token).subscribe(value => {
      this.loginService.buscarPerguntas(this.token).subscribe(perguntas => {
        this.loading = false;
        this.success = true;
        this.btn.ripple.launch({
          centered: true
        });
        setTimeout((perguntas) => this.router.navigate(['perguntas'],
          {state: {token: this.token, perguntas: perguntas}}), 400, perguntas);
      });
    });
  }
}
