import { Component } from '@angular/core';
import { Product } from './models/product/product.model';
import { ProductRepository } from './models/product/product.service';
import { Supplier } from './models/supplier/supplier.model';
import { SupplierRepository } from './models/supplier/supplier.service';

@Component({
  selector: 'root',
  templateUrl: './app.component.html'
})

export class AppComponent {
  constructor() { }

}
