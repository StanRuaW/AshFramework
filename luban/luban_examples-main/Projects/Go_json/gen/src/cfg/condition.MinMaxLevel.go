
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
package cfg

import "errors"

type Condition_MinMaxLevel struct {
    Condition_BoolRoleCondition
    Min int32
    Max int32
}

func (Condition_MinMaxLevel) GetTypeId() int {
    return 907499647
}

func NewCondition_MinMaxLevel(_buf map[string]interface{}) (_v *Condition_MinMaxLevel, err error) {
    _v = &Condition_MinMaxLevel{}
    var _p *Condition_BoolRoleCondition
     if _p, err = NewCondition_BoolRoleCondition_Body(_buf) ; err != nil { return }
    _v.Condition_BoolRoleCondition = *_p
    { var _ok_ bool; var _tempNum_ float64; if _tempNum_, _ok_ = _buf["min"].(float64); !_ok_ { err = errors.New("min error"); return }; _v.Min = int32(_tempNum_) }
    { var _ok_ bool; var _tempNum_ float64; if _tempNum_, _ok_ = _buf["max"].(float64); !_ok_ { err = errors.New("max error"); return }; _v.Max = int32(_tempNum_) }
    return
}

