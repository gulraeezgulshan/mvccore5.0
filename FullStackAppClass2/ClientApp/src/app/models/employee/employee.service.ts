import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { environment } from 'src/environments/environment';

@Injectable()
export class EmployeeRepository {

  constructor(private http: HttpClient) { }

  postEmployee(formData) {
    return this.http.post(environment.apiURL + '/employees', formData);
  }

  putEmployee(formData) {
    return this.http.put(environment.apiURL + '/employees/' + formData.id, formData);
  }

  deleteEmployee(id) {
    return this.http.delete(environment.apiURL + '/employees/' + id);
  }

  getEmployeeList() {
    return this.http.get(environment.apiURL + '/employees');
  }
}
