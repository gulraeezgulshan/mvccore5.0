import { Component } from '@angular/core';
import { Product } from './models/product.model';
import { ProductRepository } from './models/product.service';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent {
  constructor(private repo: ProductRepository) {
  }

  get product(): Product {
    return this.repo.product;
  }
}
