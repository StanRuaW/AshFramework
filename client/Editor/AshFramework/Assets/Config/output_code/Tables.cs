
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Plugin.Bright.Serialization;


namespace cfg
{
   
public sealed class Tables
{
    public test.TbFullTypes TbFullTypes {get; }
    public test.TbSingleton TbSingleton {get; }
    public test.TbDataFromJson TbDataFromJson {get; }
    public test.TbDataFromXml TbDataFromXml {get; }
    public test.TbDataFromLua TbDataFromLua {get; }
    public test.TbMultiRowRecord TbMultiRowRecord {get; }
    public test.TbTestNull TbTestNull {get; }
    public test.TbTestTag TbTestTag {get; }

    public Tables(System.Func<string, ByteBuf> loader)
    {
        var tables = new System.Collections.Generic.Dictionary<string, object>();
        TbFullTypes = new test.TbFullTypes(loader("test.TbFullTypes.bin")); 
        tables.Add("test.TbFullTypes", TbFullTypes);
        TbSingleton = new test.TbSingleton(loader("test.TbSingleton.bin")); 
        tables.Add("test.TbSingleton", TbSingleton);
        TbDataFromJson = new test.TbDataFromJson(loader("test.TbDataFromJson.bin")); 
        tables.Add("test.TbDataFromJson", TbDataFromJson);
        TbDataFromXml = new test.TbDataFromXml(loader("test.TbDataFromXml.bin")); 
        tables.Add("test.TbDataFromXml", TbDataFromXml);
        TbDataFromLua = new test.TbDataFromLua(loader("test.TbDataFromLua.bin")); 
        tables.Add("test.TbDataFromLua", TbDataFromLua);
        TbMultiRowRecord = new test.TbMultiRowRecord(loader("test.TbMultiRowRecord.bin")); 
        tables.Add("test.TbMultiRowRecord", TbMultiRowRecord);
        TbTestNull = new test.TbTestNull(loader("test.TbTestNull.bin")); 
        tables.Add("test.TbTestNull", TbTestNull);
        TbTestTag = new test.TbTestTag(loader("test.TbTestTag.bin")); 
        tables.Add("test.TbTestTag", TbTestTag);

        TbFullTypes.Resolve(tables); 
        TbSingleton.Resolve(tables); 
        TbDataFromJson.Resolve(tables); 
        TbDataFromXml.Resolve(tables); 
        TbDataFromLua.Resolve(tables); 
        TbMultiRowRecord.Resolve(tables); 
        TbTestNull.Resolve(tables); 
        TbTestTag.Resolve(tables); 
    }
}

}

