import "reflect-metadata";

const formatMetadataKey = Symbol("DataType");
export function DataType(dataType: string) {
  return Reflect.metadata(formatMetadataKey, dataType);
}

export function getDataType(target: any, propertyKey: string):string{
  return Reflect.getMetadata(formatMetadataKey, target, propertyKey);
}
