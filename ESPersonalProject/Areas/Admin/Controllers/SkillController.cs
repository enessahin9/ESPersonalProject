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

	[HttpGet]
	public IActionResult SkillUpdateGet(int id)
	{
	 var values=_skillService.TGetById(id);
		if (values==null)
		{
			return NotFound();

		}
		return Json(values);
	}
	[HttpPost]
	public IActionResult SkillUpdate(Skill skill)
	{
		var values=_skillService.TGetById(skill.Id);
		
		_skillService.TUpdate(values);
		return Ok();
	}
}
