import { Product } from "./product.model";
import { Injectable } from "@angular/core";
import { HttpClient } from "@angular/common/http";
import { environment } from "src/environments/environment";


@Injectable()
export class ProductRepository {

  // Product product = new Product();
  product: Product;
  productList: Product[];
  productListAll: Product[];

  constructor(private http: HttpClient) {

    //this.getProduct(1);
    // this.getProducts(true, 'jacket');
    this.getAllProducts();
  }

  getProduct(id: number) {

    this.http.get<Product>(environment.apiURL + '/products/rel/' + id)
      .subscribe(p => this.product = p);
  }

  getAllProducts() {
    this.http.get<Product>(environment.apiURL + '/products/rel?related=true').subscribe(p => this.productListAll = p as Product[]);
  }

  getProducts(rel, cat) {
    this.http.get<Product>(environment.apiURL + '/products/rel?related=' + rel + '&category=' + cat).subscribe(p => this.productList = p as Product[]);
  }
}
