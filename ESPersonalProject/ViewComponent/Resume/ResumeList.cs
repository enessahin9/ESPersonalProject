using Business.Service;
using Microsoft.AspNetCore.Mvc;

namespace ESPersonalProject.ViewComponent.Resume;

public class ResumeList : Microsoft.AspNetCore.Mvc.ViewComponent
{
	private readonly IResumeService _resumeService;

	public ResumeList(IResumeService resumeService)
	{
		_resumeService = resumeService;
	}

	public IViewComponentResult Invoke()
	{
		var values = _resumeService.TGetList();
		return View();
	}
}
