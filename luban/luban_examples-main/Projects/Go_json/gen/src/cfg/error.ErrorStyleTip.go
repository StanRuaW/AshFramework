
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
package cfg



type Error_ErrorStyleTip struct {
    Error_ErrorStyle
}

func (Error_ErrorStyleTip) GetTypeId() int {
    return 1915239884
}

func NewError_ErrorStyleTip(_buf map[string]interface{}) (_v *Error_ErrorStyleTip, err error) {
    _v = &Error_ErrorStyleTip{}
    var _p *Error_ErrorStyle
     if _p, err = NewError_ErrorStyle_Body(_buf) ; err != nil { return }
    _v.Error_ErrorStyle = *_p
    return
}

