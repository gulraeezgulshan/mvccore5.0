import { Component } from '@angular/core';
import { ToastrService } from 'ngx-toastr';
import { Product } from '../models/product/product.model';
import { ProductRepository } from '../models/product/product.service';

@Component({
  selector: 'product-list',
  templateUrl: './product-list.component.html'
})

export class ProductListComponent {

  selectedProduct: Number;

  constructor(public repo: ProductRepository, private toastr: ToastrService) {

  }

  ngOnInit() {
    this.repo.getProducts();
  }

  populateForm(pd: Product) {
    this.repo.product = Object.assign({}, pd);
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


}
