
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
package cfg

type Ai_TbBlackboard struct {
    _dataMap map[string]*Ai_Blackboard
    _dataList []*Ai_Blackboard
}

func NewAi_TbBlackboard(_buf []map[string]interface{}) (*Ai_TbBlackboard, error) {
	_dataList := make([]*Ai_Blackboard, 0, len(_buf))
	dataMap := make(map[string]*Ai_Blackboard)
	for _, _ele_ := range _buf {
		if _v, err2 := NewAi_Blackboard(_ele_); err2 != nil {
			return nil, err2
		} else {
			_dataList = append(_dataList, _v)
			dataMap[_v.Name] = _v
		}
	}
	return &Ai_TbBlackboard{_dataList:_dataList, _dataMap:dataMap}, nil
}

func (table *Ai_TbBlackboard) GetDataMap() map[string]*Ai_Blackboard {
    return table._dataMap
}

func (table *Ai_TbBlackboard) GetDataList() []*Ai_Blackboard {
    return table._dataList
}

func (table *Ai_TbBlackboard) Get(key string) *Ai_Blackboard {
    return table._dataMap[key]
}


