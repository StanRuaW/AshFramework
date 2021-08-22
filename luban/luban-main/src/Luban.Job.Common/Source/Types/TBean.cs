using Luban.Job.Common.Defs;
using Luban.Job.Common.TypeVisitors;
using System;

namespace Luban.Job.Common.Types
{
    public class TBean : TType
    {
        public DefBeanBase Bean { get; set; }

        public T GetBeanAs<T>() where T : DefBeanBase => (T)Bean;

        public TBean(DefBeanBase defBean, bool isNullable) : base(isNullable)
        {
            this.Bean = defBean;
        }

        public override bool TryParseFrom(string s)
        {
            throw new NotSupportedException();
        }

        public bool IsDynamic => Bean.IsAbstractType;

        public override bool IsBean => true;

        public override void Apply<T>(ITypeActionVisitor<T> visitor, T x)
        {
            visitor.Accept(this, x);
        }

        public override void Apply<T1, T2>(ITypeActionVisitor<T1, T2> visitor, T1 x, T2 y)
        {
            visitor.Accept(this, x, y);
        }

        public override TR Apply<TR>(ITypeFuncVisitor<TR> visitor)
        {
            return visitor.Accept(this);
        }

        public override TR Apply<T, TR>(ITypeFuncVisitor<T, TR> visitor, T x)
        {
            return visitor.Accept(this, x);
        }

        public override TR Apply<T1, T2, TR>(ITypeFuncVisitor<T1, T2, TR> visitor, T1 x, T2 y)
        {
            return visitor.Accept(this, x, y);
        }

        public override TR Apply<T1, T2, T3, TR>(ITypeFuncVisitor<T1, T2, T3, TR> visitor, T1 x, T2 y, T3 z)
        {
            return visitor.Accept(this, x, y, z);
        }
    }
}
