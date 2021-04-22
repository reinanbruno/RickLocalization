import { Inject, NgModule, Optional, SkipSelf } from '@angular/core';
import { MatCardModule } from '@angular/material/card';
import { MatPaginatorModule } from '@angular/material/paginator';
import { MatTabsModule } from '@angular/material/tabs';
import { MatToolbarModule } from '@angular/material/toolbar';
import { BrowserModule } from '@angular/platform-browser';
import { RouterModule } from '@angular/router';
import { HeaderComponent } from './components/header/header.component';
import { HomeComponent } from './containers/home/home.component';

@NgModule({
  declarations: [
    HeaderComponent,
    HomeComponent
  ],
  exports: [
    HeaderComponent
  ],
  imports: [
    BrowserModule,
    RouterModule,
    MatToolbarModule,
    MatCardModule,
    MatTabsModule,
    MatPaginatorModule
  ]
})
export class CoreModule {
  constructor(@Optional() @SkipSelf() @Inject(CoreModule) parentModule: CoreModule) {
    if (parentModule) {
      throw new Error(
        'CoreModule jรก foi carregado. Importe ele apenas no AppModule!');
    }
  }
}
