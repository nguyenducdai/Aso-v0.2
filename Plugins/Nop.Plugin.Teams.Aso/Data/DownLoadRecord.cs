using Nop.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nop.Plugin.Teams.Aso.Data
{
    public class DownLoadRecord : BaseEntity
    {
        public string Title { set; get; }
        public string Image { set; get; }
        public string File { set; get; }
        public DateTime Create_at { set; get; }
    }
}
