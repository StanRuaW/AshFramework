
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

package cfg.condition;

import bright.serialization.*;



public abstract class Condition extends  bright.serialization.AbstractBean 
{
    public Condition(ByteBuf _buf)
    { 
    }

    public Condition()
    {
    }

    public static Condition deserializeCondition(ByteBuf _buf)
    {
        switch (_buf.readInt())
        {
            case cfg.condition.TimeRange.ID: return new cfg.condition.TimeRange(_buf);
            case cfg.condition.MultiRoleCondition.ID: return new cfg.condition.MultiRoleCondition(_buf);
            case cfg.condition.GenderLimit.ID: return new cfg.condition.GenderLimit(_buf);
            case cfg.condition.MinLevel.ID: return new cfg.condition.MinLevel(_buf);
            case cfg.condition.MaxLevel.ID: return new cfg.condition.MaxLevel(_buf);
            case cfg.condition.MinMaxLevel.ID: return new cfg.condition.MinMaxLevel(_buf);
            case cfg.condition.ClothesPropertyScoreGreaterThan.ID: return new cfg.condition.ClothesPropertyScoreGreaterThan(_buf);
            case cfg.condition.ContainsItem.ID: return new cfg.condition.ContainsItem(_buf);
            default: throw new SerializationException();
        }
    }



    @Override
    public void serialize(ByteBuf os)
    {
        throw new UnsupportedOperationException();
    }

    @Override
    public void deserialize(ByteBuf os)
    {
        throw new UnsupportedOperationException();
    }

    public void resolve(java.util.HashMap<String, Object> _tables)
    {
    }

    @Override
    public String toString()
    {
        return "{ "
        + "}";
    }
}

