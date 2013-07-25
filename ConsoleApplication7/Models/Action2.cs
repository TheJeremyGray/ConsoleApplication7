using System;
using System.Collections.Generic;

namespace ConsoleApplication7.Models
{
    public partial class Action2
    {
        public Action2()
        {
            Audits = new List<Audit>();
        }

        public int Id { get; set; }
        public string Desc { get; set; }
        internal List<Audit> Audits { get; set; }
    }
}
