using Business.Service;
using Microsoft.AspNetCore.Mvc;
using System.Drawing.Text;

namespace ESPersonalProject.ViewComponent.Service
{
	public class ServiceList : Microsoft.AspNetCore.Mvc.ViewComponent
	{
		private readonly IServiceService _serviceService;

		public ServiceList(IServiceService serviceService)
		{
			_serviceService = serviceService;
		}

		public IViewComponentResult Invoke()
		{
			var values = _serviceService.TGetList();
			return View(values);
		}
	}
}
