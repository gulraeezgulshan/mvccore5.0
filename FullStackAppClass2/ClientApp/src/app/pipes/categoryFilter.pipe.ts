import { Pipe } from "@angular/core";
import { Product } from "../models/product/product.model";

@Pipe({
  name: "filter"
})
export class CategoryFilterPipe {
  transform(products: Product[], category: string): Product[] {
    return (category == undefined || category == "All") ? products : products.filter(p => p.category == category);
  }
}
