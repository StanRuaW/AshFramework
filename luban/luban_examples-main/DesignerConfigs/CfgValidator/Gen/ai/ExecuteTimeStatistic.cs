
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
public sealed partial class ExecuteTimeStatistic :  ai.Service 
{
    public ExecuteTimeStatistic(JsonElement _json)  : base(_json) 
    {
    }

    public ExecuteTimeStatistic(int id, string node_name )  : base(id,node_name) 
    {
    }

    public static ExecuteTimeStatistic DeserializeExecuteTimeStatistic(JsonElement _json)
    {
        return new ai.ExecuteTimeStatistic(_json);
    }


    public const int ID = 990693812;
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
        + "}";
    }
    }
}

