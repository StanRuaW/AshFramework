
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
package cfg

import "errors"

type Test_TestGlobal struct {
    UnlockEquip int32
    UnlockHero int32
}

func (Test_TestGlobal) GetTypeId() int {
    return -12548655
}

func NewTest_TestGlobal(_buf map[string]interface{}) (_v *Test_TestGlobal, err error) {
    _v = &Test_TestGlobal{}
    { var _ok_ bool; var _tempNum_ float64; if _tempNum_, _ok_ = _buf["unlock_equip"].(float64); !_ok_ { err = errors.New("unlock_equip error"); return }; _v.UnlockEquip = int32(_tempNum_) }
    { var _ok_ bool; var _tempNum_ float64; if _tempNum_, _ok_ = _buf["unlock_hero"].(float64); !_ok_ { err = errors.New("unlock_hero error"); return }; _v.UnlockHero = int32(_tempNum_) }
    return
}

