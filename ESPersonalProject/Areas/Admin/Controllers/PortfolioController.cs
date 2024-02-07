using Business.Service;
using Microsoft.AspNetCore.Mvc;
using Models;

namespace ESPersonalProject.Areas.Admin.Controllers;

[Area("Admin")]
public class PortfolioController : Controller
{
	private readonly IWorkService _workService;

	public PortfolioController(IWorkService workService)
	{
		_workService = workService;
	}

	public IActionResult Index()
	{
		return View();
	}

	[HttpGet]
	public IActionResult GetAll()
	{
		return Json(_workService.TGetList());
	}

	[HttpGet]
	public IActionResult WorkAdd()
	{
		return View();
	}

	[HttpPost]
	public IActionResult WorkAdd(Portfolio portfolio)
	{
		_workService.TAdd(portfolio);
		return Ok();
	}

	public IActionResult WorkUpdate()
	{
		return View();
	}

	public IActionResult WorkDelete(int id)
	{
		var values = _workService.TGetById(id);
		_workService.TDelete(values);
		return Ok();
	}
}
