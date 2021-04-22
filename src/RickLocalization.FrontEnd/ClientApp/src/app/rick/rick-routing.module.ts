import { NgModule } from "@angular/core";
import { RouterModule, Routes } from "@angular/router";
import { RickDetailsComponent } from "./containers/rick-details/rick-details.component";
import { RickTravelsComponent } from "./containers/rick-travels/rick-travels.component";

const routes: Routes = [
  { path: ":url", component: RickDetailsComponent },
  { path: ":url/travels", component: RickTravelsComponent },
];

@NgModule({
  imports: [RouterModule.forChild(routes)],
  exports: [RouterModule]
})

export class RickRoutingModule { }
