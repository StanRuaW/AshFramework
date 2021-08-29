
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
using Plugin.Bright.Serialization;
using System.Collections.Generic;
using System;

namespace cfg.l10n
{
   
public sealed class TbPatchDemo
{
    private readonly Dictionary<int, l10n.PatchDemo> _dataMap;
    private readonly List<l10n.PatchDemo> _dataList;
    
    public TbPatchDemo(ByteBuf _buf)
    {
        _dataMap = new Dictionary<int, l10n.PatchDemo>();
        _dataList = new List<l10n.PatchDemo>();
        
        for(int n = _buf.ReadSize() ; n > 0 ; --n)
        {
            l10n.PatchDemo _v;
            _v = l10n.PatchDemo.DeserializePatchDemo(_buf);
            _dataList.Add(_v);
            _dataMap.Add(_v.Id, _v);
        }
    }

    public Dictionary<int, l10n.PatchDemo> DataMap => _dataMap;
    public List<l10n.PatchDemo> DataList => _dataList;

    public l10n.PatchDemo GetOrDefault(int key) => _dataMap.TryGetValue(key, out var v) ? v : null;
    public l10n.PatchDemo Get(int key) => _dataMap[key];
    public l10n.PatchDemo this[int key] => _dataMap[key];

    public void Resolve(Dictionary<string, object> _tables)
    {
        foreach(var v in _dataList)
        {
            v.Resolve(_tables);
        }
    }

    public void TranslateText(System.Func<string, string, string> translator)
    {
        foreach(var v in _dataList)
        {
            v.TranslateText(translator);
        }
    }

    public void ForeachCfg(Func<l10n.PatchDemo, bool> callback)
    {
        foreach(var v in _dataList)
        {
            if(!callback(v))
            {
                break;
            }
        }
    }

}

}