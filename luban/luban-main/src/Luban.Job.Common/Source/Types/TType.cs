using Luban.Job.Common.TypeVisitors;

namespace Luban.Job.Common.Types
{
    public abstract class TType
    {
        public bool IsNullable { get; }

        protected TType(bool isNullable)
        {
            IsNullable = isNullable;
        }

        public abstract bool TryParseFrom(string s);

        public virtual bool IsCollection => false;

        public virtual bool IsBean => false;

        public abstract void Apply<T>(ITypeActionVisitor<T> visitor, T x);
        public abstract void Apply<T1, T2>(ITypeActionVisitor<T1, T2> visitor, T1 x, T2 y);
        public abstract TR Apply<TR>(ITypeFuncVisitor<TR> visitor);
        public abstract TR Apply<T, TR>(ITypeFuncVisitor<T, TR> visitor, T x);
        public abstract TR Apply<T1, T2, TR>(ITypeFuncVisitor<T1, T2, TR> visitor, T1 x, T2 y);
        public abstract TR Apply<T1, T2, T3, TR>(ITypeFuncVisitor<T1, T2, T3, TR> visitor, T1 x, T2 y, T3 z);
    }
}
