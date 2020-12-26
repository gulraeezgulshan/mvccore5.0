import { Injectable } from "@angular/core";
import { HttpClient } from "@angular/common/http";
import { environment } from "src/environments/environment";
import { Rating } from "./rating.model";


@Injectable()
export class RatingRepository {

  rating: Rating = new Rating();

  constructor(private http: HttpClient) {

  }

  postRating() {
    return this.http.post(environment.apiURL + '/ratings', this.rating);
  }

}
