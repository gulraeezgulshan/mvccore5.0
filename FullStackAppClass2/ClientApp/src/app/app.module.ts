import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { ProductRepository } from './models/product/product.service';
import { HttpClientModule } from '@angular/common/http';
import { ProductListComponent } from './product-list/product-list.component';
import { ProductCreateComponent } from './product-create/product-create.component';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';
import { SupplierRepository } from './models/supplier/supplier.service';

import { BrowserAnimationsModule } from '@angular/platform-browser/animations';
import { ToastrModule } from 'ngx-toastr';
import { ProductRatingComponent } from './product-rating/product-rating.component';
import { RatingRepository } from './models/rating/rating.service';
import { NgbModule } from '@ng-bootstrap/ng-bootstrap';
import { SupplierCreateComponent } from './supplier-create/supplier-create.component';
import { AddTaxPipe } from './pipes/addTax.pipe';
import { CategoryFilterPipe } from './pipes/categoryFilter.pipe';
import { UserRepository } from './models/user/user.service';
import { UserRegistrationComponent } from './user-registration/user-registration.component';

@NgModule({
  declarations: [
    AppComponent,
    ProductListComponent,
    ProductCreateComponent,
    ProductRatingComponent,
    SupplierCreateComponent,
    UserRegistrationComponent,
    AddTaxPipe,
    CategoryFilterPipe
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    HttpClientModule,
    FormsModule,
    ReactiveFormsModule,
    BrowserAnimationsModule,
    ToastrModule.forRoot(),
    NgbModule,

  ],
  providers: [ProductRepository, SupplierRepository, RatingRepository, UserRepository],
  bootstrap: [AppComponent]
})
export class AppModule { }
