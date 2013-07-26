using System;
using System.Collections.Generic;

namespace ConsoleApplication7.Models
{
    public partial class Action1 : AuditableAction
    {
        public override int EntityId
        {
            get
            {
                return 3;
            }
        }
    }
}
