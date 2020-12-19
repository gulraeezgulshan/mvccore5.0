import { Product } from "./product.model";
import { Injectable } from "@angular/core";
import { HttpClient } from "@angular/common/http";


@Injectable()
export class Repository {

  // Product product = new Product();
  product: Product;

  constructor(private http: HttpClient) {

    this.getProduct(3);
  }

  getProduct(id: number) {

    this.http.get<Product>("/api/products/rel/" + id)
      .subscribe(p => this.product = p);
  }
}
