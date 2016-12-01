using Nop.Core.Domain.Seo;
using Nop.Core.Domain.Stores;
using System;

namespace Nop.Core.Domain.FieldWork
{
    public partial class FieldWorkItem : BaseEntity, ISlugSupported, IStoreMappingSupported
    {
        public string Title { set; get; }
        public string Descaption { set; get; }
        public string Content { set; get; }
        public string Image { set; get; }
        public string MetaTitle { set; get; }
        public string MetaKeywords { set; get; }
        public string MetaDescription { set; get; }
        public DateTime Create_at { set; get; }
        public bool LimitedToStores { set; get; }
    }
}