using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using TraversalCore.Models;

namespace TraversalCore.Controllers
{
	public class HomeController : Controller
	{
		private readonly ILogger<HomeController> _logger;

		public HomeController(ILogger<HomeController> logger)
		{
			_logger = logger;
		}

		public IActionResult Index()
		{
			_logger.LogInformation("Index sayfasý çaðýrýldý");
			return View();
		}

		public IActionResult Privacy()
		{
			DateTime time = Convert.ToDateTime(DateTime.Now.ToLongDateString());
			_logger.LogInformation(time + " " + "Privacy sayfasý çaðýrýldý");
			return View();
		}

		[ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
		public IActionResult Error()
		{
			return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
		}
	}
}
