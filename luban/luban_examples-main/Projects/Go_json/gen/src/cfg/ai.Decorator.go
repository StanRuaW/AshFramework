
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
package cfg

import "errors"

type Ai_Decorator struct {
    Ai_Node
    FlowAbortMode int32
}


func NewAi_Decorator(_buf map[string]interface{}) (_v interface{}, err error) {
    var id string
    var _ok_ bool
    if id, _ok_ = _buf["__type__"].(string) ; !_ok_ {
        return nil, errors.New("type id missing")
    }
    switch id {
        case "UeLoop": return NewAi_UeLoop(_buf);
        case "UeCooldown": return NewAi_UeCooldown(_buf);
        case "UeTimeLimit": return NewAi_UeTimeLimit(_buf);
        case "UeBlackboard": return NewAi_UeBlackboard(_buf);
        case "UeForceSuccess": return NewAi_UeForceSuccess(_buf);
        case "IsAtLocation": return NewAi_IsAtLocation(_buf);
        case "DistanceLessThan": return NewAi_DistanceLessThan(_buf);
        default: return nil, errors.New("unknown type id")
    }
    return
}

func NewAi_Decorator_Body(_buf map[string]interface{}) (_v *Ai_Decorator, err error) {
    _v = &Ai_Decorator{}
    var _p *Ai_Node
     if _p, err = NewAi_Node_Body(_buf) ; err != nil { return }
    _v.Ai_Node = *_p
    { var _ok_ bool; var _tempNum_ float64; if _tempNum_, _ok_ = _buf["flow_abort_mode"].(float64); !_ok_ { err = errors.New("flow_abort_mode error"); return }; _v.FlowAbortMode = int32(_tempNum_) }
    return
}

