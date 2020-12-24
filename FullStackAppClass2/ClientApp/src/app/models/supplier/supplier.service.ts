import { Injectable } from "@angular/core";
import { HttpClient } from "@angular/common/http";
import { environment } from "src/environments/environment";
import { Supplier } from "./supplier.model";


@Injectable()
export class SupplierRepository {

  suppliersList: Supplier[] = [];

  constructor(private http: HttpClient) {

    this.getAllSuppliers();
  }

  getAllSuppliers() {
    this.http.get<Supplier>(environment.apiURL + '/suppliers').subscribe(s => this.suppliersList = s as Supplier[]);
  }




}
