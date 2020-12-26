import { Component } from '@angular/core';
import { NgForm } from '@angular/forms';
import { RatingRepository } from '../models/rating/rating.service';
import { ToastrService } from 'ngx-toastr';
import { ProductRepository } from '../models/product/product.service';

@Component({
  selector: 'product-rating',
  templateUrl: './product-rating.component.html'
})

export class ProductRatingComponent {


  constructor(
    public rRepo: RatingRepository,
    private toastr: ToastrService,
    private pRepo: ProductRepository) {

  }

  ngOnInit() {
    this.rRepo.rating.productId = 0;
  }

  onSubmit(form: NgForm) {
    //console.log(this.rRepo.rating);
    this.rRepo.postRating().subscribe(
      res => {
        this.toastr.info("Submitted Succesfully", "Product Rating");
        form.reset();
        this.pRepo.getProducts();
      },
      err => {
        this.toastr.error("Oops! Something went wrong...", "Error");
        console.log(err);
      }
    );
  }

}
