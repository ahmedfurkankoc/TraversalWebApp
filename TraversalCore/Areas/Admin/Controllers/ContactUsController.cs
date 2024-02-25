using BusinessLayer.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace TraversalCore.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class ContactUsController : Controller
    {
        private readonly IContacUsService _contacusService;

        public ContactUsController(IContacUsService contacusService)
        {
            _contacusService = contacusService;
        }

        public IActionResult Index()
        {
            var values = _contacusService.TGetListByTrue();
            return View(values);
        }
    }
}
