
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

package cfg.ai;
public enum EExecutor
{
    CLIENT(0),
    SERVER(1),
    ;

    private final int value;

    public int getValue() {
        return value;
    }

    EExecutor(int value) {
        this.value = value;
    }

    public static EExecutor valueOf(int value) {
        if (value == 0) return CLIENT;
        if (value == 1) return SERVER;
        throw new IllegalArgumentException("");
    }
}

