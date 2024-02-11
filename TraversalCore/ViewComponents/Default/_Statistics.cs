using BusinessLayer.Concrete;
using DataAccessLayer.Concrete;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace TraversalCore.ViewComponents.Default
{
    public class _Statistics : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            using var _context = new Context();
            ViewBag.v1 = _context.Set<Destination>().Count();
            ViewBag.v2 = _context.Set<Guide>().Count();
            ViewBag.v3 = "1885";
            return View();
        }
    }
}
