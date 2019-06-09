import {Component, OnInit, ViewChild} from '@angular/core';
import {LoginService} from "../login.service";
import {Router} from "@angular/router";
import {MatButton} from "@angular/material";
import {LoginMockService} from "../login-mock.service";
import { WebcamImage } from 'ngx-webcam';
import { Subject, Observable } from 'rxjs';

@Component({
  selector: 'app-foto',
  templateUrl: './foto.component.html',
  styleUrls: ['./foto.component.scss']
})
export class FotoComponent implements OnInit {

  loading = false;
  success = false;
  token: string;
  perguntas: any;
  private trigger: Subject<void> = new Subject<void>();
  @ViewChild('btn', {static: false}) btn: MatButton;

  constructor(private loginService: LoginService, private router: Router) {
    this.token = this.router.getCurrentNavigation().extras.state.token;
    this.perguntas = this.router.getCurrentNavigation().extras.state.perguntas;
  }
  public handleImage(webcamImage: WebcamImage): void {
    console.info('received webcam image', webcamImage);
    this.loginService.uploadFoto(webcamImage) .subscribe(
      (data: any) => {
        console.log(data);
        this.avancar(data);
      },
      error => console.log(error)
      
    );
  }
  ngOnInit() {
  }
  public triggerSnapshot(): void {
    this.trigger.next();
  }
  public get triggerObservable(): Observable<void> {
    return this.trigger.asObservable();
  }
  
  avancar(data) {
    this.loading = true;//10/07/2017 //2500 //6475
    let p = deepCopy(this.perguntas);
    this.perguntas.lsPerguntas[4].deResposta = data[0].faceId;
    console.log(this.perguntas);
    this.loginService.responderPerguntas(this.token, p).subscribe(value => {
      this.loading = false;
      this.success = true;
      this.btn.ripple.launch({
        centered: true
      });
      setTimeout((p) => this.router.navigate(['carregando'], {state: {token: this.token, perguntas: p}}), 400, p);
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