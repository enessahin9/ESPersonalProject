using Microsoft.AspNetCore.Mvc;

namespace ESPersonalProject.Controllers
{
	public class DenemeController : Controller
	{
		public IActionResult Index()
		{
			return View();
		}
	}
}
