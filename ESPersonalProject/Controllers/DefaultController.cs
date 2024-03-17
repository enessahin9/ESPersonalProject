using Business.Service;
using ESPersonalProject.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using MimeKit;

namespace ESPersonalProject.Controllers;
[AllowAnonymous] //Loginden etkilenme 
public class DefaultController : Controller
{
	private readonly IBlogDetailService _blogDetailService;
	private readonly IMessageService _messageService;

	public DefaultController(IBlogDetailService blogDetailService, IMessageService messageService)
	{
		_blogDetailService = blogDetailService;
		_messageService = messageService;
	}

	public IActionResult Index()
	{
		return View();
	}

	public PartialViewResult HeadPartial()
	{
		return PartialView();
	}

	public PartialViewResult FooterPartial()
	{
		return PartialView();
	}
	public PartialViewResult LoaderPartial()
	{
		return PartialView();
	}
	public PartialViewResult MenuPartial()
	{
		return PartialView();
	}
	[HttpGet]
	public IActionResult SendMessage()
	{
		return View();
	}
	[HttpPost]
	public IActionResult Index(ContactView contactView)
	{
		if (ModelState.IsValid)
		{
			var message = new MimeMessage();
			message.From.Add(new MailboxAddress("Kullanıcı", "enessahin9@outlook.com"));
			message.To.Add(new MailboxAddress("Alıcı Adı", "enessahin9@outlook.com"));
			message.Subject = contactView.Subject();

		}
	}
}
