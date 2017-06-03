import {Component} from "@angular/core";

@Component({
  templateUrl: "credit.page.html",
  selector: "credit-page"
})
export class CreditPage {
  public static get title(): string {
    return "Credit"
  };

  public static get iconName(): string {
    return "card";
  }
}
