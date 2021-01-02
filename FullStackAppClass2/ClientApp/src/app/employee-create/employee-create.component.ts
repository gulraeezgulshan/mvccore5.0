import { Component } from '@angular/core';
import { FormArray, FormBuilder, FormGroup, Validators } from '@angular/forms';
import { ToastrService } from 'ngx-toastr';
import { DepartmentRepository } from '../models/employee/department.service';
import { EmployeeRepository } from '../models/employee/employee.service';

@Component({
  selector: 'employee-create',
  templateUrl: './employee-create.component.html',
  styleUrls: ['./employee-create.component.css']
})

export class EmployeeCreateComponent {

  employeeForms: FormArray = this.fb.array([]);
  departmentList = [];
  notification = null;
  editStatus: boolean = true;
  editIcon: string;

  constructor(
    private fb: FormBuilder,
    private dRepo: DepartmentRepository,
    private eRepo: EmployeeRepository,
    private toastr: ToastrService) {
  }

  ngOnInit() {
    this.dRepo.getDepartmentList().subscribe(res => this.departmentList = res as []);

    this.eRepo.getEmployeeList().subscribe(
      res => {
        if (res == [])
          this.addEmployeeForm();
        else {
          (res as []).forEach((e: any) => {
            this.employeeForms.push(this.fb.group({
              id: [e.id],
              firstName: [{ value: e.firstName, disabled: true }, Validators.required],
              lastName: [{ value: e.lastName, disabled: true }, Validators.required],
              age: [{ value: e.age, disabled: true }, Validators.min(1)],
              salary: [{ value: e.salary, disabled: true }, Validators.required],
              departmentId: [{ value: e.departmentId, disabled: true }, Validators.required]
            }));
          });
        }
      }
    );

  }

  addEmployeeForm() {
    this.employeeForms.push(
      this.fb.group({
        id: [0],
        firstName: ['', Validators.required],
        lastName: ['', Validators.required],
        age: [0, Validators.required],
        salary: [0, Validators.required],
        departmentId: [0, Validators.min(1)]
      }));
  }

  recordSubmit(fg: FormGroup) {
    if (fg.value.id == 0)
      this.eRepo.postEmployee(fg.value).subscribe(
        (res: any) => {
          fg.patchValue({ id: res.id });
          this.disableControls(fg, true);
          this.showNotification('insert');
        });
    else
      this.eRepo.putEmployee(fg.value).subscribe(
        (res: any) => {
          this.disableControls(fg, true);
          this.showNotification('update');
        });
  }

  onDelete(id, i) {
    if (id == 0)
      this.employeeForms.removeAt(i);
    else if (confirm('Are you sure to delete this record ?'))
      this.eRepo.deleteEmployee(id).subscribe(
        res => {
          this.employeeForms.removeAt(i);
          this.showNotification('delete');
        });
  }

  onEdit(fg: FormGroup) {
    //console.log(fg);

    if (this.editStatus) {
      this.disableControls(fg, false);
      this.editStatus = false;
      this.editIcon = "text-danger";
    }
    else {
      this.disableControls(fg, true);
      this.editStatus = true;
      this.editIcon = "text-info";
    }

  }

  disableControls(fg: FormGroup, status) {
    status ? fg.controls['firstName'].disable() : fg.controls['firstName'].enable();
    status ? fg.controls['lastName'].disable() : fg.controls['lastName'].enable();
    status ? fg.controls['age'].disable() : fg.controls['age'].enable();
    status ? fg.controls['salary'].disable() : fg.controls['salary'].enable();
    status ? fg.controls['departmentId'].disable() : fg.controls['departmentId'].enable();
  }

  showNotification(category) {
    switch (category) {
      case 'insert':
        this.notification = { class: 'text-success', message: 'saved!' };
        break;
      case 'update':
        this.notification = { class: 'text-primary', message: 'updated!' };
        break;
      case 'delete':
        this.notification = { class: 'text-danger', message: 'deleted!' };
        break;

      default:
        break;
    }
    setTimeout(() => {
      this.notification = null;
    }, 3000);
  }

}
