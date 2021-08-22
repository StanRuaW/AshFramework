
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
package cfg

import "errors"

type Ai_UeLoop struct {
    Ai_Decorator
    NumLoops int32
    InfiniteLoop bool
    InfiniteLoopTimeoutTime float32
}

func (Ai_UeLoop) GetTypeId() int {
    return -513308166
}

func NewAi_UeLoop(_buf map[string]interface{}) (_v *Ai_UeLoop, err error) {
    _v = &Ai_UeLoop{}
    var _p *Ai_Decorator
     if _p, err = NewAi_Decorator_Body(_buf) ; err != nil { return }
    _v.Ai_Decorator = *_p
    { var _ok_ bool; var _tempNum_ float64; if _tempNum_, _ok_ = _buf["num_loops"].(float64); !_ok_ { err = errors.New("num_loops error"); return }; _v.NumLoops = int32(_tempNum_) }
    { var _ok_ bool; if _v.InfiniteLoop, _ok_ = _buf["infinite_loop"].(bool); !_ok_ { err = errors.New("infinite_loop error"); return } }
    { var _ok_ bool; var _tempNum_ float64; if _tempNum_, _ok_ = _buf["infinite_loop_timeout_time"].(float64); !_ok_ { err = errors.New("infinite_loop_timeout_time error"); return }; _v.InfiniteLoopTimeoutTime = float32(_tempNum_) }
    return
}

