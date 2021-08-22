
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

/// <summary>
/// 
/// </summary>
public sealed partial class MoveToTarget :  ai.Task 
{
    public MoveToTarget(JsonElement _json)  : base(_json) 
    {
        TargetActorKey = _json.GetProperty("target_actor_key").GetString();
        AcceptableRadius = _json.GetProperty("acceptable_radius").GetSingle();
    }

    public MoveToTarget(int id, string node_name, System.Collections.Generic.List<ai.Decorator> decorators, System.Collections.Generic.List<ai.Service> services, bool ignore_restart_self, string target_actor_key, float acceptable_radius )  : base(id,node_name,decorators,services,ignore_restart_self) 
    {
        this.TargetActorKey = target_actor_key;
        this.AcceptableRadius = acceptable_radius;
    }

    public static MoveToTarget DeserializeMoveToTarget(JsonElement _json)
    {
        return new ai.MoveToTarget(_json);
    }

    /// <summary>
    /// 
    /// </summary>
    public readonly string TargetActorKey;
    /// <summary>
    /// 
    /// </summary>
    public readonly float AcceptableRadius;

    public const int ID = 514987779;
    public override int GetTypeId() => ID;

    public override void Resolve(Dictionary<string, object> _tables)
    {
        base.Resolve(_tables);
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
        + "IgnoreRestartSelf:" + IgnoreRestartSelf + ","
        + "TargetActorKey:" + TargetActorKey + ","
        + "AcceptableRadius:" + AcceptableRadius + ","
        + "}";
    }
    }
}

