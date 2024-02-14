using Business.Service;
using Microsoft.AspNetCore.Mvc;
using Models;

namespace ESPersonalProject.Areas.Admin.Controllers
{
	[Area("Admin")]
	public class BlogCategoryController : Controller
	{
		private readonly IBlogCategoryService _blogCategoryService;

		public BlogCategoryController(IBlogCategoryService blogCategoryService)
		{
			_blogCategoryService = blogCategoryService;
		}

		public IActionResult Index()
		{
			return View();
		}
		public IActionResult GetAll()
		{
			var values = _blogCategoryService.TGetList();
			return Json(values);
		}
		[HttpGet]
		public IActionResult AddBlog()
		{
			return View();
		}
		[HttpPost]
		public IActionResult AddBlog(BlogCategory blogCategory)
		{
		  _blogCategoryService.TAdd(blogCategory);
			return Ok();
		}
		[HttpPost]
		public IActionResult DeleteBC(int id)
		{
			var values = _blogCategoryService.TGetById(id);
			_blogCategoryService.TDelete(values);
			return Ok();
		}
	}
}

