
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
package cfg

import (
    "bright/serialization"
)



type Cost_CostOneItem struct {
    Cost_Cost
    ItemId int32
}

func (Cost_CostOneItem) GetTypeId() int {
    return -1033587381
}

func NewCost_CostOneItem(_buf *serialization.ByteBuf) (_v *Cost_CostOneItem, err error) {
    _v = &Cost_CostOneItem{}
    var _p *Cost_Cost
     if _p, err = NewCost_Cost_Body(_buf) ; err != nil { return }
    _v.Cost_Cost = *_p
    { if _v.ItemId, err = _buf.ReadInt(); err != nil { return } }
    return
}

