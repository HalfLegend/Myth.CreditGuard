import { NgModule } from '@angular/core';

import { IonicPageModule } from 'ionic-angular';
import {BankCreationPage} from "./bank-creation.page";
import {EnumItemPipe} from "../../../../framework/enum-item-pipe";

@NgModule({
  declarations: [
    BankCreationPage,
    EnumItemPipe
  ],
  imports: [
    IonicPageModule.forChild(BankCreationPage)
  ],
  exports:[
    BankCreationPage,EnumItemPipe
  ],
  entryComponents: [
    BankCreationPage
  ]
})
export class BankCreationPageModule { }
