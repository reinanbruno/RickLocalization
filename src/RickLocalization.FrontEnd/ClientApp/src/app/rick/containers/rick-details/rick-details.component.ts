import { HttpParams } from '@angular/common/http';
import { Component, OnInit } from '@angular/core';
import { MatDialog } from '@angular/material/dialog';
import { ActivatedRoute } from '@angular/router';
import { RickAddTravelComponent } from '../../components/rick-add-travel/rick-add-travel.component';
import { DetailsRick } from '../../models/details-rick';
import { RickService } from '../../services/rick-service';

@Component({
  selector: 'app-rick-details',
  templateUrl: './rick-details.component.html',
  styleUrls: ['./rick-details.component.css']
})
export class RickDetailsComponent implements OnInit {

  url: string;
  dataDetails: DetailsRick;

  constructor(private rickService: RickService,
    private activatedRoute: ActivatedRoute,
    private dialog: MatDialog) {
    this.activatedRoute.params.subscribe(params => {
      this.url = params['url'];
    });
  }

  ngOnInit(): void {
    this.getDetails();
  }

  //#region METODOS

  getDetails() {
    let params = new HttpParams()
      .set("url", this.url);

    this.rickService.getDetails(params).subscribe(result => {
      this.dataDetails = result;
    });
  }

  openDialog(): void {
    const dialogRef = this.dialog.open(RickAddTravelComponent, {
      minWidth: '50%',
      data: this.dataDetails
    });

    dialogRef.afterClosed().subscribe(result => {
      if (result) {
        this.dataDetails.dimensionCurrent = result;
      }
    });
  }

  //#endregion

}
