using Microsoft.AspNetCore.Mvc;

namespace ESPersonalProject.Controllers
{
    public class ErrorPageController : Controller
    {
        public IActionResult Error404()
        {
            return View();
        }
       
    }
}
