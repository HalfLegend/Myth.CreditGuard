import {Injectable} from "@angular/core";
import {SQLite, SQLiteObject} from "@ionic-native/sqlite";
import {BankInfo} from "../model/bank-info";

@Injectable()
export class SqliteService {
  private db: SQLiteObject;

  constructor(private sqlite: SQLite) {
  }

  public async initialize(): Promise<any>{
    return this.sqlite.create({
      name: 'CreditGuard.db',
      location: 'default'
    })
      .then(async (db: SQLiteObject) => {
        this.db = db;
        await this.createEntityTableAsync(BankInfo);
      })
  }

  public async createEntityTableAsync(entityType: any): Promise<any> {
    let entity = new entityType();
    let sql = "CREATE TABLE IF NOT EXISTS " + entityType + " (";
    let fieldSql = "";

    for (let key in entity) {
      if (entity.hasOwnProperty(key)) {
        if (fieldSql.length > 0){
          fieldSql += ", ";
        }
        fieldSql += this.camelCaseSnake(key);
      }
    }

    sql = sql + fieldSql + ")";

    return this.db.executeSql(sql, null);
  }

  public mapDataType(fieldType: string) : string{
    switch (fieldType){
      case "string":
        return "TEXT";
      case "number" :
        return "NUMERIC";
    }
  }

  public camelCaseSnake(camelCase:string):string{
    let result:string = "";
    for (let index = 0; index < camelCase.length; index++){
      let char = camelCase.charAt(index);
      if (this.isUpperCase(char) && result.length > 0){
        result += "_";
      }

      result += char.toUpperCase();
    }
    return result;
  }

  public isUpperCase(char : string):boolean{
    return char.toUpperCase() === char;
  }
}
