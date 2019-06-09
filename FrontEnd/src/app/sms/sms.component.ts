import {Component, OnInit, ViewChild} from '@angular/core';
import {MatButton} from "@angular/material";
import {LoginService} from "../login.service";
import {Router} from "@angular/router";
import {deepCopy} from "../perguntas/perguntas.component";
import {LoginMockService} from "../login-mock.service";

@Component({
  selector: 'app-sms',
  templateUrl: './sms.component.html',
  styleUrls: ['./sms.component.scss']
})
export class SmsComponent implements OnInit {

  loading = false;
  success = false;
  token: string;
  code: any;
  perguntas: any;

  @ViewChild('btn', {static: false}) btn: MatButton;

  constructor(private loginService: LoginService, private router: Router) {
    this.token = this.router.getCurrentNavigation().extras.state.token;
    this.perguntas = this.router.getCurrentNavigation().extras.state.perguntas;
    console.log(this.perguntas);
  }

  ngOnInit() {
  }

  avancar() {
    this.loading = true;//10/07/2017 //2500 //6475
    let p = deepCopy(this.perguntas);
    p.lsPerguntas[0].deResposta = 4;
    p.lsPerguntas[1].deResposta = '2017-07-10';
    p.lsPerguntas[2].deResposta = 2500;
    p.lsPerguntas[5].deResposta = '6475';
    console.log(this.perguntas);
    this.loginService.responderPerguntas(this.token, p).subscribe(value => {
      this.loading = false;
      this.success = true;
      this.btn.ripple.launch({
        centered: true
      });
      setTimeout((p) => this.router.navigate(['foto'], {state: {token: this.token, perguntas: p}}), 400, p);
    });
  }
}
