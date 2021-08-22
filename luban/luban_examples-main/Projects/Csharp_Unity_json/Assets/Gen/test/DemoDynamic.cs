
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

public abstract partial class DemoDynamic :  Bright.Config.BeanBase 
{
    public DemoDynamic(JSONNode _json) 
    {
        { if(!_json["x1"].IsNumber) { throw new SerializationException(); }  X1 = _json["x1"]; }
    }

    public DemoDynamic(int x1 ) 
    {
        this.X1 = x1;
    }

    public static DemoDynamic DeserializeDemoDynamic(JSONNode _json)
    {
        string type = _json["__type__"];
        switch (type)
        {
            case "DemoD2": return new test.DemoD2(_json);
            case "DemoE1": return new test.DemoE1(_json);
            case "DemoD5": return new test.DemoD5(_json);
            default: throw new SerializationException();
        }
    }

    public readonly int X1;


    public virtual void Resolve(Dictionary<string, object> _tables)
    {
        OnResolveFinish(_tables);
    }

    partial void OnResolveFinish(Dictionary<string, object> _tables);

    public override string ToString()
    {
        return "{ "
        + "X1:" + X1 + ","
        + "}";
    }
    }
}

