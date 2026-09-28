using Microsoft.AspNetCore.Mvc;

namespace WeekendApp.Controllers
{
	public class HomeController : Controller
	{
		public IActionResult Index()
		{
			return View();
		}

		public IActionResult Weekend()
		{
			return View();
		}
	}
}