import {GenericPipe} from "./generic-pipe";
import {DueModeEnumPipe} from "../model/due-mode.enum";
import {Pipe} from "@angular/core";

@Pipe({
  name: "EnumItemPipe"
})
export class EnumItemPipe implements GenericPipe<any, Array<EnumItem>> {
  transform(enumType: any, ...args: any[]): Array<EnumItem> {
    let resultArray: Array<EnumItem> = [];
    for (let key in enumType) {
      if (enumType.hasOwnProperty(key)) {
        let enumItem: EnumItem = {key: key, value: enumType[key]};
        resultArray.push(enumItem);
      }
    }
    if (resultArray.length > 0) {
      resultArray = resultArray.slice(resultArray.length / 2, resultArray.length);
      for (let enumItem of resultArray) {
        enumItem.label = DueModeEnumPipe.transformImpl(enumItem.value);
      }
    }
    return resultArray;
  }
}

export interface EnumItem {
  key: string;
  value: string;
  label?: string;
}
