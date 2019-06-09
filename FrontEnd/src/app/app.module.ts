import {BrowserModule} from '@angular/platform-browser';
import {NgModule} from '@angular/core';

import {AppRoutingModule} from './app-routing.module';
import {AppComponent} from './app.component';
import {BrowserAnimationsModule} from '@angular/platform-browser/animations';
import {LoginComponent} from './login/login.component';
import {FlexLayoutModule} from "@angular/flex-layout";
import {
  MatButtonModule,
  MatCheckboxModule,
  MatDatepickerModule,
  MatIconModule,
  MatInputModule,
  MatNativeDateModule,
  MatSelectModule,
  MatSliderModule
} from "@angular/material";
import {FormsModule} from "@angular/forms";
import {HttpClientModule} from "@angular/common/http";

import {library} from '@fortawesome/fontawesome-svg-core';
import {fas} from '@fortawesome/free-solid-svg-icons';
import {far} from '@fortawesome/free-regular-svg-icons';
import {fab} from '@fortawesome/free-brands-svg-icons';
import {FontAwesomeModule} from "@fortawesome/angular-fontawesome";
import {TermoComponent} from './termo/termo.component';
import {BasesComponent} from './bases/bases.component';
import {PerguntasComponent} from './perguntas/perguntas.component';
import {SmsComponent} from './sms/sms.component';
import {FotoComponent} from './foto/foto.component';
import {WebcamModule} from "ngx-webcam";
import { SucessoComponent } from './sucesso/sucesso.component';
import { CarregandoComponent } from './carregando/carregando.component';

library.add(fas, far, fab);

@NgModule({
  declarations: [
    AppComponent,
    LoginComponent,
    TermoComponent,
    BasesComponent,
    PerguntasComponent,
    SmsComponent,
    FotoComponent,
    SucessoComponent,
    CarregandoComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    BrowserAnimationsModule,
    FlexLayoutModule,
    MatInputModule,
    MatIconModule,
    MatButtonModule,
    FormsModule,
    HttpClientModule,
    FontAwesomeModule,
    MatCheckboxModule,
    MatSelectModule,
    MatDatepickerModule,
    MatSliderModule,
    MatNativeDateModule,
    WebcamModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule {
}
