import {Component} from "@angular/core";
import {IonicPage} from "ionic-angular";
import {DueModeEnum} from "../../../../model/due-mode.enum";
import {BankInfo} from "../../../../model/bank-info";

@IonicPage()
@Component({
  selector:"bank-creation",
  templateUrl:"bank-creation.html"
})
export class BankCreationPage{
    DueModeEnum = DueModeEnum;

    bankInfo = new BankInfo();
    public saveBankCommand(){

    }
}
