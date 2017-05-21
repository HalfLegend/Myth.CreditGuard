import {Component} from "@angular/core";
import {CreateCreditPage} from "./credit-creation/credit-creation.page";
import {NavController} from "ionic-angular";

@Component({
  templateUrl: "credit-management.html"
})
export class CreditManagementPage {
  CreateCreditPage: any = CreateCreditPage;

  public static get title(): string {
    return "Credit Management";
  }

  constructor(public nav: NavController) {

  }
}
