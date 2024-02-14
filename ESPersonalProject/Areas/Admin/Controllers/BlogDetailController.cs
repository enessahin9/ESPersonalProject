using Business.Service;
using Helper;
using Microsoft.AspNetCore.Mvc;
using Models;

namespace ESPersonalProject.Areas.Admin.Controllers
{
	[Area("Admin")]
	public class BlogDetailController : Controller
	{
		private readonly IBlogDetailService _blogDetailService;
        private readonly FileUpload _fileUpload;

        public BlogDetailController(IBlogDetailService blogDetailService ,FileUpload fileUpload)
		{
			_blogDetailService = blogDetailService;
			_fileUpload = fileUpload;
		}

		public IActionResult Index()
		{
			return View();
		}
		public IActionResult GetALl()
		{
			
			return View(_blogDetailService.TGetList());
		}
		[HttpGet]
		public IActionResult AddBlogDetail()
		{
			return View();
		}
        [HttpPost]
        public IActionResult AddBlogDetail(BlogDetail blogDetail, IFormFile ImageUrl, IFormFile ImageUrl2, IFormFile ImageUrl3, IFormFile ImageUrl4)
        {

            var uploadedImageUrl = FileUpload.UploadFile(ImageUrl);
            var uploadedImageUrl2 = FileUpload.UploadFile(ImageUrl2);
            var uploadedImageUrl3 = FileUpload.UploadFile(ImageUrl3);
            var uploadedImageUrl4 = FileUpload.UploadFile(ImageUrl4);
            blogDetail.ImageUrl = uploadedImageUrl;
            blogDetail.ImageUrl2 = uploadedImageUrl2;
            blogDetail.ImageUrl3 = uploadedImageUrl3;
           


            _blogDetailService.TAdd(blogDetail);

            return RedirectToAction("Index");
        }
    }
}
