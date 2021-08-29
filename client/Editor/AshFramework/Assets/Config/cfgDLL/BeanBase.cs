using Plugin.Bright.Serialization;

namespace Plugin.Bright.Config
{
    public abstract class BeanBase : ITypeId
    {
        public abstract int GetTypeId();
    }
}
