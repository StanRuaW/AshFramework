
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
public sealed partial class MoveToLocation :  ai.Task 
{
    public MoveToLocation(JsonElement _json)  : base(_json) 
    {
        { var _json0 = _json.GetProperty("location"); float __x; __x = _json0.GetProperty("x").GetSingle(); float __y; __y = _json0.GetProperty("y").GetSingle(); float __z; __z = _json0.GetProperty("z").GetSingle();  Location = new System.Numerics.Vector3(__x, __y,__z); }
        AcceptableRadius = _json.GetProperty("acceptable_radius").GetSingle();
    }

    public MoveToLocation(int id, string node_name, System.Collections.Generic.List<ai.Decorator> decorators, System.Collections.Generic.List<ai.Service> services, bool ignore_restart_self, System.Numerics.Vector3 location, float acceptable_radius )  : base(id,node_name,decorators,services,ignore_restart_self) 
    {
        this.Location = location;
        this.AcceptableRadius = acceptable_radius;
    }

    public static MoveToLocation DeserializeMoveToLocation(JsonElement _json)
    {
        return new ai.MoveToLocation(_json);
    }

    /// <summary>
    /// 
    /// </summary>
    public readonly System.Numerics.Vector3 Location;
    /// <summary>
    /// 
    /// </summary>
    public readonly float AcceptableRadius;

    public const int ID = -969953113;
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
        + "Location:" + Location + ","
        + "AcceptableRadius:" + AcceptableRadius + ","
        + "}";
    }
    }
}

