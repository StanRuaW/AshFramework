
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Bright.Serialization;
using System.Collections.Generic;



namespace cfg.bonus
{

public sealed partial class ProbabilityItems :  bonus.Bonus 
{
    public ProbabilityItems(ByteBuf _buf)  : base(_buf) 
    {
        {int n = System.Math.Min(_buf.ReadSize(), _buf.Size);ItemList = new bonus.ProbabilityItemInfo[n];for(var i = 0 ; i < n ; i++) { bonus.ProbabilityItemInfo _e;_e = bonus.ProbabilityItemInfo.DeserializeProbabilityItemInfo(_buf); ItemList[i] = _e;}}
    }

    public ProbabilityItems(bonus.ProbabilityItemInfo[] item_list )  : base() 
    {
        this.ItemList = item_list;
    }

    public static ProbabilityItems DeserializeProbabilityItems(ByteBuf _buf)
    {
        return new bonus.ProbabilityItems(_buf);
    }

    public readonly bonus.ProbabilityItemInfo[] ItemList;

    public const int ID = 366387866;
    public override int GetTypeId() => ID;

    public override void Resolve(Dictionary<string, object> _tables)
    {
        base.Resolve(_tables);
        foreach(var _e in ItemList) { _e?.Resolve(_tables); }
        OnResolveFinish(_tables);
    }

    partial void OnResolveFinish(Dictionary<string, object> _tables);

    public override string ToString()
    {
        return "{ "
        + "ItemList:" + Bright.Common.StringUtil.CollectionToString(ItemList) + ","
        + "}";
    }
    }

}

