
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



namespace cfg.error
{

/// <summary>
/// 
/// </summary>
public sealed partial class ErrorStyleMsgbox :  error.ErrorStyle 
{
    public ErrorStyleMsgbox(JsonElement _json)  : base(_json) 
    {
        BtnName = _json.GetProperty("btn_name").GetString();
        Operation = (error.EOperation)_json.GetProperty("operation").GetInt32();
    }

    public ErrorStyleMsgbox(string btn_name, error.EOperation operation )  : base() 
    {
        this.BtnName = btn_name;
        this.Operation = operation;
    }

    public static ErrorStyleMsgbox DeserializeErrorStyleMsgbox(JsonElement _json)
    {
        return new error.ErrorStyleMsgbox(_json);
    }

    /// <summary>
    /// 
    /// </summary>
    public readonly string BtnName;
    /// <summary>
    /// 
    /// </summary>
    public readonly error.EOperation Operation;

    public const int ID = -1920482343;
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
        + "BtnName:" + BtnName + ","
        + "Operation:" + Operation + ","
        + "}";
    }
    }
}

