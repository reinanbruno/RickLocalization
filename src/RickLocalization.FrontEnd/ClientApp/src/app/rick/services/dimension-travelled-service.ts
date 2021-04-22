import { HttpParams } from "@angular/common/http";
import { Injectable } from "@angular/core";
import { Observable } from "rxjs";
import { Pagination } from "../../core/models/pagination";
import { ResponseResultCommand } from "../../core/models/response-result-command";
import { ApiHttpClient } from "../../core/utils/api-http-client";
import { DimensionTravelled } from "../models/dimension-travelled";
import { RequestInsertDimensionTravelled } from "../models/request-insert-dimension-travelled";

@Injectable({
  providedIn: 'root'
})
export class DimensionTravelledService {

  constructor(private http: ApiHttpClient) { }

  insert(request: RequestInsertDimensionTravelled): Observable<ResponseResultCommand> {
    return this.http.post<ResponseResultCommand>("DimensionTravelled/Insert", request);
  }

  getTravels(params: HttpParams): Observable<Pagination<DimensionTravelled>> {
    return this.http.get<Pagination<DimensionTravelled>>("DimensionTravelled/GetTravels", params);
  }

}
