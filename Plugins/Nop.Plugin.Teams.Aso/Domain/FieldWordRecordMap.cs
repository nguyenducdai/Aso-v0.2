using Nop.Plugin.Teams.Aso.Data;
using System.Data.Entity.ModelConfiguration;

namespace Nop.Plugin.Teams.Aso.Domain
{
    public class FieldWordRecordMap : EntityTypeConfiguration<FieldWorkRecord>
    {
        public FieldWordRecordMap()
        {
            this.ToTable("FieldWord");
            this.Property(m => m.Title);
            this.Property(m => m.Descaption);
            this.Property(m => m.Content);
            this.Property(m => m.Image);
            this.Property(m => m.MetaTitle);
            this.Property(m => m.MetaKeywords);
            this.Property(m => m.MetaDescription);
        }
    }
}