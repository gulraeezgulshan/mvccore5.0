import { Component, OnInit } from '@angular/core';
import { ToastrService } from 'ngx-toastr';
import { UserRepository } from '../models/user/user.service';

@Component({
  selector: 'user-registration',
  templateUrl: './user-registration.component.html'
})
export class UserRegistrationComponent implements OnInit {

  constructor(public repo: UserRepository, private toastr: ToastrService) { }

  ngOnInit() {
    this.repo.formModel.reset();
  }

  onSubmit() {
    this.repo.register().subscribe(
      (res: any) => {
        if (res.succeeded) {
          this.repo.formModel.reset();
          this.toastr.success('New user created!', 'Registration successful.');
        } else {
          res.errors.forEach(element => {
            switch (element.code) {
              case 'DuplicateUserName':
                this.toastr.error('Username is already taken', 'Registration failed.');
                break;
              default:
                this.toastr.error(element.description, 'Registration failed.');
                break;
            }
          });
        }
      },
      err => {
        console.log(err);
      }
    );
  }

}
