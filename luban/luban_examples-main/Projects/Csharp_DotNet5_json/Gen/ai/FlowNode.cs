
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Bright.Serialization;
using System.Collections.Generic;
using System.Text.Json;



namespace cfg.ai
{

public abstract partial class FlowNode :  ai.Node 
{
    public FlowNode(JsonElement _json)  : base(_json) 
    {
        { var _json0 = _json.GetProperty("decorators"); Decorators = new System.Collections.Generic.List<ai.Decorator>(_json0.GetArrayLength()); foreach(JsonElement __e in _json0.EnumerateArray()) { ai.Decorator __v;  __v =  ai.Decorator.DeserializeDecorator(__e);  Decorators.Add(__v); }   }
        { var _json0 = _json.GetProperty("services"); Services = new System.Collections.Generic.List<ai.Service>(_json0.GetArrayLength()); foreach(JsonElement __e in _json0.EnumerateArray()) { ai.Service __v;  __v =  ai.Service.DeserializeService(__e);  Services.Add(__v); }   }
    }

    public FlowNode(int id, string node_name, System.Collections.Generic.List<ai.Decorator> decorators, System.Collections.Generic.List<ai.Service> services )  : base(id,node_name) 
    {
        this.Decorators = decorators;
        this.Services = services;
    }

    public static FlowNode DeserializeFlowNode(JsonElement _json)
    {
        switch (_json.GetProperty("__type__").GetString())
        {
            case "Sequence": return new ai.Sequence(_json);
            case "Selector": return new ai.Selector(_json);
            case "SimpleParallel": return new ai.SimpleParallel(_json);
            case "UeWait": return new ai.UeWait(_json);
            case "UeWaitBlackboardTime": return new ai.UeWaitBlackboardTime(_json);
            case "MoveToTarget": return new ai.MoveToTarget(_json);
            case "ChooseSkill": return new ai.ChooseSkill(_json);
            case "MoveToRandomLocation": return new ai.MoveToRandomLocation(_json);
            case "MoveToLocation": return new ai.MoveToLocation(_json);
            case "DebugPrint": return new ai.DebugPrint(_json);
            default: throw new SerializationException();
        }
    }

    public readonly System.Collections.Generic.List<ai.Decorator> Decorators;
    public readonly System.Collections.Generic.List<ai.Service> Services;


    public override void Resolve(Dictionary<string, object> _tables)
    {
        base.Resolve(_tables);
        foreach(var _e in Decorators) { _e?.Resolve(_tables); }
        foreach(var _e in Services) { _e?.Resolve(_tables); }
        OnResolveFinish(_tables);
    }

    partial void OnResolveFinish(Dictionary<string, object> _tables);

    public override string ToString()
    {
        return "{ "
        + "Id:" + Id + ","
        + "NodeName:" + NodeName + ","
        + "Decorators:" + Bright.Common.StringUtil.CollectionToString(Decorators) + ","
        + "Services:" + Bright.Common.StringUtil.CollectionToString(Services) + ","
        + "}";
    }
    }
}

