import { Component, Inject, OnInit } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { MatDialogRef, MAT_DIALOG_DATA } from '@angular/material/dialog';
import { MatSnackBar, MatSnackBarHorizontalPosition, MatSnackBarVerticalPosition } from '@angular/material/snack-bar';
import { DetailsRick } from '../../models/details-rick';
import { Dimension } from '../../models/dimension';
import { RequestInsertDimensionTravelled } from '../../models/request-insert-dimension-travelled';
import { DimensionService } from '../../services/dimension-service';
import { DimensionTravelledService } from '../../services/dimension-travelled-service';

@Component({
  selector: 'app-rick-add-travel',
  templateUrl: './rick-add-travel.component.html',
  styleUrls: ['./rick-add-travel.component.css']
})
export class RickAddTravelComponent implements OnInit {

  horizontalPosition: MatSnackBarHorizontalPosition = 'end';
  verticalPosition: MatSnackBarVerticalPosition = 'top';

  dataDimensions: Dimension[] = [];
  form: FormGroup;

  breakpoint: number;

  wasFormChanged: boolean = false;

  constructor(private formBuilder: FormBuilder,
    private snackBar: MatSnackBar,
    private dimensionService: DimensionService,
    private dimensionTravelledService: DimensionTravelledService,
    public dialogRef: MatDialogRef<RickAddTravelComponent>,
    @Inject(MAT_DIALOG_DATA) public data: DetailsRick) { }

  ngOnInit(): void {
    this.form = this.formBuilder.group({
      currentDimension: [this.data.dimensionCurrent.name, [Validators.required]],
      newDimension: [null, [Validators.required]],
    });
    this.form.get("currentDimension").disable();
    this.setBreakpoint(window.innerWidth);
    this.getAllDimensions();
  }

  //#region METODOS

  getAllDimensions() {
    this.dimensionService.getAll().subscribe(result => {
      this.dataDimensions = result;
    });
  }

  private markAsDirty(group: FormGroup): void {
    group.markAsDirty();
    for (const i in group.controls) {
      group.controls[i].markAsDirty();
    }
  }

  formChanged() {
    this.wasFormChanged = true;
  }

  insertDimensionTravelled() {
    let request: RequestInsertDimensionTravelled = {
      idRick: this.data.id,
      idDimension: this.form.get("newDimension").value.id
    };

    this.dimensionTravelledService.insert(request).subscribe(result => {
      this.openSnackBar(result.message);
      this.onCloseDialog();
    }, e => {
        let errorMessage = (e.error.errors ? e.error.errors.toString() : e.error.message);
        this.openSnackBar(errorMessage);
    });
  }

  openSnackBar(message) {
    this.snackBar.open(message, '❌', {
      duration: 5 * 1000,
      horizontalPosition: this.horizontalPosition,
      verticalPosition: this.verticalPosition
    });
  }

  setBreakpoint(innerWidth) {
    this.breakpoint = innerWidth <= 1024 ? 1 : 2;
  }

  //#endregion

  //#region EVENTOS

  onSubmit(): void {
    if (this.form.get("newDimension").value?.id === this.data.dimensionCurrent.id) {
      this.form.controls['newDimension'].setErrors({ 'incorrect': true });
      return;
    }

    this.markAsDirty(this.form);

    if (this.form.valid) {
      this.insertDimensionTravelled();
    }
  }

  onResize(event: any): void {
    this.setBreakpoint(event.target.innerWidth);
  }

  onCloseDialog(): void {
    this.dialogRef.close(this.form.controls['newDimension'].value);
  }

  //#endregion

}
