import { Component } from '@angular/core';
import { NgForm } from '@angular/forms';
import { Product } from '../models/product/product.model';
import { ProductRepository } from '../models/product/product.service';
import { Supplier } from '../models/supplier/supplier.model';
import { SupplierRepository } from '../models/supplier/supplier.service';

@Component({
  selector: 'product-create',
  templateUrl: './product-create.component.html'
})

export class ProductCreateComponent {
  constructor(private prepo: ProductRepository, private srepo: SupplierRepository) {
  }

  get product(): Product {
    return this.prepo.product;
  }

  get suppliers(): Supplier[] {
    return this.srepo.suppliersList;
  }

  onSubmit(form: NgForm) {
    this.prepo.postProduct(form.value);
  }

}
