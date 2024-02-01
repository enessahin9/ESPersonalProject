using Business.Service;
using Microsoft.AspNetCore.Mvc;

namespace ESPersonalProject.ViewComponent.About;

public class AboutList : Microsoft.AspNetCore.Mvc.ViewComponent
{
	private readonly IAboutService _aboutService;

	public AboutList(IAboutService aboutService)
	{
		_aboutService = aboutService;
	}

	public IViewComponentResult Invoke()
	{
		var values = _aboutService.TGetList();
		return View(values);
	}
}
