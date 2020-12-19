import { Component } from '@angular/core';
import { Product } from './models/product.model';
import { Repository } from './models/repository';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent {
  constructor(private repo: Repository) { }

  get product(): Product {
    return this.repo.product;
  }
}
