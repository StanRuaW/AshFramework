
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



type Test_TestExcelBean1 struct {
    X1 int32
    X2 string
    X3 int32
    X4 float32
}

func (Test_TestExcelBean1) GetTypeId() int {
    return -1738345160
}

func NewTest_TestExcelBean1(_buf *serialization.ByteBuf) (_v *Test_TestExcelBean1, err error) {
    _v = &Test_TestExcelBean1{}
    { if _v.X1, err = _buf.ReadInt(); err != nil { return } }
    { if _v.X2, err = _buf.ReadString(); err != nil { return } }
    { if _v.X3, err = _buf.ReadInt(); err != nil { return } }
    { if _v.X4, err = _buf.ReadFloat(); err != nil { return } }
    return
}

