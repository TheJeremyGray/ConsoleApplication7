using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace ConsoleApplication7.Models.Mapping
{
    public class Action1Map : EntityTypeConfiguration<Action1>
    {
        public Action1Map()
        {
            // Primary Key
            this.HasKey(t => t.Id);

            // Properties
            this.Property(t => t.Desc)
                .IsRequired();

            // Table & Column Mappings
            this.ToTable("Action1");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.Desc).HasColumnName("Desc");
        }
    }
}
