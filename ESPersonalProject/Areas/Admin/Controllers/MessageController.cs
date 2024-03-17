using Business.Service;
using Microsoft.AspNetCore.Mvc;
using Models;
using System.Drawing;
using static System.Net.Mime.MediaTypeNames;

namespace ESPersonalProject.Areas.Admin.Controllers;

[Area("Admin")]
public class MessageController : Controller
{
	private readonly IMessageService _messageService;

	public MessageController(IMessageService messageService)
	{
		_messageService = messageService;
	}

	public IActionResult Index()
	{
		var values = _messageService.TGetList();
		return View();
	}

	[HttpGet]
	public IActionResult GetAll()
	{
		return Json(_messageService.TGetList());
	}

	[HttpGet]
	public IActionResult MessageAdd()
	{
		return View();
	}

	[HttpPost]
	public IActionResult MessageAdd(Message message)
	{
		_messageService.TAdd(message);
		return Ok();
	}

	public IActionResult MessageUpdate()
	{
		return View();
	}


	public IActionResult MessageDelete(int id)
	{
		var values = _messageService.TGetById(id);
		_messageService.TDelete(values);
		return Ok();
	}
}

