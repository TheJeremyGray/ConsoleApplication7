using System;
using System.Collections.Generic;

namespace ConsoleApplication7.Models
{
    public partial class Audit
    {
        public int Id { get; set; }
        public int EntityId { get; set; }
        public string AffectedId { get; set; }
        public string NewValue { get; set; }
        internal Action1 Action1 { get; set; }
        internal Action2 Action2 { get; set; }
    }
}
