import { HttpParams } from "@angular/common/http";
import { Injectable } from "@angular/core";
import { Observable } from "rxjs";
import { Pagination } from "../../core/models/pagination";
import { ApiHttpClient } from "../../core/utils/api-http-client";
import { DataRick } from "../models/data-rick";
import { DetailsRick } from "../models/details-rick";

@Injectable({
  providedIn: 'root'
})
export class RickService {

  constructor(private http: ApiHttpClient) { }

  getAll(params: HttpParams): Observable<Pagination<DataRick>> {
    return this.http.get < Pagination<DataRick>>("Rick/GetAll", params);
  }

  getDetails(params: HttpParams): Observable<DetailsRick> {
    return this.http.get<DetailsRick>("Rick/GetDetails", params);
  }

}
