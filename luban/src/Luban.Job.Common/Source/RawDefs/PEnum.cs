using System.Collections.Generic;

namespace Luban.Job.Common.RawDefs
{
    public class EnumItem
    {
        public string Name { get; set; }

        public string Alias { get; set; }

        public string Value { get; set; }

        public string Comment { get; set; }
    }

    public class PEnum
    {

        public string Namespace { get; set; }

        public string Name { get; set; }

        public bool IsFlags { get; set; }

        public bool IsUniqueItemId { get; set; }

        public string Comment { get; set; }

        public List<EnumItem> Items { get; set; } = new List<EnumItem>();
    }
}
