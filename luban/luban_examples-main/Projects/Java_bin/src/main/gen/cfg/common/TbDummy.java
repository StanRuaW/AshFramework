
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

package cfg.common;

import bright.serialization.*;


public final class TbDummy
{
    private final java.util.HashMap<Integer, cfg.common.Dummy> _dataMap;
    private final java.util.ArrayList<cfg.common.Dummy> _dataList;
    
    public TbDummy(ByteBuf _buf)
    {
        _dataMap = new java.util.HashMap<Integer, cfg.common.Dummy>();
        _dataList = new java.util.ArrayList<cfg.common.Dummy>();
        
        for(int n = _buf.readSize() ; n > 0 ; --n)
        {
            cfg.common.Dummy _v;
            _v = cfg.common.Dummy.deserializeDummy(_buf);
            _dataList.add(_v);
            _dataMap.put(_v.id, _v);
        }
    }

    public java.util.HashMap<Integer, cfg.common.Dummy> getDataMap() { return _dataMap; }
    public java.util.ArrayList<cfg.common.Dummy> getDataList() { return _dataList; }

    public cfg.common.Dummy get(int key) { return _dataMap.get(key); }

    public void resolve(java.util.HashMap<String, Object> _tables)
    {
        for(cfg.common.Dummy v : _dataList)
        {
            v.resolve(_tables);
        }
    }

}
