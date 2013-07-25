using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using ConsoleApplication7.Models.Mapping;

namespace ConsoleApplication7.Models
{
    public partial class yunoworkContext : DbContext
    {
        static yunoworkContext()
        {
            Database.SetInitializer<yunoworkContext>(null);
        }

        public yunoworkContext()
            : base("Name=yunoworkContext")
        {
        }

        public DbSet<Action1> Action1 { get; set; }
        public DbSet<Action2> Action2 { get; set; }
        public DbSet<Audit> Audits { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new Action1Map());
            modelBuilder.Configurations.Add(new Action2Map());
            modelBuilder.Configurations.Add(new AuditMap());
        }
    }
}
