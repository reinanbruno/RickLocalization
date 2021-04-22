import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { HomeComponent } from './core/containers/home/home.component';

const routes: Routes = [
  { path: '', component: HomeComponent },
  { path: 'ricks', loadChildren: () => import('./rick/rick.module').then(m => m.RickModule) }
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
