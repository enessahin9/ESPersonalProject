using Microsoft.AspNetCore.Mvc;

namespace ESPersonalProject.Controllers
{
	public class BlogController : Controller
	{
		public IActionResult Index()
		{
			return View();
		}
		public IActionResult BlogDetail()
		{
			return View();
		}
	}
}
