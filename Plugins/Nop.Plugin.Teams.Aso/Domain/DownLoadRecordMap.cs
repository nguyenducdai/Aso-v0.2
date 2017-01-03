using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Nop.Plugin.Teams.Aso.Data;
using System.Data.Entity.ModelConfiguration;

namespace Nop.Plugin.Teams.Aso.Domain
{
    public class DownLoadRecordMap : EntityTypeConfiguration<DownLoadRecord>
    {
        public DownLoadRecordMap(){
            this.ToTable("FileDocument");
            this.Property(m => m.Title);
            this.Property(m => m.Image);
            this.Property(m => m.File);
            this.Property(m => m.Create_at);
        }
    }
}
