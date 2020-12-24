import { Supplier } from "../supplier/supplier.model";
import { Rating } from "../rating/rating.model";

export class Product {

  constructor(
    public id?: number,
    public name?: string,
    public category?: string,
    public description?: string,
    public price?: number,
    public supplierId?: number,
    public supplier?: Supplier,
    public ratings?: Rating[]) { }
}
