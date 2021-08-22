//引用
//作者：focus-creative-games 
//地址：https://github.com/focus-creative-games/luban


using Bright.Serialization;

namespace Bright.Config
{
    public abstract class BeanBase : ITypeId
    {
        public abstract int GetTypeId();
    }
}
