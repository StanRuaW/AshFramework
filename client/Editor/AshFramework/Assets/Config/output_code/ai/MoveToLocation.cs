
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

public sealed partial class MoveToLocation :  ai.Task 
{
    public MoveToLocation(ByteBuf _buf)  : base(_buf) 
    {
        Location = _buf.ReadUnityVector3();
        AcceptableRadius = _buf.ReadFloat();
    }

    public static MoveToLocation DeserializeMoveToLocation(ByteBuf _buf)
    {
        return new ai.MoveToLocation(_buf);
    }

    public UnityEngine.Vector3 Location { get; private set; }
    public float AcceptableRadius { get; private set; }

    public const int ID = -969953113;
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
        + "Location:" + Location + ","
        + "AcceptableRadius:" + AcceptableRadius + ","
        + "}";
    }
    }

}
