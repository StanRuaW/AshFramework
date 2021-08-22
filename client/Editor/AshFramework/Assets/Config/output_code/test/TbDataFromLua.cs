
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Bright.Serialization;
using System.Collections.Generic;
using System;

namespace cfg.test
{
   
public sealed partial class TbDataFromLua
{
    private readonly Dictionary<int, test.DemoType2> _dataMap;
    private readonly List<test.DemoType2> _dataList;
    
    public TbDataFromLua(ByteBuf _buf)
    {
        _dataMap = new Dictionary<int, test.DemoType2>();
        _dataList = new List<test.DemoType2>();
        
        for(int n = _buf.ReadSize() ; n > 0 ; --n)
        {
            test.DemoType2 _v;
            _v = test.DemoType2.DeserializeDemoType2(_buf);
            _dataList.Add(_v);
            _dataMap.Add(_v.X4, _v);
        }
    }

    public Dictionary<int, test.DemoType2> DataMap => _dataMap;
    public List<test.DemoType2> DataList => _dataList;

    public test.DemoType2 GetOrDefault(int key) => _dataMap.TryGetValue(key, out var v) ? v : null;
    public test.DemoType2 Get(int key) => _dataMap[key];
    public test.DemoType2 this[int key] => _dataMap[key];

    public void ForeachCfg(Func<test.DemoType2, bool> callback)
    {
        foreach(var v in _dataList)
        {
            if(!callback(v))
            {
                break;
            }
        }
    }

    public void Resolve(Dictionary<string, object> _tables)
    {
        foreach(var v in _dataList)
        {
            v.Resolve(_tables);
        }
        OnResolveFinish(_tables);
    }


    partial void OnResolveFinish(Dictionary<string, object> _tables);
}

}
