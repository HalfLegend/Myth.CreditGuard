import {Pipe} from "@angular/core";
import {GenericPipe} from "../framework/generic-pipe";

export enum DueModeEnum{
  DaysAfterBilling = 1, FixedDate
}

@Pipe({
  name:"DueModeEnumPipe"
})
export class DueModeEnumPipe implements GenericPipe<DueModeEnum|string, string>{
  transform(value: DueModeEnum|string, ...args: any[]): string {
   let result = DueModeEnumPipe.transformImpl(value);
   if (!result){
     value = DueModeEnum[value];
     result = DueModeEnumPipe.transformImpl(value);
   }
   return result;
  }

  public static transformImpl(value: DueModeEnum|string): string {
    switch (value)
    {
      case DueModeEnum.DaysAfterBilling:
        return "X days after billing";
      case DueModeEnum.FixedDate:
        return "Fixed day of a month";
      default:
        return null;
    }
  }
}
