
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
package cfg

import "errors"

type Item_InteractionItem struct {
    Item_ItemExtra
    AttackNum *int32
    HoldingStaticMesh string
    HoldingStaticMeshMat string
}

func (Item_InteractionItem) GetTypeId() int {
    return 640937802
}

func NewItem_InteractionItem(_buf map[string]interface{}) (_v *Item_InteractionItem, err error) {
    _v = &Item_InteractionItem{}
    var _p *Item_ItemExtra
     if _p, err = NewItem_ItemExtra_Body(_buf) ; err != nil { return }
    _v.Item_ItemExtra = *_p
    { var _ok_ bool; var __json_attack_num__ interface{}; if __json_attack_num__, _ok_ = _buf["attack_num"]; !_ok_ || __json_attack_num__ == nil { return } else { var __x__ int32;  { var _ok_ bool; var _x_ float64; if _x_, _ok_ = __json_attack_num__.(float64); !_ok_ { err = errors.New("__x__ error"); return }; __x__ = int32(_x_) }; _v.AttackNum = &__x__ }}
    { var _ok_ bool; if _v.HoldingStaticMesh, _ok_ = _buf["holding_static_mesh"].(string); !_ok_ { err = errors.New("holding_static_mesh error"); return } }
    { var _ok_ bool; if _v.HoldingStaticMeshMat, _ok_ = _buf["holding_static_mesh_mat"].(string); !_ok_ { err = errors.New("holding_static_mesh_mat error"); return } }
    return
}

