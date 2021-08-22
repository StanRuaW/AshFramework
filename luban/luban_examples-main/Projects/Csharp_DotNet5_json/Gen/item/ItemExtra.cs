
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



namespace cfg.item
{

public abstract partial class ItemExtra :  Bright.Config.BeanBase 
{
    public ItemExtra(JsonElement _json) 
    {
        Id = _json.GetProperty("id").GetInt32();
    }

    public ItemExtra(int id ) 
    {
        this.Id = id;
    }

    public static ItemExtra DeserializeItemExtra(JsonElement _json)
    {
        switch (_json.GetProperty("__type__").GetString())
        {
            case "TreasureBox": return new item.TreasureBox(_json);
            case "InteractionItem": return new item.InteractionItem(_json);
            case "Clothes": return new item.Clothes(_json);
            case "DesignDrawing": return new item.DesignDrawing(_json);
            case "Dymmy": return new item.Dymmy(_json);
            default: throw new SerializationException();
        }
    }

    public readonly int Id;


    public virtual void Resolve(Dictionary<string, object> _tables)
    {
        OnResolveFinish(_tables);
    }

    partial void OnResolveFinish(Dictionary<string, object> _tables);

    public override string ToString()
    {
        return "{ "
        + "Id:" + Id + ","
        + "}";
    }
    }
}

