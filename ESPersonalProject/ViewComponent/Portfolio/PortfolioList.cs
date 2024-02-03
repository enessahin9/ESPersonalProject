using Business.Service;
using Microsoft.AspNetCore.Mvc;

namespace ESPersonalProject.ViewComponent.Portfolio;

public class PortfolioList : Microsoft.AspNetCore.Mvc.ViewComponent
{
	private readonly IWorkService _workService;

	public PortfolioList(IWorkService workService)
	{
		_workService = workService;
	}

	public IViewComponentResult Invoke()
	{
		var values = _workService.TGetList();
		return View(values);
	}
}
