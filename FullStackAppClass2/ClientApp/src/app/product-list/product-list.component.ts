import { Component } from '@angular/core';
import { ToastrService } from 'ngx-toastr';
import { Product } from '../models/product/product.model';
import { ProductRepository } from '../models/product/product.service';
import { RatingRepository } from '../models/rating/rating.service';

@Component({
  selector: 'product-list',
  templateUrl: './product-list.component.html'
})

export class ProductListComponent {

  selectedProduct: Number;
  taxRate: number = 0;
  categoryFilter: string;
  itemCount: number = 3;


  constructor(
    public repo: ProductRepository,
    private rRepo: RatingRepository,
    private toastr: ToastrService) {

  }

  ngOnInit() {
    this.repo.getProducts();
  }

  counter(i: number) {
    return new Array(i);
  }

  populateForm(pd: Product) {
    this.repo.product = Object.assign({}, pd);
  }

  populateRating(id) {
    this.rRepo.rating.productId = id
  }

  onDelete(id) {
    if (confirm('Are you sure to delete this record ?')) {
      this.repo.deleteProduct(id)
        .subscribe(res => {
          this.repo.getProducts();
          this.toastr.warning('Deleted successfully', 'Product Delete');
        },
          err => {
            console.log(err);
          })
    }
  }

  getSelected(product: Product): boolean {
    return product.id == this.selectedProduct;
  }

  get SumOfPrice() {
    return this.repo.products.reduce((acc, curr) => acc + curr.price, 0);
  }

  get AverageOfPrice() {
    return this.SumOfPrice / this.repo.products.length;
  }

  getAverageRating(id: number) {
    let product = this.repo.products.filter((p) => p.id == id) as Product;
    return product[0].ratings.reduce((acc, curr) => acc + curr.stars, 0) / product[0].ratings.length;
  }

}
