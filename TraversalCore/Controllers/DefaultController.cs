using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace TraversalCore.Controllers
{
	[AllowAnonymous]
	public class DefaultController : Controller
	{
        DestinationManager destinationManager = new DestinationManager(new EfDestinationDal());

        public IActionResult Index()
		{
			var values = destinationManager.TGetList();
			return View(values);
		}
	}
}
