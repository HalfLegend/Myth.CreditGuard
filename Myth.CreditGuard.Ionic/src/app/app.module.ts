import { NgModule, ErrorHandler } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { IonicApp, IonicModule, IonicErrorHandler } from 'ionic-angular';
import { CreditGuardApp } from './app.component';

import { StatusBar } from '@ionic-native/status-bar';
import { SplashScreen } from '@ionic-native/splash-screen';
import {LayoutPage} from "../pages/layout.page";
import {OverviewPage} from "../pages/overview/overview.page";
import {CreditPage} from "../pages/credit/credit.page";
import {SettingsPage} from "../pages/settings/settings.page";
import {CreditManagementPage} from "../pages/settings/credit-management/credit-management.page";
import {BankManagementPage} from "../pages/settings/bank-management/bank-management.page";
import {CreateCreditPage} from "../pages/settings/credit-management/credit-creation/credit-creation.page";
import {BankCreationPageModule} from "../pages/settings/bank-management/bank-creation/bank-creation.page.module";
import {DueModeEnumPipe} from "../model/due-mode.enum";
import {SqliteService} from "../service/sqlite-service";
import {SQLite} from "@ionic-native/sqlite";

@NgModule({
  declarations: [
    CreditGuardApp,
    DueModeEnumPipe,
    LayoutPage,
    OverviewPage,
    CreditPage,
    SettingsPage,
    CreditManagementPage,
    CreateCreditPage,
    BankManagementPage
  ],
  imports: [
    BrowserModule,
    IonicModule.forRoot(CreditGuardApp),
    BankCreationPageModule
  ],
  bootstrap: [IonicApp],
  entryComponents: [
    CreditGuardApp,
    LayoutPage,
    OverviewPage,
    CreditPage,
    SettingsPage,
    CreditManagementPage,
    CreateCreditPage,
    BankManagementPage

  ],
  providers: [
    StatusBar,
    SplashScreen,
    SQLite,
    SqliteService,
    {provide: ErrorHandler, useClass: IonicErrorHandler}
  ]
})
export class AppModule {}
