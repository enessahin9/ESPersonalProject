using Business.Service;
using Microsoft.AspNetCore.Mvc;
using Models;
using System.Net;



namespace ESPersonalProject.Areas.Admin.Controllers;
[Area("Admin")]
public class ContactController : Controller
{
	private readonly IContactService _contactService;

	public ContactController(IContactService contactService)
	{
		_contactService = contactService;
	}

	public IActionResult Index()
	{
		return View();
	}
	// Default olarak 'HttpGet' request islemi calisir.
	public IActionResult GetAll()
	{
		return Json(_contactService.TGetList());
	}

	[HttpGet]
	public IActionResult ContactAdd()
	{
		return View();
	}

	[HttpPost]
	public IActionResult ContactAdd(Contact contact)
	{
		_contactService.TAdd(contact);
		return Ok();
	}

	[HttpPost]
	public IActionResult ContactDelete(int id)
	{
		var result = _contactService.TGetById(id);
		_contactService.TDelete(result);
		return Ok();
	}
}


