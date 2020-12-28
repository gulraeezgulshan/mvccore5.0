import { Component } from '@angular/core';
import { NgForm } from '@angular/forms';
import { RatingRepository } from '../models/rating/rating.service';
import { ToastrService } from 'ngx-toastr';
import { ProductRepository } from '../models/product/product.service';
import { ModalDismissReasons, NgbModal } from '@ng-bootstrap/ng-bootstrap';
import { SupplierRepository } from '../models/supplier/supplier.service';
import { Supplier } from '../models/supplier/supplier.model';

@Component({
  selector: 'supplier-create',
  templateUrl: './supplier-create.component.html',
  styleUrls: ['./supplier-create.component.css']
})

export class SupplierCreateComponent {



  constructor(
    private modalService: NgbModal,
    public repo: SupplierRepository,
    private toastr: ToastrService) {

  }

  ngOnInit() {

  }

  onSubmit(form: NgForm) {
    if (form.valid) {
      this.repo.postSupplier().subscribe(
        res => {
          //console.log(form.value)
          this.toastr.info("Submitted Succesfully", "Supplier Create");
          form.reset();
          this.repo.getSuppliers();
        },
        err => {
          this.toastr.error("Oops! Something went wrong...", "Error");
        }
      );
    }

  }

  closeResult = '';

  open(content) {
    this.modalService.open(content, { ariaLabelledBy: 'modal-basic-title' }).result.then((result) => {
      this.closeResult = `Closed with: ${result}`;
    }, (reason) => {
      this.closeResult = `Dismissed ${this.getDismissReason(reason)}`;
    });
  }

  private getDismissReason(reason: any): string {
    if (reason === ModalDismissReasons.ESC) {
      return 'by pressing ESC';
    } else if (reason === ModalDismissReasons.BACKDROP_CLICK) {
      return 'by clicking on a backdrop';
    } else {
      return `with: ${reason}`;
    }
  }

}
