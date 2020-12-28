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
import { NgbModule } from '@ng-bootstrap/ng-bootstrap';
import { SupplierCreateComponent } from './supplier-create/supplier-create.component';
import { AddTaxPipe } from './pipes/addTax.pipe';
import { CategoryFilterPipe } from './pipes/categoryFilter.pipe';

@NgModule({
  declarations: [
    AppComponent,
    ProductListComponent,
    ProductCreateComponent,
    ProductRatingComponent,
    SupplierCreateComponent,
    AddTaxPipe,
    CategoryFilterPipe
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    HttpClientModule,
    FormsModule,
    BrowserAnimationsModule,
    ToastrModule.forRoot(),
    NgbModule,

  ],
  providers: [ProductRepository, SupplierRepository, RatingRepository],
  bootstrap: [AppComponent]
})
export class AppModule { }
