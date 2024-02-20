using Business.Service;
using Microsoft.AspNetCore.Mvc;

namespace ESPersonalProject.ViewComponent.Skill;

public class SkillList : Microsoft.AspNetCore.Mvc.ViewComponent
{
	private readonly ISkillService _skillService;

	public SkillList(ISkillService skillService)
	{
		_skillService = skillService;
	}

	public IViewComponentResult Invoke()
	{
		var values = _skillService.TGetList();
		return View(values);
	}
}
