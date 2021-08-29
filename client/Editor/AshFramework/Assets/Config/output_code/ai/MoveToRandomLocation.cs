
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

public sealed partial class MoveToRandomLocation :  ai.Task 
{
    public MoveToRandomLocation(ByteBuf _buf)  : base(_buf) 
    {
        OriginPositionKey = _buf.ReadString();
        Radius = _buf.ReadFloat();
    }

    public static MoveToRandomLocation DeserializeMoveToRandomLocation(ByteBuf _buf)
    {
        return new ai.MoveToRandomLocation(_buf);
    }

    public string OriginPositionKey { get; private set; }
    public float Radius { get; private set; }

    public const int ID = -2140042998;
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
        + "OriginPositionKey:" + OriginPositionKey + ","
        + "Radius:" + Radius + ","
        + "}";
    }
    }

}