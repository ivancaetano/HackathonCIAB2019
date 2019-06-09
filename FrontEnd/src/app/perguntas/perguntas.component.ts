import {Component, OnInit, ViewChild} from '@angular/core';
import {MatButton} from "@angular/material";
import {LoginService} from "../login.service";
import {Router} from "@angular/router";
import {LoginMockService} from "../login-mock.service";

@Component({
  selector: 'app-perguntas',
  templateUrl: './perguntas.component.html',
  styleUrls: ['./perguntas.component.scss']
})
export class PerguntasComponent implements OnInit {

  loading = false;
  success = false;
  token: string;
  perguntas: any;

  @ViewChild('btn', {static: false}) btn: MatButton;

  constructor(private loginService: LoginMockService, private router: Router) {
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
      setTimeout((p) => this.router.navigate(['sms'], {state: {token: this.token, perguntas: p}}), 400, p);
    });
  }
}

export function deepCopy(obj) {
  var copy;

  // Handle the 3 simple types, and null or undefined
  if (null == obj || "object" != typeof obj) return obj;

  // Handle Date
  if (obj instanceof Date) {
    copy = new Date();
    copy.setTime(obj.getTime());
    return copy;
  }

  // Handle Array
  if (obj instanceof Array) {
    copy = [];
    for (var i = 0, len = obj.length; i < len; i++) {
      copy[i] = deepCopy(obj[i]);
    }
    return copy;
  }

  // Handle Object
  if (obj instanceof Object) {
    copy = {};
    for (var attr in obj) {
      if (obj.hasOwnProperty(attr)) copy[attr] = deepCopy(obj[attr]);
    }
    return copy;
  }

  throw new Error("Unable to copy obj! Its type isn't supported.");
}
