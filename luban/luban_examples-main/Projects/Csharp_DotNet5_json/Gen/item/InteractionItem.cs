
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



namespace cfg.item
{

public sealed partial class InteractionItem :  item.ItemExtra 
{
    public InteractionItem(JsonElement _json)  : base(_json) 
    {
        { if (_json.TryGetProperty("attack_num", out var _j) && _j.ValueKind != JsonValueKind.Null) { AttackNum = _j.GetInt32(); } else { AttackNum = null; } }
        HoldingStaticMesh = _json.GetProperty("holding_static_mesh").GetString();
        HoldingStaticMeshMat = _json.GetProperty("holding_static_mesh_mat").GetString();
    }

    public InteractionItem(int id, int? attack_num, string holding_static_mesh, string holding_static_mesh_mat )  : base(id) 
    {
        this.AttackNum = attack_num;
        this.HoldingStaticMesh = holding_static_mesh;
        this.HoldingStaticMeshMat = holding_static_mesh_mat;
    }

    public static InteractionItem DeserializeInteractionItem(JsonElement _json)
    {
        return new item.InteractionItem(_json);
    }

    public readonly int? AttackNum;
    public readonly string HoldingStaticMesh;
    public readonly string HoldingStaticMeshMat;

    public const int ID = 640937802;
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
        + "AttackNum:" + AttackNum + ","
        + "HoldingStaticMesh:" + HoldingStaticMesh + ","
        + "HoldingStaticMeshMat:" + HoldingStaticMeshMat + ","
        + "}";
    }
    }
}

