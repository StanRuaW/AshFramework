
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



namespace cfg.limit
{

public abstract partial class DailyLimitBase :  limit.LimitBase 
{
    public DailyLimitBase(JSONNode _json)  : base(_json) 
    {
    }

    public DailyLimitBase()  : base() 
    {
    }

    public static DailyLimitBase DeserializeDailyLimitBase(JSONNode _json)
    {
        string type = _json["__type__"];
        switch (type)
        {
            case "DailyLimit": return new limit.DailyLimit(_json);
            default: throw new SerializationException();
        }
    }



    public override void Resolve(Dictionary<string, object> _tables)
    {
        base.Resolve(_tables);
        OnResolveFinish(_tables);
    }

    partial void OnResolveFinish(Dictionary<string, object> _tables);

    public override string ToString()
    {
        return "{ "
        + "}";
    }
    }
}

