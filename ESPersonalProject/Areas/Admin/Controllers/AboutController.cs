using Business.Service;
using Microsoft.AspNetCore.Mvc;
using Models;
using System.Drawing;
using static System.Net.Mime.MediaTypeNames;

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
		//var result = _aboutService.TGetList(); //
		return Json(_aboutService.TGetList());
	}

	[HttpGet]
	public IActionResult AboutAdd()
	{
		return View();
	}

	[HttpPost]
	public IActionResult AboutAdd(About about, IFormFile image)
	{
        if (image != null && image.Length > 0)
        {

            var fileName = Guid.NewGuid().ToString() + Path.GetExtension(image.FileName);
            var filePath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/images", fileName);

            using (var stream = new FileStream(filePath, FileMode.Create))
            {
                image.CopyTo(stream);
            }


            about.Image = "/images/" + fileName;
        }

        _aboutService.TAdd(about);
        return Ok();
    }
}
