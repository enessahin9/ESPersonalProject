using Business.Service;
using Microsoft.AspNetCore.Mvc;
using Models;

namespace ESPersonalProject.Areas.Admin.Controllers;

[Area("Admin")]

public class ResumeController : Controller
{
	private readonly IResumeService _resumeService;

	public ResumeController(IResumeService resumeService)
	{
		_resumeService = resumeService;
	}

	public IActionResult Index()
	{
		return View();
	}

	public IActionResult GetAll()
	{
		return Json(_resumeService.TGetList());
	}

	[HttpGet]
	public IActionResult ResumeAdd()
	{
		return View();
	}

	[HttpPost]
	public IActionResult ResumeAdd(Resume resume)
	{
		_resumeService.TAdd(resume);
		return Ok();
	}


	[HttpPost]
	public IActionResult ResumeDelete(int id)
	{
		var result = _resumeService.TGetById(id);
		_resumeService.TDelete(result);
		return Ok();
	}

	[HttpPost]
	public IActionResult ResumeUpdate()
	{
		return RedirectToAction();
	}
}
