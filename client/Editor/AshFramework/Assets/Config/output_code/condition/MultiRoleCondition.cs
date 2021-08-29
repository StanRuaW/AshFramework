
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
using Plugin.Bright.Serialization;
using System.Collections.Generic;



namespace cfg.condition
{

public sealed partial class MultiRoleCondition :  condition.RoleCondition 
{
    public MultiRoleCondition(ByteBuf _buf)  : base(_buf) 
    {
        {int n = System.Math.Min(_buf.ReadSize(), _buf.Size);Conditions = new condition.RoleCondition[n];for(var i = 0 ; i < n ; i++) { condition.RoleCondition _e;_e = condition.RoleCondition.DeserializeRoleCondition(_buf); Conditions[i] = _e;}}
    }

    public static MultiRoleCondition DeserializeMultiRoleCondition(ByteBuf _buf)
    {
        return new condition.MultiRoleCondition(_buf);
    }

    public condition.RoleCondition[] Conditions { get; private set; }

    public const int ID = 934079583;
    public override int GetTypeId() => ID;

    public override void Resolve(Dictionary<string, object> _tables)
    {
        base.Resolve(_tables);
        foreach(var _e in Conditions) { _e?.Resolve(_tables); }
    }

    public override void TranslateText(System.Func<string, string, string> translator)
    {
        base.TranslateText(translator);
        foreach(var _e in Conditions) { _e?.TranslateText(translator); }
    }

    public override string ToString()
    {
        return "{ "
        + "Conditions:" + Plugin.Bright.Common.StringUtil.CollectionToString(Conditions) + ","
        + "}";
    }
    }

}
