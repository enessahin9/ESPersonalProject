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

		public PartialViewResult ServicePartial()
		{
			return PartialView();	
		}

		public PartialViewResult PortfolioPartial() 
		{
			return PartialView();
		}

		public PartialViewResult ContactPartial()
		{
			return PartialView();	
		}

		public PartialViewResult FooterPartial()
		{
			return PartialView();
		}
	}
}
