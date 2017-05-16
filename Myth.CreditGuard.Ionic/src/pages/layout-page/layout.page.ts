import {Component} from "@angular/core";
import {OverviewPage} from "../overview-page/overview.page";
import {CreditPage} from "../credit-page/credit.page";
@Component({
  templateUrl: "layout.page.html"
})
export class LayoutPage {
  public tabPages:any[] = [];
  constructor() {
    console.log(OverviewPage.title);
    this.tabPages.push(OverviewPage, CreditPage);
  }
}
