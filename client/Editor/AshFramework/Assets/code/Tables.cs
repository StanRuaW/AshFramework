
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Bright.Serialization;


namespace cfg
{
   
public sealed class Tables
{
    public item.TbItem TbItem {get; }

    public Tables(System.Func<string, ByteBuf> loader)
    {
        var tables = new System.Collections.Generic.Dictionary<string, object>();
        TbItem = new item.TbItem(loader("item.TbItem")); 
        tables.Add("item.TbItem", TbItem);

        TbItem.Resolve(tables); 
    }
}

}

