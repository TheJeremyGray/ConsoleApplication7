using System.Collections.Generic;
using ConsoleApplication7.Models;

namespace ConsoleApplication7
{
    public abstract class AuditableAction
    {
        public AuditableAction()
        {
            this.Audits = new List<Audit>();
        }

        public virtual IList<Audit> Audits { get; set; }

        public string Desc { get; set; }

        public abstract int EntityId { get; }

        public int Id { get; set; }

        public void Audit(string description)
        {
            this.Audits.Add(new Audit()
            {
                EntityId = this.EntityId,
                AffectedId = this.Id.ToString(),
                NewValue = description
            });
        }
    }
}