
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
package cfg

type Test_TbMultiRowTitle struct {
    _dataMap map[int32]*Test_MultiRowTitle
    _dataList []*Test_MultiRowTitle
}

func NewTest_TbMultiRowTitle(_buf []map[string]interface{}) (*Test_TbMultiRowTitle, error) {
	_dataList := make([]*Test_MultiRowTitle, 0, len(_buf))
	dataMap := make(map[int32]*Test_MultiRowTitle)
	for _, _ele_ := range _buf {
		if _v, err2 := NewTest_MultiRowTitle(_ele_); err2 != nil {
			return nil, err2
		} else {
			_dataList = append(_dataList, _v)
			dataMap[_v.Id] = _v
		}
	}
	return &Test_TbMultiRowTitle{_dataList:_dataList, _dataMap:dataMap}, nil
}

func (table *Test_TbMultiRowTitle) GetDataMap() map[int32]*Test_MultiRowTitle {
    return table._dataMap
}

func (table *Test_TbMultiRowTitle) GetDataList() []*Test_MultiRowTitle {
    return table._dataList
}

func (table *Test_TbMultiRowTitle) Get(key int32) *Test_MultiRowTitle {
    return table._dataMap[key]
}


