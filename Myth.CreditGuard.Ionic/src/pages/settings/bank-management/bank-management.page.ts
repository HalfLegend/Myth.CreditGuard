import {Component} from "@angular/core";

@Component({
  templateUrl:"bank-management.html"
})
export class BankManagementPage{
  public static get title():string{
    return "Bank Management";
  }
}
