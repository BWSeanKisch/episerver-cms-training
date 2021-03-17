using AlloyTraining.Models.Pages;
using EPiServer.Web.Mvc;
using System.Web.Mvc;
using EPiServer.Framework.DataAnnotations;

namespace AlloyTraining.Controllers
{
    [TemplateDescriptor(Inherited = false, Default = true, Name = "For the winter")]

    public class DemoPageController : PageController<DemoPage>
    {
        public ActionResult Index(DemoPage currentPage)
        {
            /* Implementation of action. You can create your own view model class that you pass to the view or
             * you can pass the page type for simpler templates */

            return View(currentPage);
        }
    }
}