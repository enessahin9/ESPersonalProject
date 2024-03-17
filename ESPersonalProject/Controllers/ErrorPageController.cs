using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace ESPersonalProject.Controllers;
public class ErrorPageController : Controller
{
    [AllowAnonymous]
    public IActionResult Error404()
    {
        return View();
    }
   
}
