import { NgModule, ErrorHandler } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { IonicApp, IonicModule, IonicErrorHandler } from 'ionic-angular';
import { CreditGuardApp } from './app.component';

import { StatusBar } from '@ionic-native/status-bar';
import { SplashScreen } from '@ionic-native/splash-screen';
import {LayoutPage} from "../pages/layout-page/layout.page";
import {OverviewPage} from "../pages/overview-page/overview.page";
import {CreditPage} from "../pages/credit-page/credit.page";

@NgModule({
  declarations: [
    CreditGuardApp,
    OverviewPage,
    CreditPage,
    LayoutPage
  ],
  imports: [
    BrowserModule,
    IonicModule.forRoot(CreditGuardApp)
  ],
  bootstrap: [IonicApp],
  entryComponents: [
    CreditGuardApp,
    OverviewPage,
    CreditPage,
    LayoutPage
  ],
  providers: [
    StatusBar,
    SplashScreen,
    {provide: ErrorHandler, useClass: IonicErrorHandler}
  ]
})
export class AppModule {}
