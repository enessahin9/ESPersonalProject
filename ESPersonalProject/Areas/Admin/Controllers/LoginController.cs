using ESPersonalProject.Areas.Admin.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Models;

namespace ESPersonalProject.Areas.Admin.Controllers
{
	[Area("Admin")]
	[AllowAnonymous]
	public class LoginController : Controller
	{
        private readonly SignInManager<AppUser> _signInManager;
        private readonly UserManager<AppUser> _userManager;

        public LoginController(SignInManager<AppUser> signInManager, UserManager<AppUser> userManager)
        {
            _signInManager = signInManager;
            _userManager = userManager;
        }

        public IActionResult Index()
		{
			return View();
		}
        [HttpPost]
        public async Task<IActionResult> Index(LoginViewModel a) 
        {
            if (ModelState.IsValid)
            {

                var result = await _signInManager.PasswordSignInAsync(a.UserName, a.Password, true, true);

                if (result.Succeeded)
                {
                    return RedirectToAction("Index", "About");
                }
                else
                {
                    ModelState.AddModelError("", "Hatalı Kullanıcı Adı veya Şifre Girdiniz.");
                }


            }
            return View();
        }

        [HttpGet]
        public IActionResult Register()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Register(RegisterViewModel p)
        {

            AppUser appUser = new AppUser()
            {
                Name = p.Name,
                Surname = p.Surname,
                Email = p.Email,
                UserName = p.UserName,

            };
            var result = await _userManager.CreateAsync(appUser, p.Password);
            if (result.Succeeded)
            {
                return RedirectToAction("Index", "Login");

            }
            else
            {
                foreach (var item in result.Errors)
                {

                    ModelState.AddModelError("", item.Description);

                }

            }

            return View(p);
        }
    }
}
