import { Injectable } from "@angular/core";
import { HttpClient } from "@angular/common/http";
import { environment } from "src/environments/environment";
import { Supplier } from "./supplier.model";


@Injectable()
export class SupplierRepository {

  suppliers: Supplier[] = [];
  supplier: Supplier = new Supplier();

  constructor(private http: HttpClient) {

    // this.getAllSuppliers();
  }

  getSuppliers() {

    this.http.get(environment.apiURL + '/suppliers')
      .toPromise()
      .then(res => this.suppliers = res as Supplier[]);
  }

  postSupplier() {
    return this.http.post(environment.apiURL + '/suppliers', this.supplier);
  }




}
