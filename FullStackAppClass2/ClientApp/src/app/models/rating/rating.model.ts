import { Product } from '../product/product.model';

export class Rating {
  constructor(
    public ratingId?: number,
    public stars?: number,
    public product?: Product) { }
}
