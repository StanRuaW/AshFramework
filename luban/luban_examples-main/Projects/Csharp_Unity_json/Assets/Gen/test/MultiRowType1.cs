
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Bright.Serialization;
using System.Collections.Generic;
using SimpleJSON;



namespace cfg.test
{

public sealed partial class MultiRowType1 :  Bright.Config.BeanBase 
{
    public MultiRowType1(JSONNode _json) 
    {
        { if(!_json["id"].IsNumber) { throw new SerializationException(); }  Id = _json["id"]; }
        { if(!_json["x"].IsNumber) { throw new SerializationException(); }  X = _json["x"]; }
    }

    public MultiRowType1(int id, int x ) 
    {
        this.Id = id;
        this.X = x;
    }

    public static MultiRowType1 DeserializeMultiRowType1(JSONNode _json)
    {
        return new test.MultiRowType1(_json);
    }

    public readonly int Id;
    public readonly int X;

    public const int ID = 540474970;
    public override int GetTypeId() => ID;

    public  void Resolve(Dictionary<string, object> _tables)
    {
        OnResolveFinish(_tables);
    }

    partial void OnResolveFinish(Dictionary<string, object> _tables);

    public override string ToString()
    {
        return "{ "
        + "Id:" + Id + ","
        + "X:" + X + ","
        + "}";
    }
    }
}

