
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
using Plugin.Bright.Serialization;
using System.Collections.Generic;



namespace cfg.bonus
{

public sealed partial class ShowItemInfo :  Plugin.Bright.Config.BeanBase 
{
    public ShowItemInfo(ByteBuf _buf) 
    {
        ItemId = _buf.ReadInt();
        ItemNum = _buf.ReadLong();
    }

    public static ShowItemInfo DeserializeShowItemInfo(ByteBuf _buf)
    {
        return new bonus.ShowItemInfo(_buf);
    }

    public int ItemId { get; private set; }
    public item.Item ItemId_Ref { get; private set; }
    public long ItemNum { get; private set; }

    public const int ID = -1496363507;
    public override int GetTypeId() => ID;

    public  void Resolve(Dictionary<string, object> _tables)
    {
        this.ItemId_Ref = (_tables["item.TbItem"] as item.TbItem).GetOrDefault(ItemId);
    }

    public  void TranslateText(System.Func<string, string, string> translator)
    {
    }

    public override string ToString()
    {
        return "{ "
        + "ItemId:" + ItemId + ","
        + "ItemNum:" + ItemNum + ","
        + "}";
    }
    }

}
