using Business.Service;
using Microsoft.AspNetCore.Mvc;

namespace ESPersonalProject.ViewComponent.Blog
{
	public class BlogList : Microsoft.AspNetCore.Mvc.ViewComponent
	{
	
		
		private readonly IBlogDetailService _blogDetailService;

		public BlogList(IBlogDetailService blogDetailService)
		{
			_blogDetailService = blogDetailService;
		}

		public IViewComponentResult Invoke()
		{
			var values=_blogDetailService.TGetList();
		
			return View(values);
		}
	}
}
