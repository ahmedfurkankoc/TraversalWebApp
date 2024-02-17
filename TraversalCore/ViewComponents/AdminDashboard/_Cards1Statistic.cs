using DataAccessLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace TraversalCore.ViewComponents.AdminDashboard
{
    public class _Cards1Statistic : ViewComponent
    {
        Context context = new Context();
        public IViewComponentResult Invoke()
        {
            ViewBag.destCount = context.Destinations.Count();
            ViewBag.userCount = context.Users.Count();

            return View();
        }
    }
}
