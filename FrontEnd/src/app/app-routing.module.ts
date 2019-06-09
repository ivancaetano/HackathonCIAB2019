import {NgModule} from '@angular/core';
import {Routes, RouterModule} from '@angular/router';
import {LoginComponent} from "./login/login.component";
import {TermoComponent} from "./termo/termo.component";
import {BasesComponent} from "./bases/bases.component";
import {PerguntasComponent} from "./perguntas/perguntas.component";
import {SmsComponent} from "./sms/sms.component";
import {FotoComponent} from "./foto/foto.component";
import {SucessoComponent} from "./sucesso/sucesso.component";
import {CarregandoComponent} from "./carregando/carregando.component";

const routes: Routes = [
  {path: 'login', component: LoginComponent},
  {path: 'termo', component: TermoComponent},
  {path: 'bases', component: BasesComponent},
  {path: 'perguntas', component: PerguntasComponent},
  {path: 'sms', component: SmsComponent},
  {path: 'foto', component: FotoComponent},
  {path: 'sucesso', component: SucessoComponent},
  {path: 'carregando', component: CarregandoComponent},
  {path: '', redirectTo: '/login', pathMatch: 'full'}
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule {
}
