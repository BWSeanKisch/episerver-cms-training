using System.Linq;
using System.Web.Mvc;
using System.Web.Security;
using AlloyTraining.Business.ExtensionMethods;
using AlloyTraining.Models.Pages;
using AlloyTraining.Models.ViewModels;
using EPiServer;
using EPiServer.Core;
using EPiServer.Filters;
using EPiServer.Web.Mvc;
using StructureMap.Diagnostics.TreeView;

namespace AlloyTraining.Controllers
{
    public class PageControllerBase<T> : PageController<T> where T : SitePageData
    {
        protected readonly IContentLoader loader;

        public PageControllerBase(IContentLoader loader)
        {
            this.loader = loader;
        }

        public ActionResult Logout()
        {
            FormsAuthentication.SignOut();
            return RedirectToAction("Index");
        }

        protected IPageViewModel<TPage> CreatePageViewModel<TPage>(TPage currentPage) where TPage : SitePageData
        {
            return new DefaultPageViewModel<TPage>
            {
                CurrentPage = currentPage,
                StartPage = loader.Get<StartPage>(ContentReference.StartPage),
                MenuPages = FilterForVisitor.Filter(
                            loader.GetChildren<SitePageData>(ContentReference.StartPage))
                            .Cast<SitePageData>()
                            .Where(page => page.VisibleInMenu),
                Section = currentPage.ContentLink.GetSection()
            }
            ;
        }
    }
}