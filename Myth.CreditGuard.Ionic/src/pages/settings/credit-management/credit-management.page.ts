import {Component} from "@angular/core";
import {CreateCreditPage} from "./create-credit/create-credit.page";
import {NavController} from "ionic-angular";

@Component({
  templateUrl:"credit-management.html"
})
export class CreditManagementPage{
    public static get title():string{
      return "Credit Management";
    }

  constructor(public nav: NavController) {

  }

  public createCreditCommand(): void {
    this.nav.push(CreateCreditPage);
  }
}
