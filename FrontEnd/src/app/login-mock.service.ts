import {Injectable} from '@angular/core';
import {HttpClient} from "@angular/common/http";
import {Observable} from "rxjs";

@Injectable({
  providedIn: 'root'
})
export class LoginMockService {

  constructor(private http: HttpClient) {
  }

  login(user, password, client) {
    return new Observable((observer) => {
      setTimeout( () => {
        observer.next({accessToken: '123'})
        observer.complete()
      }, 500);
    });
  }

  assinarTermo(token: string) {
    return new Observable((observer) => {
      setTimeout( () => {
        observer.next({})
        observer.complete()
      }, 500);
    });
  }

  carregarBases(token: string) {
    return new Observable((observer) => {
      setTimeout( () => {
        observer.next([{"coBase":1,"noBase":"Facebook","unitb005UsuarioBase":[]},{"coBase":2,"noBase":"Google","unitb005UsuarioBase":[]},{"coBase":3,"noBase":"TSE","unitb005UsuarioBase":[]},{"coBase":4,"noBase":"CADUN","unitb005UsuarioBase":[]},{"coBase":5,"noBase":"Cadastro NIS","unitb005UsuarioBase":[]},{"coBase":6,"noBase":"Pagamentos Sociais","unitb005UsuarioBase":[]},{"coBase":7,"noBase":"RAIS","unitb005UsuarioBase":[]},{"coBase":8,"noBase":"Base de Crédito","unitb005UsuarioBase":[]}])
        observer.complete()
      }, 500);
    });
  }

  enviarBases(token: string, bases: any[]) {
    return new Observable((observer) => {
      setTimeout( () => {
        observer.next([{"coBase":1,"noBase":"Facebook","unitb005UsuarioBase":[]},{"coBase":2,"noBase":"Google","unitb005UsuarioBase":[]},{"coBase":3,"noBase":"TSE","unitb005UsuarioBase":[]},{"coBase":4,"noBase":"CADUN","unitb005UsuarioBase":[]},{"coBase":5,"noBase":"Cadastro NIS","unitb005UsuarioBase":[]},{"coBase":6,"noBase":"Pagamentos Sociais","unitb005UsuarioBase":[]},{"coBase":7,"noBase":"RAIS","unitb005UsuarioBase":[]},{"coBase":8,"noBase":"Base de Crédito","unitb005UsuarioBase":[]}])
        observer.complete()
      }, 500);
    });
  }

  buscarPerguntas(token: string) {
    return new Observable((observer) => {
      setTimeout( () => {
        observer.next({"coLog":82,"lsPerguntas":[{"noTipo":"DROP","deEnunciado":"Qual o nome do seu irmão mais velho?","deResposta":null,"lsOpcoes":[{"coOpcao":1,"noOpcao":"Felipe Zuculo"},{"coOpcao":2,"noOpcao":"Lucas Zardo"},{"coOpcao":3,"noOpcao":"Lucas Iglesias"},{"coOpcao":4,"noOpcao":"Lucas Leão"}],"icValido":false},{"noTipo":"DATA","deEnunciado":"Qual a data em que você foi admitido no seu último emprego?","deResposta":null,"lsOpcoes":[],"icValido":false},{"noTipo":"DECIMAL","deEnunciado":"Qual o valor aproximado do seu salário?","deResposta":null,"lsOpcoes":[],"icValido":false},{"noTipo":"LOCALIZACAO","deEnunciado":"Qual sua localização atual?","deResposta":null,"lsOpcoes":[],"icValido":false},{"noTipo":"FOTO","deEnunciado":"Pode mandar uma foto sua?","deResposta":null,"lsOpcoes":[],"icValido":false},{"noTipo":"CODIGO","deEnunciado":"Qual o código que enviei para o seu celular?","deResposta":"","lsOpcoes":[],"icValido":false}]})
        observer.complete()
      }, 500);
    });
  }

  responderPerguntas(token: string, perguntas: any) {
    return new Observable((observer) => {
      setTimeout( () => {
        observer.next({"coLog":82,"lsPerguntas":[{"noTipo":"DROP","deEnunciado":"Qual o nome do seu irmão mais velho?","deResposta":null,"lsOpcoes":[{"coOpcao":1,"noOpcao":"Felipe Zuculo"},{"coOpcao":2,"noOpcao":"Lucas Zardo"},{"coOpcao":3,"noOpcao":"Lucas Iglesias"},{"coOpcao":4,"noOpcao":"Lucas Leão"}],"icValido":false},{"noTipo":"DATA","deEnunciado":"Qual a data em que você foi admitido no seu último emprego?","deResposta":null,"lsOpcoes":[],"icValido":false},{"noTipo":"DECIMAL","deEnunciado":"Qual o valor aproximado do seu salário?","deResposta":null,"lsOpcoes":[],"icValido":false},{"noTipo":"LOCALIZACAO","deEnunciado":"Qual sua localização atual?","deResposta":null,"lsOpcoes":[],"icValido":false},{"noTipo":"FOTO","deEnunciado":"Pode mandar uma foto sua?","deResposta":null,"lsOpcoes":[],"icValido":false},{"noTipo":"CODIGO","deEnunciado":"Qual o código que enviei para o seu celular?","deResposta":"","lsOpcoes":[],"icValido":false}]})
        observer.complete()
      }, 500);
    });
  }
}
