using Microsoft.AspNetCore.Mvc;

namespace ESPersonalProject.Controllers;

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

	public PartialViewResult HeroSectionPartial()
	{
		return PartialView();
	}

	public PartialViewResult FooterPartial()
	{
		return PartialView();
	}
}
