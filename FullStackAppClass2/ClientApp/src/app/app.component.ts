import { Component } from '@angular/core';
import { Product } from './models/product/product.model';
import { ProductRepository } from './models/product/product.service';

@Component({
  selector: 'root',
  templateUrl: './app.component.html'
})

export class AppComponent {
  constructor(private repo: ProductRepository) {
  }

  get product(): Product {
    return this.repo.product;
  }

  get products(): Product[] {
    return this.repo.productList;
  }
}
