using Nop.Core.Configuration;

namespace Nop.Core.Domain.FieldWork
{
    public class FieldWorkSetting : ISettings
    {
        /// <summary>
        /// Gets or sets a value indicating whether news are enabled
        /// </summary>
        public bool Enabled { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether not registered user can leave comments
        /// </summary>
        public bool AllowNotRegisteredUsersToLeaveComments { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether to notify about new news comments
        /// </summary>
        public bool NotifyAboutFieldWorkNewsComments { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether to show news on the main page
        /// </summary>
        public bool ShowFieldWorksOnMainPage { get; set; }

        /// <summary>
        /// Gets or sets a value indicating news count displayed on the main page
        /// </summary>
        public int MainPageFieldWorkCount { get; set; }

        /// <summary>
        /// Gets or sets the page size for news archive
        /// </summary>
        public int FieldWorksArchivePageSize { get; set; }

        /// <summary>
        /// Enable the news RSS feed link in customers browser address bar
        /// </summary>
        public bool ShowHeaderRssUrl { get; set; }
    }
}