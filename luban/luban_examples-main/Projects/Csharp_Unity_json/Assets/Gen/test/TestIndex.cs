
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Bright.Serialization;
using System.Collections.Generic;
using SimpleJSON;



namespace cfg.test
{

public sealed partial class TestIndex :  Bright.Config.BeanBase 
{
    public TestIndex(JSONNode _json) 
    {
        { if(!_json["id"].IsNumber) { throw new SerializationException(); }  Id = _json["id"]; }
        { var _json1 = _json["eles"]; if(!_json1.IsArray) { throw new SerializationException(); } Eles = new System.Collections.Generic.List<test.DemoType1>(_json1.Count); foreach(JSONNode __e in _json1.Children) { test.DemoType1 __v;  { if(!__e.IsObject) { throw new SerializationException(); }  __v = test.DemoType1.DeserializeDemoType1(__e); }  Eles.Add(__v); }   }
        foreach(var _v in Eles) { Eles_Index.Add(_v.X1, _v); }
    }

    public TestIndex(int id, System.Collections.Generic.List<test.DemoType1> eles ) 
    {
        this.Id = id;
        this.Eles = eles;
        foreach(var _v in Eles) { Eles_Index.Add(_v.X1, _v); }
    }

    public static TestIndex DeserializeTestIndex(JSONNode _json)
    {
        return new test.TestIndex(_json);
    }

    public readonly int Id;
    public readonly System.Collections.Generic.List<test.DemoType1> Eles;
    public readonly Dictionary<int, test.DemoType1> Eles_Index = new Dictionary<int, test.DemoType1>();

    public const int ID = 1941154020;
    public override int GetTypeId() => ID;

    public  void Resolve(Dictionary<string, object> _tables)
    {
        foreach(var _e in Eles) { _e?.Resolve(_tables); }
        OnResolveFinish(_tables);
    }

    partial void OnResolveFinish(Dictionary<string, object> _tables);

    public override string ToString()
    {
        return "{ "
        + "Id:" + Id + ","
        + "Eles:" + Bright.Common.StringUtil.CollectionToString(Eles) + ","
        + "}";
    }
    }
}

