using System;
using System.Collections.Generic;

namespace ConsoleApplication7.Models
{
    public partial class Action1
    {
        public Action1()
        {
            Audits = new List<Audit>();
        }
        public int Id { get; set; }
        public string Desc { get; set; }
        internal List<Audit> Audits { get; set; }
    }
}
