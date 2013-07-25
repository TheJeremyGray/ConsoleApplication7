using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace ConsoleApplication7.Models.Mapping
{
    public class Action2Map : EntityTypeConfiguration<Action2>
    {
        public Action2Map()
        {
            // Primary Key
            this.HasKey(t => t.Id);

            // Properties
            this.Property(t => t.Desc)
                .IsRequired();

            // Table & Column Mappings
            this.ToTable("Action2");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.Desc).HasColumnName("Desc");
        }
    }
}
