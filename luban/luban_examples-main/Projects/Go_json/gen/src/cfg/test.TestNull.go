
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
package cfg

import "errors"

type Test_TestNull struct {
    Id int32
    X1 *int32
    X2 *int32
    X3 *Test_DemoType1
    X4 interface{}
    S1 *string
    S2 *string
}

func (Test_TestNull) GetTypeId() int {
    return 339868469
}

func NewTest_TestNull(_buf map[string]interface{}) (_v *Test_TestNull, err error) {
    _v = &Test_TestNull{}
    { var _ok_ bool; var _tempNum_ float64; if _tempNum_, _ok_ = _buf["id"].(float64); !_ok_ { err = errors.New("id error"); return }; _v.Id = int32(_tempNum_) }
    { var _ok_ bool; var __json_x1__ interface{}; if __json_x1__, _ok_ = _buf["x1"]; !_ok_ || __json_x1__ == nil { return } else { var __x__ int32;  { var _ok_ bool; var _x_ float64; if _x_, _ok_ = __json_x1__.(float64); !_ok_ { err = errors.New("__x__ error"); return }; __x__ = int32(_x_) }; _v.X1 = &__x__ }}
    { var _ok_ bool; var __json_x2__ interface{}; if __json_x2__, _ok_ = _buf["x2"]; !_ok_ || __json_x2__ == nil { return } else { var __x__ int32;  { var _ok_ bool; var _x_ float64; if _x_, _ok_ = __json_x2__.(float64); !_ok_ { err = errors.New("__x__ error"); return }; __x__ = int32(_x_) }; _v.X2 = &__x__ }}
    { var _ok_ bool; var __json_x3__ interface{}; if __json_x3__, _ok_ = _buf["x3"]; !_ok_ || __json_x3__ == nil { return } else { var __x__ *Test_DemoType1;  { var _ok_ bool; var _x_ map[string]interface{}; if _x_, _ok_ = __json_x3__.(map[string]interface{}); !_ok_ { err = errors.New("__x__ error"); return }; if __x__, err = NewTest_DemoType1(_x_); err != nil { return } }; _v.X3 = __x__ }}
    { var _ok_ bool; var __json_x4__ interface{}; if __json_x4__, _ok_ = _buf["x4"]; !_ok_ || __json_x4__ == nil { return } else { var __x__ interface{};  { var _ok_ bool; var _x_ map[string]interface{}; if _x_, _ok_ = __json_x4__.(map[string]interface{}); !_ok_ { err = errors.New("__x__ error"); return }; if __x__, err = NewTest_DemoDynamic(_x_); err != nil { return } }; _v.X4 = __x__ }}
    { var _ok_ bool; var __json_s1__ interface{}; if __json_s1__, _ok_ = _buf["s1"]; !_ok_ || __json_s1__ == nil { return } else { var __x__ string;  {  if __x__, _ok_ = __json_s1__.(string); !_ok_ { err = errors.New("__x__ error"); return } }; _v.S1 = &__x__ }}
    { var _ok_ bool; var __json_s2__ interface{}; if __json_s2__, _ok_ = _buf["s2"]; !_ok_ || __json_s2__ == nil { return } else { var __x__ string;  {  if __x__, _ok_ = __json_s2__.(string); !_ok_ { err = errors.New("__x__ error"); return } }; _v.S2 = &__x__ }}
    return
}

