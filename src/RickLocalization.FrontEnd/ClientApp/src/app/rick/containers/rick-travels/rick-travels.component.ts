import { HttpParams } from '@angular/common/http';
import { Component, OnInit } from '@angular/core';
import { PageEvent } from '@angular/material/paginator';
import { ActivatedRoute } from '@angular/router';
import { Pagination } from '../../../core/models/pagination';
import { Dimension } from '../../models/dimension';
import { DimensionTravelled } from '../../models/dimension-travelled';
import { DimensionTravelledService } from '../../services/dimension-travelled-service';

@Component({
  selector: 'app-rick-travels',
  templateUrl: './rick-travels.component.html',
  styleUrls: ['./rick-travels.component.css']
})
export class RickTravelsComponent implements OnInit {

  dataTravel: Pagination<DimensionTravelled>;
  dataSource: DimensionTravelled[] = [];

  displayedColumns: string[] = ['index', 'nameDimensionBefore', 'nameDimensionCurrent'];

  url: string;

  pageNumber: number = 1;
  pageSize: number = 10;

  pageCurrent: PageEvent;

  constructor(private dimensionTravelledService: DimensionTravelledService,
              private activatedRoute: ActivatedRoute) {
    this.activatedRoute.params.subscribe(params => {
      this.url = params['url'];
    });
  }

  ngOnInit(): void {
    this.getTravels();
  }

  //#region METODOS

  getTravels() {
    let params = new HttpParams()
      .set("urlRick", this.url)
      .set("pageNumber", this.pageNumber.toString())
      .set("pageSize", this.pageSize.toString());

    this.dimensionTravelledService.getTravels(params).subscribe(result => {
      this.dataTravel = result;
      this.dataSource = result.response;
      this.pageCurrent = { pageIndex: 0, length: result.pageCount, pageSize: this.pageSize };
    });

  }

  //#endregion

  //#region EVENTOS

  onChangePage(value: PageEvent) {
    this.pageCurrent = value;
    this.pageNumber = value.pageIndex + 1;
    this.getTravels();

    //const end = (value.pageIndex + 1) * value.pageSize;
    //const start = value.pageIndex * value.pageSize;
    //const part = this.dataTravel.response.slice(start, end);
    //this.dataSource = part;
  }

  //#endregion

}
