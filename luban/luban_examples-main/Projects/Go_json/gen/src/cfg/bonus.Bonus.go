
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
package cfg

import "errors"

type Bonus_Bonus struct {
}


func NewBonus_Bonus(_buf map[string]interface{}) (_v interface{}, err error) {
    var id string
    var _ok_ bool
    if id, _ok_ = _buf["__type__"].(string) ; !_ok_ {
        return nil, errors.New("type id missing")
    }
    switch id {
        case "OneItem": return NewBonus_OneItem(_buf);
        case "OneItems": return NewBonus_OneItems(_buf);
        case "Item": return NewBonus_Item(_buf);
        case "Items": return NewBonus_Items(_buf);
        case "CoefficientItem": return NewBonus_CoefficientItem(_buf);
        case "WeightItems": return NewBonus_WeightItems(_buf);
        case "ProbabilityItems": return NewBonus_ProbabilityItems(_buf);
        case "MultiBonus": return NewBonus_MultiBonus(_buf);
        case "ProbabilityBonus": return NewBonus_ProbabilityBonus(_buf);
        case "WeightBonus": return NewBonus_WeightBonus(_buf);
        case "DropBonus": return NewBonus_DropBonus(_buf);
        default: return nil, errors.New("unknown type id")
    }
    return
}

func NewBonus_Bonus_Body(_buf map[string]interface{}) (_v *Bonus_Bonus, err error) {
    _v = &Bonus_Bonus{}
    return
}

