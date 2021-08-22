
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



namespace cfg.condition
{

public abstract partial class Condition :  Bright.Config.BeanBase 
{
    public Condition(JSONNode _json) 
    {
    }

    public Condition() 
    {
    }

    public static Condition DeserializeCondition(JSONNode _json)
    {
        string type = _json["__type__"];
        switch (type)
        {
            case "TimeRange": return new condition.TimeRange(_json);
            case "MultiRoleCondition": return new condition.MultiRoleCondition(_json);
            case "GenderLimit": return new condition.GenderLimit(_json);
            case "MinLevel": return new condition.MinLevel(_json);
            case "MaxLevel": return new condition.MaxLevel(_json);
            case "MinMaxLevel": return new condition.MinMaxLevel(_json);
            case "ClothesPropertyScoreGreaterThan": return new condition.ClothesPropertyScoreGreaterThan(_json);
            case "ContainsItem": return new condition.ContainsItem(_json);
            default: throw new SerializationException();
        }
    }



    public virtual void Resolve(Dictionary<string, object> _tables)
    {
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

