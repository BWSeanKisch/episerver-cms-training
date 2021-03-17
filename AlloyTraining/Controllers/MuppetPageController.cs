using EPiServer.Web.Mvc;
using System.Web.Mvc;
using AlloyTraining.Models.Pages;
using EPiServer.Framework.DataAnnotations;

namespace AlloyTraining.Controllers
{
    [TemplateDescriptor(Inherited = true, Default = true, Name = "For the summer")]
    public class MuppetPageController : PageController<DemoPage>
    {
        public ActionResult Index(DemoPage currentPage)
        {
            return View(currentPage);
        }
    }
}