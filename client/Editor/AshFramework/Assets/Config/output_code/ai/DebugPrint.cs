
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
using Plugin.Bright.Serialization;
using System.Collections.Generic;



namespace cfg.ai
{

public sealed partial class DebugPrint :  ai.Task 
{
    public DebugPrint(ByteBuf _buf)  : base(_buf) 
    {
        Text = _buf.ReadString();
    }

    public static DebugPrint DeserializeDebugPrint(ByteBuf _buf)
    {
        return new ai.DebugPrint(_buf);
    }

    public string Text { get; private set; }

    public const int ID = 1357409728;
    public override int GetTypeId() => ID;

    public override void Resolve(Dictionary<string, object> _tables)
    {
        base.Resolve(_tables);
    }

    public override void TranslateText(System.Func<string, string, string> translator)
    {
        base.TranslateText(translator);
    }

    public override string ToString()
    {
        return "{ "
        + "Id:" + Id + ","
        + "NodeName:" + NodeName + ","
        + "Decorators:" + Plugin.Bright.Common.StringUtil.CollectionToString(Decorators) + ","
        + "Services:" + Plugin.Bright.Common.StringUtil.CollectionToString(Services) + ","
        + "IgnoreRestartSelf:" + IgnoreRestartSelf + ","
        + "Text:" + Text + ","
        + "}";
    }
    }

}
