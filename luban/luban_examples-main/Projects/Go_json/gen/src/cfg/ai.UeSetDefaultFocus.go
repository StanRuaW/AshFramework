
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
package cfg

import "errors"

type Ai_UeSetDefaultFocus struct {
    Ai_Service
    KeyboardKey string
}

func (Ai_UeSetDefaultFocus) GetTypeId() int {
    return 1812449155
}

func NewAi_UeSetDefaultFocus(_buf map[string]interface{}) (_v *Ai_UeSetDefaultFocus, err error) {
    _v = &Ai_UeSetDefaultFocus{}
    var _p *Ai_Service
     if _p, err = NewAi_Service_Body(_buf) ; err != nil { return }
    _v.Ai_Service = *_p
    { var _ok_ bool; if _v.KeyboardKey, _ok_ = _buf["keyboard_key"].(string); !_ok_ { err = errors.New("keyboard_key error"); return } }
    return
}

