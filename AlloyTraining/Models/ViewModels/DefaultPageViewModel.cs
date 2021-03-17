using AlloyTraining.Models.Pages;
using EPiServer.Core;
using System.Collections.Generic;

namespace AlloyTraining.Models.ViewModels
{
    public class DefaultPageViewModel<T> : IPageViewModel<T> where T : SitePageData
    {
        public T CurrentPage { get; set; }
        public StartPage StartPage { get; set; }
        public IEnumerable<SitePageData> MenuPages { get; set; }
        public IContent Section { get; set; }
    }
}