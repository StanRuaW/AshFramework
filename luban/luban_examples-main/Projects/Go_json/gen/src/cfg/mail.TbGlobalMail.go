
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
package cfg

type Mail_TbGlobalMail struct {
    _dataMap map[int32]*Mail_GlobalMail
    _dataList []*Mail_GlobalMail
}

func NewMail_TbGlobalMail(_buf []map[string]interface{}) (*Mail_TbGlobalMail, error) {
	_dataList := make([]*Mail_GlobalMail, 0, len(_buf))
	dataMap := make(map[int32]*Mail_GlobalMail)
	for _, _ele_ := range _buf {
		if _v, err2 := NewMail_GlobalMail(_ele_); err2 != nil {
			return nil, err2
		} else {
			_dataList = append(_dataList, _v)
			dataMap[_v.Id] = _v
		}
	}
	return &Mail_TbGlobalMail{_dataList:_dataList, _dataMap:dataMap}, nil
}

func (table *Mail_TbGlobalMail) GetDataMap() map[int32]*Mail_GlobalMail {
    return table._dataMap
}

func (table *Mail_TbGlobalMail) GetDataList() []*Mail_GlobalMail {
    return table._dataList
}

func (table *Mail_TbGlobalMail) Get(key int32) *Mail_GlobalMail {
    return table._dataMap[key]
}


