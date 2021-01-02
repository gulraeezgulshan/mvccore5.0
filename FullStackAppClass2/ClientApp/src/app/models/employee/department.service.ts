import { Injectable } from '@angular/core';
import { HttpClient } from "@angular/common/http";
import { environment } from 'src/environments/environment';

@Injectable()
export class DepartmentRepository {

  constructor(private http: HttpClient) { }

  getDepartmentList() {
    return this.http.get(environment.apiURL + '/Departments');
  }
}
