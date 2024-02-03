using Business.Service;
using Microsoft.AspNetCore.Mvc;

namespace ESPersonalProject.Areas.Admin.Controllers;

[Area("Admin")] // Her controller icin belirtmek zorundayiz. Yoksa yolu bulamaz.
public class AboutController : Controller
{
	private readonly IAboutService _aboutService;

	public AboutController(IAboutService aboutService)
	{
		_aboutService = aboutService;
	}

	public IActionResult Index()
	{
	
		return View();
	}

	public IActionResult GetAll()
	{
		var result = _aboutService.TGetList();
		return Json(result);
	}
}
