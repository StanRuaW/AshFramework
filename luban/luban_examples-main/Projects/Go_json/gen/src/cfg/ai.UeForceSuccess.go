
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
package cfg



type Ai_UeForceSuccess struct {
    Ai_Decorator
}

func (Ai_UeForceSuccess) GetTypeId() int {
    return 195054574
}

func NewAi_UeForceSuccess(_buf map[string]interface{}) (_v *Ai_UeForceSuccess, err error) {
    _v = &Ai_UeForceSuccess{}
    var _p *Ai_Decorator
     if _p, err = NewAi_Decorator_Body(_buf) ; err != nil { return }
    _v.Ai_Decorator = *_p
    return
}

