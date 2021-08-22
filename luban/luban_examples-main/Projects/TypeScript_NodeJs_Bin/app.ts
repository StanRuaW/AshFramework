
import ByteBuf from "./bright/serialization/ByteBuf";
import {cfg} from "./Gen/Types";
import {readFileSync} from 'fs'

function loader(file: string): any {
    let data: any = readFileSync('../GenerateDatas/bin/' + file + '.bin');
    return new ByteBuf(data)
}

//let tables = new cfg.Tables(loader);
let tables = new cfg.Tables(loader);
console.log(tables);

