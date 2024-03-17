using Business.Service;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace ESPersonalProject.Controllers
{
	[AllowAnonymous]
	public class BlogController : Controller
	{
	
		private readonly IBlogDetailService _blogDetailService;

		public BlogController(IBlogDetailService blogDetailService)
		{
			_blogDetailService = blogDetailService;
		}

		public IActionResult Index(int id)
		{ 
			var detail=_blogDetailService.TGetById(id);
			if (detail == null)
			{
				return NotFound();
			}
			return View(detail);
		}
	
	}
}
