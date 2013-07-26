using System;
using System.Collections.Generic;

namespace ConsoleApplication7.Models
{
    public partial class Action1 : AuditableAction
    {
        public override int Id { get; set; }
        public string Desc { get; set; }

        public override int GetEntityId()
        {
            // this is an enum in real program :)
            return 3;
        }
    }
}
