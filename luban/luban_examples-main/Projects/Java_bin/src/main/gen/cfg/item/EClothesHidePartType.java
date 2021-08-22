
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

package cfg.item;
public enum EClothesHidePartType
{
    /**
     * 胸部
     */
    CHEST(0),
    /**
     * 手
     */
    HEAD(1),
    /**
     * 脊柱上
     */
    SPINE_UPPER(2),
    /**
     * 脊柱下
     */
    SPINE_LOWER(3),
    /**
     * 臀部
     */
    HIP(4),
    /**
     * 腿上
     */
    LEG_UPPER(5),
    /**
     * 腿中
     */
    LEG_MIDDLE(6),
    /**
     * 腿下
     */
    LEG_LOWER(7),
    ;

    private final int value;

    public int getValue() {
        return value;
    }

    EClothesHidePartType(int value) {
        this.value = value;
    }

    public static EClothesHidePartType valueOf(int value) {
        if (value == 0) return CHEST;
        if (value == 1) return HEAD;
        if (value == 2) return SPINE_UPPER;
        if (value == 3) return SPINE_LOWER;
        if (value == 4) return HIP;
        if (value == 5) return LEG_UPPER;
        if (value == 6) return LEG_MIDDLE;
        if (value == 7) return LEG_LOWER;
        throw new IllegalArgumentException("");
    }
}

