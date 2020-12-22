import { Component } from '@angular/core';
import { Product } from '../models/product/product.model';
import { ProductRepository } from '../models/product/product.service';

@Component({
  selector: 'product-list',
  templateUrl: './product-list.component.html'
})

export class ProductListComponent {
  constructor(private repo: ProductRepository) {
  }

  get product() {
    return this.repo.product;
  }

  get products() {
    return this.repo.productListAll;
  }
}
