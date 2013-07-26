using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace ConsoleApplication7.Models.Mapping
{
    public class AuditMap : EntityTypeConfiguration<Audit>
    {
        public AuditMap()
        {
            // Primary Key
            this.HasKey(t => t.Id);

            // Properties
            this.Property(t => t.AffectedId)
                .IsRequired();

            this.Property(t => t.NewValue)
                .HasMaxLength(5000);

            // Table & Column Mappings
            this.ToTable("Audits");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.EntityId).HasColumnName("EntityId");
            this.Property(t => t.AffectedId).HasColumnName("AffectedId");
            this.Property(t => t.NewValue).HasColumnName("NewValue");
            
            
               
       }
    }
}
