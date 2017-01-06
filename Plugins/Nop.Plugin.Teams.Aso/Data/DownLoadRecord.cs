using Nop.Core;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace Nop.Plugin.Teams.Aso.Data
{
    public class DownLoadRecord : BaseEntity
    {
        [Required(ErrorMessage = "Vui lòng nhập Tên tài liệu ")]
        public string Title { set; get; }

        [Required(ErrorMessage = "Chọn ảnh đại diện cho tài liệu")]
        public string Image { set; get; }

        [Required(ErrorMessage = "Chọn tài liệu tải lên")]
        public string File { set; get; }

        public DateTime Create_at { set; get; }
    }

    
    }
