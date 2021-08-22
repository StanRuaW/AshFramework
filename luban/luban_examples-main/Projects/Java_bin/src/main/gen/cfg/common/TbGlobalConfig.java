
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

package cfg.common;

import bright.serialization.*;


public final class TbGlobalConfig
{
    private final cfg.common.GlobalConfig _data;

    public final cfg.common.GlobalConfig data() { return _data; }

    public TbGlobalConfig(ByteBuf _buf)
    {
        int n = _buf.readSize();
        if (n != 1) throw new SerializationException("table mode=one, but size != 1");
        _data = cfg.common.GlobalConfig.deserializeGlobalConfig(_buf);
    }


    /**
     * 背包容量
     */
     public int getBagCapacity() { return _data.bagCapacity; }
     public int getBagCapacitySpecial() { return _data.bagCapacitySpecial; }
     public int getBagTempExpendableCapacity() { return _data.bagTempExpendableCapacity; }
     public int getBagTempToolCapacity() { return _data.bagTempToolCapacity; }
     public int getBagInitCapacity() { return _data.bagInitCapacity; }
     public int getQuickBagCapacity() { return _data.quickBagCapacity; }
     public int getClothBagCapacity() { return _data.clothBagCapacity; }
     public int getClothBagInitCapacity() { return _data.clothBagInitCapacity; }
     public int getClothBagCapacitySpecial() { return _data.clothBagCapacitySpecial; }
     public Integer getBagInitItemsDropId() { return _data.bagInitItemsDropId; }
     public int getMailBoxCapacity() { return _data.mailBoxCapacity; }
     public float getDamageParamC() { return _data.damageParamC; }
     public float getDamageParamE() { return _data.damageParamE; }
     public float getDamageParamF() { return _data.damageParamF; }
     public float getDamageParamD() { return _data.damageParamD; }
     public float getRoleSpeed() { return _data.roleSpeed; }
     public float getMonsterSpeed() { return _data.monsterSpeed; }
     public int getInitEnergy() { return _data.initEnergy; }
     public int getInitViality() { return _data.initViality; }
     public int getMaxViality() { return _data.maxViality; }
     public int getPerVialityRecoveryTime() { return _data.perVialityRecoveryTime; }

    public void resolve(java.util.HashMap<String, Object> _tables)
    {
        _data.resolve(_tables);
    }

}
