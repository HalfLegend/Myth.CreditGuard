import { Component } from '@angular/core';
import { Platform } from 'ionic-angular';
import { StatusBar } from '@ionic-native/status-bar';
import { SplashScreen } from '@ionic-native/splash-screen';

import {LayoutPage} from "../pages/layout.page";
import {SqliteService} from "../service/sqlite-service";

@Component({
  templateUrl: 'app.html'
})
export class CreditGuardApp {
  rootPage:any = LayoutPage;

  constructor(platform: Platform, statusBar: StatusBar, splashScreen: SplashScreen, sqlite: SqliteService) {
    platform.ready().then(async () => {
      // Okay, so the platform is ready and our plugins are available.
      // Here you can do any higher level native things you might need.
      statusBar.styleDefault();
      splashScreen.hide();
      await sqlite.initialize();
    });
  }
}
