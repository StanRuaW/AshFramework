
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
package cfg

type Mail_TbSystemMail struct {
    _dataMap map[int32]*Mail_SystemMail
    _dataList []*Mail_SystemMail
}

func NewMail_TbSystemMail(_buf []map[string]interface{}) (*Mail_TbSystemMail, error) {
	_dataList := make([]*Mail_SystemMail, 0, len(_buf))
	dataMap := make(map[int32]*Mail_SystemMail)
	for _, _ele_ := range _buf {
		if _v, err2 := NewMail_SystemMail(_ele_); err2 != nil {
			return nil, err2
		} else {
			_dataList = append(_dataList, _v)
			dataMap[_v.Id] = _v
		}
	}
	return &Mail_TbSystemMail{_dataList:_dataList, _dataMap:dataMap}, nil
}

func (table *Mail_TbSystemMail) GetDataMap() map[int32]*Mail_SystemMail {
    return table._dataMap
}

func (table *Mail_TbSystemMail) GetDataList() []*Mail_SystemMail {
    return table._dataList
}

func (table *Mail_TbSystemMail) Get(key int32) *Mail_SystemMail {
    return table._dataMap[key]
}


