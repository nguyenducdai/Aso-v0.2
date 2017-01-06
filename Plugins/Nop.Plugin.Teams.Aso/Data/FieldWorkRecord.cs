using Nop.Core;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nop.Plugin.Teams.Aso.Data
{
   public class FieldWorkRecord : BaseEntity
    {
        [Required(ErrorMessage = "Vui lòng nhập Tên bài viết ")]
        public string Title { set; get; }

        [Required(ErrorMessage = "Vui lòng Mô tả bài viết ")]
        [StringLength(200)]
        public string Descaption { set; get; }

        [Required(ErrorMessage = "Vui lòng Nội Dung bài viết ")]
        public string Content { set; get; }

        [Required(ErrorMessage = "Vui lòng chọn hình ảnh đại diện ")]
        public string Image { set; get; }
        public string MetaTitle { set; get; }
        public string MetaKeywords { set; get; }
        public string MetaDescription { set; get; }
        public DateTime Create_at { set; get; }
    }
}
