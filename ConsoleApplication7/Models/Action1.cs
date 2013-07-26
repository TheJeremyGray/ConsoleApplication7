using System;
using System.Collections.Generic;

namespace ConsoleApplication7.Models
{
    public partial class Action1 : AuditableAction
    {
        public int Id { get; set; }
        public string Desc { get; set; }

        public override string AffectedId
        {
            get { return Id.ToString(); }
        }

        public override int GetEntityId()
        {
            // this is an enum in real program :)
            return 3;
        }
    }
}
