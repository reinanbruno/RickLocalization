import { CommonModule } from '@angular/common';
import { NgModule } from '@angular/core';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';
import { MatButtonModule } from '@angular/material/button';
import { MatDialogModule } from '@angular/material/dialog';
import { MatFormFieldModule } from '@angular/material/form-field';
import { MatGridListModule } from '@angular/material/grid-list';
import { MatInputModule } from '@angular/material/input';
import { MatPaginatorModule } from '@angular/material/paginator';
import { MatSelectModule } from '@angular/material/select';
import { MatTableModule } from '@angular/material/table';
import { RickAddTravelComponent } from './components/rick-add-travel/rick-add-travel.component';
import { RickDetailsComponent } from './containers/rick-details/rick-details.component';
import { RickTravelsComponent } from './containers/rick-travels/rick-travels.component';
import { RickRoutingModule } from './rick-routing.module';
import { MatSnackBarModule } from '@angular/material/snack-bar';

@NgModule({
  declarations: [
    RickDetailsComponent,
    RickTravelsComponent,
    RickAddTravelComponent
  ],
  imports: [
    CommonModule,
    MatSnackBarModule,
    RickRoutingModule,
    MatTableModule,
    MatPaginatorModule,
    MatButtonModule,
    MatDialogModule,
    MatFormFieldModule,
    MatInputModule,
    FormsModule,
    ReactiveFormsModule,
    MatGridListModule,
    MatSelectModule
  ]
})
export class RickModule { }
