import { Pipe } from "@angular/core";

@Pipe({
  name: "addTax"
})

export class AddTaxPipe {

  defaultRate: number = 10;

  transform(value: any, rate?: any): number {

    //value = 300
    //rate = 10

    let valueNumber = Number.parseFloat(value);
    //Ternary Expression
    //Condition ? true : false
    let rateNumber = rate == undefined ? this.defaultRate : Number.parseInt(rate);

    return valueNumber + (valueNumber * (rateNumber / 100));

  }
}
