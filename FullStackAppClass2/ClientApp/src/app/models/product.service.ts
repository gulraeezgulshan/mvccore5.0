import { Product } from "./product.model";
import { Injectable } from "@angular/core";
import { HttpClient } from "@angular/common/http";
import { environment } from "src/environments/environment";


@Injectable()
export class ProductRepository {

  // Product product = new Product();
  product: Product;

  constructor(private http: HttpClient) {

    this.getProductRelated(1);
  }

  getProductRelated(id: number) {

    this.http.get<Product>(environment.apiURL + '/products/rel/' + id)
      .subscribe(p => this.product = p);
  }
}
