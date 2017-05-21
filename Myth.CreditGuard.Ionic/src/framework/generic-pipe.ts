import {PipeTransform} from "@angular/core";

export interface GenericPipe<S, D> extends PipeTransform{
  transform(value: S, ...args: any[]): D;
}
