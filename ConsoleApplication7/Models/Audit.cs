using System;
using System.Collections.Generic;

namespace ConsoleApplication7.Models
{
    public partial class Audit
    {
        public int Id { get; set; }
        public int EntityId { get; set; }
        public int AffectedId { get; set; }
        public string NewValue { get; set; }
    }
}
