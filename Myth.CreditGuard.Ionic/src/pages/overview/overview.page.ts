import {Component} from "@angular/core";
import {NavController} from "ionic-angular";

@Component({
  templateUrl: "overview.page.html",
  selector: "overview-page"
})
export class OverviewPage {
  public static get title(): string {
    return "Overview";
  }

  public static get iconName(): string {
    return "home"
  }
}
