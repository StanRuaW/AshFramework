
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



namespace cfg.ai
{

public sealed partial class MoveToLocation :  ai.Task 
{
    public MoveToLocation(JSONNode _json)  : base(_json) 
    {
        { var _json2 = _json["location"]; if(!_json2.IsObject) { throw new SerializationException(); } float __x; { if(!_json2["x"].IsNumber) { throw new SerializationException(); }  __x = _json2["x"]; } float __y; { if(!_json2["y"].IsNumber) { throw new SerializationException(); }  __y = _json2["y"]; } float __z; { if(!_json2["z"].IsNumber) { throw new SerializationException(); }  __z = _json2["z"]; }  Location = new System.Numerics.Vector3(__x, __y,__z); }
        { if(!_json["acceptable_radius"].IsNumber) { throw new SerializationException(); }  AcceptableRadius = _json["acceptable_radius"]; }
    }

    public MoveToLocation(int id, string node_name, System.Collections.Generic.List<ai.Decorator> decorators, System.Collections.Generic.List<ai.Service> services, bool ignore_restart_self, System.Numerics.Vector3 location, float acceptable_radius )  : base(id,node_name,decorators,services,ignore_restart_self) 
    {
        this.Location = location;
        this.AcceptableRadius = acceptable_radius;
    }

    public static MoveToLocation DeserializeMoveToLocation(JSONNode _json)
    {
        return new ai.MoveToLocation(_json);
    }

    public readonly System.Numerics.Vector3 Location;
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

