import { Product } from "./product.model";
import { Injectable } from "@angular/core";
import { HttpClient } from "@angular/common/http";
import { environment } from "src/environments/environment";


@Injectable()
export class ProductRepository {

  //Product must be initialized
  product: Product = new Product();
  products: Product[];

  constructor(private http: HttpClient) {

  }

  getProducts() {
    this.http.get(environment.apiURL + '/products/rel?related=true')
      .toPromise()
      .then(res => this.products = res as Product[]);
  }

  postProduct() {
    return this.http.post(environment.apiURL + '/products', this.product);
  }

  putProduct() {
    return this.http.put(environment.apiURL + '/products/' + this.product.id, this.product);
  }

  deleteProduct(id: Number) {
    return this.http.delete(environment.apiURL + '/products/' + id);
  }


}
