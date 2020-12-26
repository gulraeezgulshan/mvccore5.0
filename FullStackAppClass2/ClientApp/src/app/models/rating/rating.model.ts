import { Product } from '../product/product.model';

export class Rating {
  constructor(
    public id?: number,
    public stars?: number,
    public productId?: number,
    public product?: Product) { }
}
