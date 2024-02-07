using Business.Service;
using Microsoft.AspNetCore.Mvc;
using Models;
using System.Drawing;
using static System.Net.Mime.MediaTypeNames;

namespace ESPersonalProject.Areas.Admin.Controllers;

[Area("Admin")] // Her controller icin belirtmek zorundayiz. Yoksa yolu bulamaz.
public class ServiceController : Controller
{
	private readonly IServiceService _serviceService;

	public ServiceController(IServiceService serviceService)
	{
		_serviceService = serviceService;
	}

	public IActionResult Index()
	{

		return View();
	}

	public IActionResult GetAll()
	{
		return Json(_serviceService.TGetList());
	}

	[HttpGet]
	public IActionResult ServiceAdd()
	{
		return View();
	}

	[HttpPost]
	public IActionResult ServiceAdd(Service service)
	{
		_serviceService.TAdd(service);
		return Ok();
	}

	[HttpPost]
	public IActionResult ServiceDelete(int id)
	{
		var result = _serviceService.TGetById(id);
		_serviceService.TDelete(result);
		return Ok();
	}
}
