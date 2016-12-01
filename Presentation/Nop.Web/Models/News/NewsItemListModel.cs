using System.Collections.Generic;
using Nop.Web.Framework.Mvc;

namespace Nop.Web.Models.News
{
    public partial class NewsItemListModel : BaseNopModel
    {
        public NewsItemListModel()
        {
            PagingFilteringContext = new NewsPagingFilteringModel();
            NewsItems = new List<NewsItemModel>();

            News = new List<TopMenuNewsModel>();
        }

        public int WorkingLanguageId { get; set; }
        public NewsPagingFilteringModel PagingFilteringContext { get; set; }
        public IList<NewsItemModel> NewsItems { get; set; }

        public IList<TopMenuNewsModel> News { get; set; }

        public class TopMenuNewsModel : BaseNopEntityModel
        {
            public string Name { get; set; }
            public string SeName { get; set; }
        }
    }
}