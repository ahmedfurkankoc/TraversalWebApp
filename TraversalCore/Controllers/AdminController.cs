using Microsoft.AspNetCore.Mvc;

namespace TraversalCore.Controllers
{
    public class AdminController : Controller
    {
        public PartialViewResult PartialHead()
        {
            return PartialView();
        }
        public PartialViewResult PartialAside()
        {
            return PartialView();
        }

        public PartialViewResult PartialNavbar()
        {
            return PartialView();
        }
        public PartialViewResult PartialScript()
        {
            return PartialView();
        }
        public PartialViewResult PartialFooter()
        {
            return PartialView();
        }
    }
}
