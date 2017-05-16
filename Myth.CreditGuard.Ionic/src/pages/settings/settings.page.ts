import {Component} from "@angular/core";
import {Icon} from "ionic-angular";

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
}
