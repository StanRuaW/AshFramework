
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



namespace cfg.cost
{

public sealed partial class CostCurrencies :  cost.Cost 
{
    public CostCurrencies(JsonElement _json)  : base(_json) 
    {
        { var _json0 = _json.GetProperty("currencies"); Currencies = new System.Collections.Generic.List<cost.CostCurrency>(_json0.GetArrayLength()); foreach(JsonElement __e in _json0.EnumerateArray()) { cost.CostCurrency __v;  __v =  cost.CostCurrency.DeserializeCostCurrency(__e);  Currencies.Add(__v); }   }
    }

    public CostCurrencies(System.Collections.Generic.List<cost.CostCurrency> currencies )  : base() 
    {
        this.Currencies = currencies;
    }

    public static CostCurrencies DeserializeCostCurrencies(JsonElement _json)
    {
        return new cost.CostCurrencies(_json);
    }

    public readonly System.Collections.Generic.List<cost.CostCurrency> Currencies;

    public const int ID = 103084157;
    public override int GetTypeId() => ID;

    public override void Resolve(Dictionary<string, object> _tables)
    {
        base.Resolve(_tables);
        foreach(var _e in Currencies) { _e?.Resolve(_tables); }
        OnResolveFinish(_tables);
    }

    partial void OnResolveFinish(Dictionary<string, object> _tables);

    public override string ToString()
    {
        return "{ "
        + "Currencies:" + Bright.Common.StringUtil.CollectionToString(Currencies) + ","
        + "}";
    }
    }
}

