
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Bright.Serialization;
using System.Collections.Generic;



namespace cfg.item
{

public sealed partial class Item :  Bright.Config.BeanBase 
{
    public Item(ByteBuf _buf) 
    {
        Id = _buf.ReadInt();
        Name = _buf.ReadString();
        Desc = _buf.ReadString();
        Price = _buf.ReadInt();
    }

    public Item(int id, string name, string desc, int price ) 
    {
        this.Id = id;
        this.Name = name;
        this.Desc = desc;
        this.Price = price;
    }

    public static Item DeserializeItem(ByteBuf _buf)
    {
        return new item.Item(_buf);
    }

    public readonly int Id;
    public readonly string Name;
    public readonly string Desc;
    public readonly int Price;

    public const int ID = 2107285806;
    public override int GetTypeId() => ID;

    public  void Resolve(Dictionary<string, object> _tables)
    {
        OnResolveFinish(_tables);
    }

    partial void OnResolveFinish(Dictionary<string, object> _tables);

    public override string ToString()
    {
        return "{ "
        + "Id:" + Id + ","
        + "Name:" + Name + ","
        + "Desc:" + Desc + ","
        + "Price:" + Price + ","
        + "}";
    }
    }

}

