using Business.Service;
using ESPersonalProject.Models;
using Microsoft.AspNetCore.Mvc;

namespace ESPersonalProject.ViewComponent.Contact;

public class ContactList : Microsoft.AspNetCore.Mvc.ViewComponent
{
	private readonly IContactService _contactService;

	public ContactList(IContactService contactService)
	{
		_contactService = contactService;
	}

	public IViewComponentResult Invoke()
	{
		var values = _contactService.TGetList();
		return View(values);
	}
}