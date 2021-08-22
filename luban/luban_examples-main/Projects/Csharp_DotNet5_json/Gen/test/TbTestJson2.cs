
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Bright.Serialization;
using System.Collections.Generic;
using System.Text.Json;



namespace cfg.test
{

public sealed partial class TbTestJson2
{
    private readonly Dictionary<int, test.TestJson2> _dataMap;
    private readonly List<test.TestJson2> _dataList;
    
    public TbTestJson2(JsonElement _json)
    {
        _dataMap = new Dictionary<int, test.TestJson2>();
        _dataList = new List<test.TestJson2>();
        
        foreach(JsonElement _row in _json.EnumerateArray())
        {
            var _v = test.TestJson2.DeserializeTestJson2(_row);
            _dataList.Add(_v);
            _dataMap.Add(_v.Id, _v);
        }
    }

    public Dictionary<int, test.TestJson2> DataMap => _dataMap;
    public List<test.TestJson2> DataList => _dataList;

    public test.TestJson2 GetOrDefault(int key) => _dataMap.TryGetValue(key, out var v) ? v : null;
    public test.TestJson2 Get(int key) => _dataMap[key];
    public test.TestJson2 this[int key] => _dataMap[key];

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
