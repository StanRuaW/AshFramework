
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

package cfg.role;
public enum EProfession
{
    TEST_PROFESSION(1),
    ;

    private final int value;

    public int getValue() {
        return value;
    }

    EProfession(int value) {
        this.value = value;
    }

    public static EProfession valueOf(int value) {
        if (value == 1) return TEST_PROFESSION;
        throw new IllegalArgumentException("");
    }
}

