using Nop.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nop.Plugin.Teams.Aso.Data
{
   public class FieldWorkRecord : BaseEntity
    {
        public string Title { set; get; }
        public string Descaption { set; get; }
        public string Content { set; get; }
        public string Image { set; get; }
        public string MetaTitle { set; get; }
        public string MetaKeywords { set; get; }
        public string MetaDescription { set; get; }
        public DateTime Create_at { set; get; }
    }
}
