import {Component} from "@angular/core";
import {NavController} from "ionic-angular";

@Component({
  templateUrl:"create-credit.html"
})
export class CreateCreditPage{
  constructor(public nav:NavController){

  }

  public cancelCommand(){
    this.nav.pop();
  }
}
