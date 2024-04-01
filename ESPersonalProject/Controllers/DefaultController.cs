using Business.Service;
using ESPersonalProject.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using MimeKit;
using Models;

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
	public IActionResult SendMessage(ContactViewModel contact)
	{
		if (ModelState.IsValid)
		{
			var message = new MimeMessage();
			message.From.Add(new MailboxAddress("Sitemden Gelen Mesaj", "sahinnn210@gmail.com"));
			message.To.Add(new MailboxAddress("Alıcı Adı", "enessahin9@outlook.com"));
			message.Subject = contact.Subject;
			message.Body = new TextPart("plain")
			{
				Text = "Name: " + contact.Name + "\n" + "Email: " + contact.Email + "\n" + "Subject: " + contact.Subject + "\n" + "Body: " + contact.Body
			};

			using (var client = new MailKit.Net.Smtp.SmtpClient())
			{
				client.Connect("smtp.gmail.com", 587, false);
				client.Authenticate("sahinnn210@gmail.com", "gmuzolkvvymcngbw");
				client.Send(message);
				client.Disconnect(true);
			};

			return RedirectToAction("Index");
		}
		return View();
	}
}
