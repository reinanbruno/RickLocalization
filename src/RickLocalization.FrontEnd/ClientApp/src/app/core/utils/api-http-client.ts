import { HttpClient, HttpHandler, HttpHeaders, HttpParams } from "@angular/common/http";
import { Injectable } from "@angular/core";
import { Observable } from "rxjs";
import { environment } from "../../../environments/environment.prod";

@Injectable()
export class ApiHttpClient extends HttpClient {

  private httpOptions = {
    headers: new HttpHeaders({ 'Content-Type': 'application/json' }),
    params: new HttpParams
  };

  private baseUrl: string;

  public constructor(handler: HttpHandler) {
    super(handler);
    this.baseUrl = environment.baseUrl;
  }

  public get<T>(url: string, params?: any): Observable<T> {
    this.httpOptions.params = (params) ? params : null;
    return super.get<T>(this.baseUrl + url, this.httpOptions);
  }

  public post<T>(url: string, data: any): Observable<T> {
    return super.post<T>(this.baseUrl + url, data, this.httpOptions);
  }
}
