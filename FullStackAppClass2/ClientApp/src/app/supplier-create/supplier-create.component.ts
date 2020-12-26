import { Component } from '@angular/core';
import { NgForm } from '@angular/forms';
import { RatingRepository } from '../models/rating/rating.service';
import { ToastrService } from 'ngx-toastr';
import { ProductRepository } from '../models/product/product.service';
import { ModalDismissReasons, NgbModal } from '@ng-bootstrap/ng-bootstrap';

@Component({
  selector: 'supplier-create',
  templateUrl: './supplier-create.component.html'
})

export class SupplierCreateComponent {


  constructor(private modalService: NgbModal) {

  }

  ngOnInit() {

  }

  onSubmit(form: NgForm) {
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
