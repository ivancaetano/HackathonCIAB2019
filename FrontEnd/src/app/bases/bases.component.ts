import {Component, OnInit, ViewChild} from '@angular/core';
import {LoginService} from "../login.service";
import {Router} from "@angular/router";
import {MatButton} from "@angular/material";
import {LoginMockService} from "../login-mock.service";

@Component({
  selector: 'app-bases',
  templateUrl: './bases.component.html',
  styleUrls: ['./bases.component.scss']
})
export class BasesComponent implements OnInit {

  loading = false;
  success = false;
  token: string;
  bases: any[];

  @ViewChild('btn', {static: false}) btn: MatButton;

  constructor(private loginService: LoginService, private router: Router) {
    this.token = this.router.getCurrentNavigation().extras.state.token;
    this.bases = this.router.getCurrentNavigation().extras.state.bases;
  }

  ngOnInit() {
  }

  avancar() {
    this.loading = true;
    this.loginService.enviarBases(this.token, this.bases.map(value => value.coBase)).subscribe(value => {
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
