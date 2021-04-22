import { Injectable } from "@angular/core";
import { Observable } from "rxjs";
import { ApiHttpClient } from "../../core/utils/api-http-client";
import { Dimension } from "../models/dimension";

@Injectable({
  providedIn: 'root'
})
export class DimensionService {

  constructor(private http: ApiHttpClient) { }

  getAll(): Observable<Dimension[]> {
    return this.http.get<Dimension[]>("Dimension/GetAll");
  }

}
