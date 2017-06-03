import {Component} from "@angular/core";
import {OverviewPage} from "./overview/overview.page";
import {CreditPage} from "./credit/credit.page";
import {SettingsPage} from "./settings/settings.page";
@Component({
  templateUrl: "layout.html"
})
export class LayoutPage {
  public tabPages:any[] = [];
  constructor() {
    this.tabPages.push(OverviewPage, CreditPage, SettingsPage);
  }
}
