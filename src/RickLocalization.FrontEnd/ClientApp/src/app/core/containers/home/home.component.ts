import { HttpParams } from '@angular/common/http';
import { Component, OnInit } from '@angular/core';
import { PageEvent } from '@angular/material/paginator';
import { DataRick } from '../../../rick/models/data-rick';
import { RickService } from '../../../rick/services/rick-service';
import { Pagination } from '../../models/pagination';

@Component({
  selector: 'app-home',
  templateUrl: './home.component.html',
  styleUrls: ['./home.component.css']
})
export class HomeComponent implements OnInit {

  dataRick: Pagination<DataRick> = {};

  pageNumber: number = 1;
  pageSize: number = 8;

  constructor(private rickService: RickService) { }

  ngOnInit() {
    this.getAll();
  }

  //#region Metodos

  getAll() {
    let params = new HttpParams()
      .set("pageNumber", this.pageNumber.toString())
      .set("pageSize", this.pageSize.toString());

    this.rickService.getAll(params).subscribe(result => {
      this.dataRick = result;
    });

  }

  //#endregion

  //#region Eventos

  onChangePage(value: PageEvent) {
    this.pageNumber = value.pageIndex + 1;
    this.getAll();
  }

  //#endregion

}
