using Business.Service;
using Microsoft.AspNetCore.Mvc;
using Models;

namespace ESPersonalProject.Areas.Admin.Controllers;

[Area("Admin")]

public class SkillController : Controller
{
	private readonly ISkillService _skillService;

	public SkillController(ISkillService skillService)
	{
		_skillService = skillService;
	}

	public IActionResult Index()
	{
		return View();
	}

	public IActionResult GetAll()
	{
		return Json(_skillService.TGetList());
	}

	[HttpGet]
	public IActionResult SkillAdd()
	{
		return View();
	}

	[HttpPost]
	public IActionResult SkillAdd(Skill skill)
	{
		_skillService.TAdd(skill);
		return Ok();
	}

	[HttpPost]
	public IActionResult SkillDelete(int id)
	{
		var result = _skillService.TGetById(id);
		_skillService.TDelete(result);
		return Ok();
	}

	[HttpPost]
	public IActionResult SkillUpdate()
	{
		return Ok();
	}
}
