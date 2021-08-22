
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Bright.Serialization;
using System.Collections.Generic;

namespace cfg.role
{
   
public sealed partial class TbRoleLevelExpAttr
{
    private readonly Dictionary<int, role.LevelExpAttr> _dataMap;
    private readonly List<role.LevelExpAttr> _dataList;
    
    public TbRoleLevelExpAttr(ByteBuf _buf)
    {
        _dataMap = new Dictionary<int, role.LevelExpAttr>();
        _dataList = new List<role.LevelExpAttr>();
        
        for(int n = _buf.ReadSize() ; n > 0 ; --n)
        {
            role.LevelExpAttr _v;
            _v = role.LevelExpAttr.DeserializeLevelExpAttr(_buf);
            _dataList.Add(_v);
            _dataMap.Add(_v.Level, _v);
        }
    }

    public Dictionary<int, role.LevelExpAttr> DataMap => _dataMap;
    public List<role.LevelExpAttr> DataList => _dataList;

    public role.LevelExpAttr GetOrDefault(int key) => _dataMap.TryGetValue(key, out var v) ? v : null;
    public role.LevelExpAttr Get(int key) => _dataMap[key];
    public role.LevelExpAttr this[int key] => _dataMap[key];

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
