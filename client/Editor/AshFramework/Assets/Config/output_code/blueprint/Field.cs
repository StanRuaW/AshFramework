
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
using Plugin.Bright.Serialization;
using System.Collections.Generic;



namespace cfg.blueprint
{

public sealed partial class Field :  Plugin.Bright.Config.BeanBase 
{
    public Field(ByteBuf _buf) 
    {
        Name = _buf.ReadString();
        Type = _buf.ReadString();
        Desc = _buf.ReadString();
    }

    public static Field DeserializeField(ByteBuf _buf)
    {
        return new blueprint.Field(_buf);
    }

    public string Name { get; private set; }
    public string Type { get; private set; }
    public string Desc { get; private set; }

    public const int ID = 1694158271;
    public override int GetTypeId() => ID;

    public  void Resolve(Dictionary<string, object> _tables)
    {
    }

    public  void TranslateText(System.Func<string, string, string> translator)
    {
    }

    public override string ToString()
    {
        return "{ "
        + "Name:" + Name + ","
        + "Type:" + Type + ","
        + "Desc:" + Desc + ","
        + "}";
    }
    }

}
