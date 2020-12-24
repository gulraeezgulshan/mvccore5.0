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

  get product(): Product {
    return this.repo.product;
  }

  get products(): Product[] {
    return this.repo.productListAll;
  }

  deleteProduct(id: Number) {
    this.repo.delete(id);
  }
}
