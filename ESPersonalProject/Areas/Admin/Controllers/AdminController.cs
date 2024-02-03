using Microsoft.AspNetCore.Mvc;

namespace ESPersonalProject.Areas.Admin.Controllers;

public class AdminController : Controller
{
	public IActionResult Index()
	{
		return View();
	}
}
