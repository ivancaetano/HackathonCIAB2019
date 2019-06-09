import {Injectable} from '@angular/core';
import {HttpClient, HttpHeaders} from '@angular/common/http';
import { WebcamImage } from 'ngx-webcam';

@Injectable({
  providedIn: 'root'
})
export class LoginService {

  private _xxx = 'https://cors-anywhere.herokuapp.com/http://uniloginback-dev.us-west-2.elasticbeanstalk.com';

  constructor(private http: HttpClient) {
  }

  login(user, password, client) {
    return this.http.post(this._xxx + '/api/login', {
      edEmail: user,
      txSenha: password,
      client
    });
  }

  assinarTermo(token: string) {
    return this.http.put(this._xxx + '/api/usuarios/aceite-termo', {
      token: ''
    }, {
      headers: {
        authorization: token
      }
    });
  }

  carregarBases(token: string) {
    return this.http.get<any[]>(this._xxx + '/api/bases', {
      headers: {
        authorization: token
      }
    });
  }

  enviarBases(token: string, bases: any[]) {
    return this.http.put(this._xxx + '/api/usuarios/bases', {
      bases
    }, {
      headers: {
        authorization: token
      }
    });
  }

  buscarPerguntas(token: string) {
    return this.http.get<any[]>(this._xxx + '/api/usuarios/perguntas', {
      headers: {
        authorization: token
      }
    });
  }
  uploadFoto(webcamImage: WebcamImage) {
    var block = webcamImage.imageAsDataUrl.split(";");
    // Get the content type of the image
    var contentType = block[0].split(":")[1];// In this case "image/gif"
    // get the real base64 content of the file
    var realData = block[1].split(",")[1];// In this case "R0lGODlhPQBEAPeoAJosM...."
    
    // Convert it to a blob to upload
    var blob = b64toBlob(realData, contentType,512);


    let headers = new HttpHeaders();
  headers = headers.set('Ocp-Apim-Subscription-Key', '309977319b54467e9136592c7d4bca56');
  headers = headers.set('Content-Type', 'application/octet-stream');
    return this.http.post<any[]>('https://westcentralus.api.cognitive.microsoft.com/face/v1.0/detect?returnFaceId=true',blob, {
      headers: headers
    });
  }
  responderPerguntas(token: string, perguntas: any) {
    return this.http.post(this._xxx + '/api/usuarios/perguntas', perguntas, {
      headers: {
        authorization: token
      }
    });
  }
}
function b64toBlob(b64Data, contentType, sliceSize) {
  contentType = contentType || '';
  sliceSize = sliceSize || 512;

  var byteCharacters = atob(b64Data);
  var byteArrays = [];

  for (var offset = 0; offset < byteCharacters.length; offset += sliceSize) {
      var slice = byteCharacters.slice(offset, offset + sliceSize);

      var byteNumbers = new Array(slice.length);
      for (var i = 0; i < slice.length; i++) {
          byteNumbers[i] = slice.charCodeAt(i);
      }

      var byteArray = new Uint8Array(byteNumbers);

      byteArrays.push(byteArray);
  }

var blob = new Blob(byteArrays, {type: contentType});
return blob;
}