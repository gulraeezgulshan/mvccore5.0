import { Component } from '@angular/core';
import { NgForm } from '@angular/forms';
import { ModalDismissReasons, NgbModal } from '@ng-bootstrap/ng-bootstrap';
import { ToastrService } from 'ngx-toastr';
import { ProductRepository } from '../models/product/product.service';
import { Supplier } from '../models/supplier/supplier.model';
import { SupplierRepository } from '../models/supplier/supplier.service';

@Component({
  selector: 'product-create',
  templateUrl: './product-create.component.html',
  styleUrls: ['./product-create.component.css']
})

export class ProductCreateComponent {


  constructor(public pRepo: ProductRepository,
    public sRepo: SupplierRepository,
    private toastr: ToastrService) {
  }

  //Page life-cycle method
  ngOnInit(): void {
    this.resetForm();
  }

  private resetForm() {
    this.sRepo.getSuppliers();
    this.pRepo.product.id = 0;
    this.pRepo.product.supplierId = 0;
  }

  get buttonText() {
    if (this.pRepo.product.id == 0) {
      return "Create Product";
    }
    else {
      return "Update Product";
    }
  }

  onSubmit(form: NgForm) {
    if (form.valid) {
      if (this.pRepo.product.id == 0) {
        this.postProduct(form);
      }
      else if (this.pRepo.product.id != 0) {
        this.putProduct(form);
        this.resetForm();
      }
    }


  }

  private putProduct(form: NgForm) {

    this.pRepo.putProduct().subscribe(res => {
      form.reset();
      this.pRepo.getProducts();
      this.toastr.success("Updated Succesfully", "Product Update");
    },
      err => {
        this.toastr.error("Oops! Something went wrong...", "Error");
        console.log(err);
      });
  }

  private postProduct(form: NgForm) {

    this.pRepo.postProduct().subscribe(
      res => {
        this.toastr.info("Submitted Succesfully", "Product Create");
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
