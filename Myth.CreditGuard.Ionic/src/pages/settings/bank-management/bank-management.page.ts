import {Component} from "@angular/core";
import {BankCreationPage} from "./bank-creation/bank-creation.page";
import {NavController} from "ionic-angular";

@Component({
  templateUrl: "bank-management.html"
})
export class BankManagementPage {
  BankCreationPage:any = BankCreationPage;
  public static get title(): string {
    return "Bank Management";
  }

  constructor(public nav:NavController){

  }
}
