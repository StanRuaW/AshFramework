
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

public sealed partial class ContainsItem :  condition.RoleCondition 
{
    public ContainsItem(ByteBuf _buf)  : base(_buf) 
    {
        ItemId = _buf.ReadInt();
        Num = _buf.ReadInt();
        Reverse = _buf.ReadBool();
    }

    public static ContainsItem DeserializeContainsItem(ByteBuf _buf)
    {
        return new condition.ContainsItem(_buf);
    }

    public int ItemId { get; private set; }
    public item.Item ItemId_Ref { get; private set; }
    public int Num { get; private set; }
    public bool Reverse { get; private set; }

    public const int ID = 1961145317;
    public override int GetTypeId() => ID;

    public override void Resolve(Dictionary<string, object> _tables)
    {
        base.Resolve(_tables);
        this.ItemId_Ref = (_tables["item.TbItem"] as item.TbItem).GetOrDefault(ItemId);
    }

    public override void TranslateText(System.Func<string, string, string> translator)
    {
        base.TranslateText(translator);
    }

    public override string ToString()
    {
        return "{ "
        + "ItemId:" + ItemId + ","
        + "Num:" + Num + ","
        + "Reverse:" + Reverse + ","
        + "}";
    }
    }

}
