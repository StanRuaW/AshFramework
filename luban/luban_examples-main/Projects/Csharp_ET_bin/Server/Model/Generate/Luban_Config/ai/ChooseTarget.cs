
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Bright.Serialization;
using System.Collections.Generic;



namespace cfg.ai
{

public sealed partial class ChooseTarget :  ai.Service 
{
    public ChooseTarget(ByteBuf _buf)  : base(_buf) 
    {
        ResultTargetKey = _buf.ReadString();
    }

    public ChooseTarget(int id, string node_name, string result_target_key )  : base(id,node_name) 
    {
        this.ResultTargetKey = result_target_key;
    }

    public static ChooseTarget DeserializeChooseTarget(ByteBuf _buf)
    {
        return new ai.ChooseTarget(_buf);
    }

    public readonly string ResultTargetKey;

    public const int ID = 1601247918;
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
        + "ResultTargetKey:" + ResultTargetKey + ","
        + "}";
    }
    }

}

