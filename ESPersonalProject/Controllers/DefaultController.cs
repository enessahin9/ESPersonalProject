﻿using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace ESPersonalProject.Controllers;
[AllowAnonymous] //Loginden etkilenme 
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

	public PartialViewResult FooterPartial()
	{
		return PartialView();
	}
	public PartialViewResult LoaderPartial()
	{
		return PartialView();
	}
	public  PartialViewResult MenuPartial()
	{
		return PartialView();
	}
}
