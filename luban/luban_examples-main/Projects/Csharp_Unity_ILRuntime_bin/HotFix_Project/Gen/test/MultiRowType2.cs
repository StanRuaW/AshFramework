
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Bright.Serialization;
using System.Collections.Generic;



namespace cfg.test
{

public sealed partial class MultiRowType2 :  Bright.Config.BeanBase 
{
    public MultiRowType2(ByteBuf _buf) 
    {
        Id = _buf.ReadInt();
        X = _buf.ReadInt();
        Y = _buf.ReadFloat();
    }

    public MultiRowType2(int id, int x, float y ) 
    {
        this.Id = id;
        this.X = x;
        this.Y = y;
    }

    public static MultiRowType2 DeserializeMultiRowType2(ByteBuf _buf)
    {
        return new test.MultiRowType2(_buf);
    }

    public readonly int Id;
    public readonly int X;
    public readonly float Y;

    public const int ID = 540474971;
    public override int GetTypeId() => ID;

    public  void Resolve(Dictionary<string, object> _tables)
    {
        OnResolveFinish(_tables);
    }

    partial void OnResolveFinish(Dictionary<string, object> _tables);

    public override string ToString()
    {
        return "{ "
        + "Id:" + Id + ","
        + "X:" + X + ","
        + "Y:" + Y + ","
        + "}";
    }
    }

}

