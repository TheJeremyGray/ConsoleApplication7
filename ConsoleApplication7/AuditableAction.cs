using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApplication7.Models;

namespace ConsoleApplication7
{
    public abstract class AuditableAction
    {
        public AuditableAction() { this.Audits = new List<Audit>(); }

        public virtual IList<Audit> Audits { get; set; }

        public void Audit(string description)
        {
            this.Audits.Add(new Audit()
            {
                EntityId = this.GetEntityId(),
                AffectedId = this.Id,
                NewValue = description
            });
        }

        public abstract int Id { get; set; }
        public abstract int GetEntityId();
    }
}