using Microsoft.AspNetCore.Mvc;

namespace ESPersonalProject.Controllers
{
	public class DefaultController : Controller
	{
		public IActionResult Index()
		{
			return View();

		}

		public PartialViewResult HeadPartial()
		{
			return PartialView();
		}

		public PartialViewResult HeaderPartial()
		{
			return PartialView();

		}

		public PartialViewResult HeroSectionPartial()
		{
			return PartialView();
		}

		public PartialViewResult AboutPartial()
		{
			return PartialView();
		}
	}
}
