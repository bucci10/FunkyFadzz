import { Injectable } from '@angular/core';
import { HttpClient, HttpHeaders } from '@angular/common/http';
import { FunkyFadz } from '../models/FunkyFadz';


const Api_Url = 'http://localhost:51110';

@Injectable()
export class FunkyFadzService {

  constructor(private _http: HttpClient) { }

  getFunkyFadz(){
    return this._http.get(`${Api_Url}/FunkyFadz` , { headers: this.getHeaders()});
  }

  createNotes(note: FunkyFadz){
    return this._http.post(`${Api_Url}/FunkyFadz`, FunkyFadzId, { headers: this.getHeaders()});
  }

  private getHeaders(){
    return new HttpHeaders().set('Authorization', `Bearer ${localStorage.getItem('id_token')}`);
  }

}