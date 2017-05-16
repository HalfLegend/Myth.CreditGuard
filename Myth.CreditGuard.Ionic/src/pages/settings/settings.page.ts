import {Component} from "@angular/core";
import {NavController} from "ionic-angular";
import {BankManagementPage} from "./bank-management/bank-management.page";
import {CreditManagementPage} from "./credit-management/credit-management.page";

@Component({
  templateUrl: "settings.html"
})
export class SettingsPage {
  public static get title(): string {
    return "Settings"
  }

  public static get iconName(): string {
    return "settings"
  };

  settingPages:Array<any> = [];
  constructor(public nav: NavController){
    this.settingPages.push(CreditManagementPage, BankManagementPage);
  }

  navSettingPage(settingPage : any){
    this.nav.push(settingPage);
  }
}
