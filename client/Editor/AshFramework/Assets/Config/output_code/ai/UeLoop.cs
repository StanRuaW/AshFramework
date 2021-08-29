
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

public sealed partial class UeLoop :  ai.Decorator 
{
    public UeLoop(ByteBuf _buf)  : base(_buf) 
    {
        NumLoops = _buf.ReadInt();
        InfiniteLoop = _buf.ReadBool();
        InfiniteLoopTimeoutTime = _buf.ReadFloat();
    }

    public static UeLoop DeserializeUeLoop(ByteBuf _buf)
    {
        return new ai.UeLoop(_buf);
    }

    public int NumLoops { get; private set; }
    public bool InfiniteLoop { get; private set; }
    public float InfiniteLoopTimeoutTime { get; private set; }

    public const int ID = -513308166;
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
        + "FlowAbortMode:" + FlowAbortMode + ","
        + "NumLoops:" + NumLoops + ","
        + "InfiniteLoop:" + InfiniteLoop + ","
        + "InfiniteLoopTimeoutTime:" + InfiniteLoopTimeoutTime + ","
        + "}";
    }
    }

}