import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { ProductRepository } from './models/product/product.service';
import { HttpClientModule } from '@angular/common/http';
import { ProductListComponent } from './product-list/product-list.component';
import { ProductCreateComponent } from './product-create/product-create.component';
import { FormsModule } from '@angular/forms';
import { SupplierRepository } from './models/supplier/supplier.service';

import { BrowserAnimationsModule } from '@angular/platform-browser/animations';
import { ToastrModule } from 'ngx-toastr';
import { ProductRatingComponent } from './product-rating/product-rating.component';
import { RatingRepository } from './models/rating/rating.service';

@NgModule({
  declarations: [
    AppComponent, ProductListComponent, ProductCreateComponent, ProductRatingComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    HttpClientModule,
    FormsModule,
    BrowserAnimationsModule,
    ToastrModule.forRoot()
  ],
  providers: [ProductRepository, SupplierRepository, RatingRepository],
  bootstrap: [AppComponent]
})
export class AppModule { }
