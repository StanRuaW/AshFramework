
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

package cfg.test;

import bright.serialization.*;


public final class TbTestJson2
{
    private final java.util.HashMap<Integer, cfg.test.TestJson2> _dataMap;
    private final java.util.ArrayList<cfg.test.TestJson2> _dataList;
    
    public TbTestJson2(ByteBuf _buf)
    {
        _dataMap = new java.util.HashMap<Integer, cfg.test.TestJson2>();
        _dataList = new java.util.ArrayList<cfg.test.TestJson2>();
        
        for(int n = _buf.readSize() ; n > 0 ; --n)
        {
            cfg.test.TestJson2 _v;
            _v = cfg.test.TestJson2.deserializeTestJson2(_buf);
            _dataList.add(_v);
            _dataMap.put(_v.id, _v);
        }
    }

    public java.util.HashMap<Integer, cfg.test.TestJson2> getDataMap() { return _dataMap; }
    public java.util.ArrayList<cfg.test.TestJson2> getDataList() { return _dataList; }

    public cfg.test.TestJson2 get(int key) { return _dataMap.get(key); }

    public void resolve(java.util.HashMap<String, Object> _tables)
    {
        for(cfg.test.TestJson2 v : _dataList)
        {
            v.resolve(_tables);
        }
    }

}
