
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
package cfg

import "errors"

type Test_TestIndex struct {
    Id int32
    Eles []*Test_DemoType1
}

func (Test_TestIndex) GetTypeId() int {
    return 1941154020
}

func NewTest_TestIndex(_buf map[string]interface{}) (_v *Test_TestIndex, err error) {
    _v = &Test_TestIndex{}
    { var _ok_ bool; var _tempNum_ float64; if _tempNum_, _ok_ = _buf["id"].(float64); !_ok_ { err = errors.New("id error"); return }; _v.Id = int32(_tempNum_) }
     {
                var _arr_ []interface{}
                var _ok_ bool
                if _arr_, _ok_ = _buf["eles"].([]interface{}); !_ok_ { err = errors.New("eles error"); return }

                _v.Eles = make([]*Test_DemoType1, 0, len(_arr_))
                
                for _, _e_ := range _arr_ {
                    var _list_v_ *Test_DemoType1
                    { var _ok_ bool; var _x_ map[string]interface{}; if _x_, _ok_ = _e_.(map[string]interface{}); !_ok_ { err = errors.New("_list_v_ error"); return }; if _list_v_, err = NewTest_DemoType1(_x_); err != nil { return } }
                    _v.Eles = append(_v.Eles, _list_v_)
                }
            }

    return
}

