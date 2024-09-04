using System;
using System.Collections.Generic;

namespace Business.Entities
{
    public partial class StaticParam
    {
        public string Key { get; set; } = null!;
        public string Value { get; set; } = null!;
        public string? Description { get; set; }
    }
}
