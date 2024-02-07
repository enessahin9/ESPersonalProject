using Business.Service;
using Microsoft.AspNetCore.Mvc;
using Models;

namespace ESPersonalProject.Areas.Admin.Controllers;


[Area("Admin")] // Her controller icin belirtmek zorundayiz. Yoksa yolu bulamaz.
public class SocialMediaController : Controller
{
	private readonly ISocialMediaService _socialMediaService;

	public SocialMediaController(ISocialMediaService socialMediaService)
	{
		_socialMediaService = socialMediaService;
	}

	public IActionResult Index()
	{

		return View();
	}

	public IActionResult GetAll()
	{
		return Json(_socialMediaService.TGetList());
	}

	[HttpGet]
	public IActionResult SocialMediaAdd()
	{
		return View();
	}

	[HttpPost]
	public IActionResult SocialMediaAdd(SocialMedia socialMedia)
	{
		_socialMediaService.TAdd(socialMedia);
		return Ok();
	}

	[HttpPost]
	public IActionResult SocialMediaDelete(int id)
	{
		var result = _socialMediaService.TGetById(id);
		_socialMediaService.TDelete(result);
		return Ok();
	}
}

