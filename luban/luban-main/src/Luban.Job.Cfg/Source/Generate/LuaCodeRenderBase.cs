﻿using Luban.Job.Cfg.Defs;
using Luban.Job.Common.Defs;
using Scriban;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Luban.Job.Cfg.Generate
{
    abstract class LuaCodeRenderBase : CodeRenderBase
    {

        public override string Render(DefConst c)
        {
            throw new System.NotImplementedException();
        }

        public override string Render(DefEnum e)
        {
            throw new System.NotImplementedException();
        }

        public override string Render(DefTable c)
        {
            throw new System.NotImplementedException();
        }

        public override string Render(DefBean b)
        {
            throw new NotImplementedException();
        }

        public override string RenderService(string name, string module, List<DefTable> tables)
        {
            throw new System.NotImplementedException();
        }

        public abstract string RenderAll(List<DefTypeBase> types);
    }
}
