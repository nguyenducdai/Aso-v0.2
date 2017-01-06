using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;
using FluentValidation.Attributes;
using Nop.Admin.Validators.News;
using Nop.Web.Framework;
using Nop.Web.Framework.Mvc;

namespace Nop.Admin.Models.News
{
    [Validator(typeof(NewsItemValidator))]
    public partial class NewsItemModel : BaseNopEntityModel
    {
        public NewsItemModel()
        {
            this.AvailableLanguages = new List<SelectListItem>();

            SelectedStoreIds = new List<int>();
            AvailableStores = new List<SelectListItem>();
        }

        [NopResourceDisplayName("Admin.ContentManagement.News.NewsItems.Fields.Language")]
        public int LanguageId { get; set; }
        public IList<SelectListItem> AvailableLanguages { get; set; }

        [NopResourceDisplayName("Admin.ContentManagement.News.NewsItems.Fields.Language")]
        [AllowHtml]
        public string LanguageName { get; set; }

        //[NopResourceDisplayName("Admin.ContentManagement.News.NewsItems.Fields.Image")]
        //public string Image { get; set; }
        
        [NopResourceDisplayName("Admin.ContentManagement.News.NewsItems.Fields.Picture")]
        public string Picture { get; set; }

        //store mapping
        [NopResourceDisplayName("Admin.ContentManagement.News.NewsItems.Fields.LimitedToStores")]
        [UIHint("MultiSelect")]
        public IList<int> SelectedStoreIds { get; set; }
        public IList<SelectListItem> AvailableStores { get; set; }

        [NopResourceDisplayName("Admin.ContentManagement.News.NewsItems.Fields.Title")]
        [AllowHtml]
        public string Title { get; set; }

        [NopResourceDisplayName("Admin.ContentManagement.News.NewsItems.Fields.Short")]
        [AllowHtml]
        [StringLength(300, ErrorMessage = "Độ dài tối đa là 300 ký tự")]
        public string Short { get; set; }

        [NopResourceDisplayName("Admin.ContentManagement.News.NewsItems.Fields.Full")]
        [AllowHtml]
        public string Full { get; set; }

        [NopResourceDisplayName("Admin.ContentManagement.News.NewsItems.Fields.AllowComments")]
        public bool AllowComments { get; set; }

        [NopResourceDisplayName("Admin.ContentManagement.News.NewsItems.Fields.StartDate")]
        [UIHint("DateTimeNullable")]
        public DateTime? StartDate { get; set; }

        [NopResourceDisplayName("Admin.ContentManagement.News.NewsItems.Fields.EndDate")]
        [UIHint("DateTimeNullable")]
        public DateTime? EndDate { get; set; }

        [NopResourceDisplayName("Admin.ContentManagement.News.NewsItems.Fields.MetaKeywords")]
        [AllowHtml]
        public string MetaKeywords { get; set; }

        [NopResourceDisplayName("Admin.ContentManagement.News.NewsItems.Fields.MetaDescription")]
        [AllowHtml]
        public string MetaDescription { get; set; }

        [NopResourceDisplayName("Admin.ContentManagement.News.NewsItems.Fields.MetaTitle")]
        [AllowHtml]
        public string MetaTitle { get; set; }

        [NopResourceDisplayName("Admin.ContentManagement.News.NewsItems.Fields.SeName")]
        [AllowHtml]
        public string SeName { get; set; }

        [NopResourceDisplayName("Admin.ContentManagement.News.NewsItems.Fields.Published")]
        public bool Published { get; set; }

        [NopResourceDisplayName("Admin.ContentManagement.News.NewsItems.Fields.Comments")]
        public int Comments { get; set; }

        [NopResourceDisplayName("Admin.ContentManagement.News.NewsItems.Fields.CreatedOn")]
        public DateTime CreatedOn { get; set; }
    }
}