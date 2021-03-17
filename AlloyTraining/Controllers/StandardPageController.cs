using AlloyTraining.Models.Pages;
using EPiServer.Web.Mvc;
using System.Web.Mvc;
using EPiServer;

namespace AlloyTraining.Controllers
{
    public class StandardPageController : PageControllerBase<StandardPage>
    {
        public StandardPageController(IContentLoader loader) : base(loader)
        {
        }

        public ActionResult Index(StandardPage currentPage)
        {
            return View(CreatePageViewModel(currentPage));
        }
    }
}