using Nop.Web.Framework.Mvc;
using System;
using System.Web.Mvc;

namespace Nop.Web.Models.FieldWork
{
    public class FieldWorkModel : BaseNopModel
    {
        [AllowHtml]
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