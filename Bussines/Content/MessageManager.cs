using Business.Service;
using DataLayer.Abstract;
using DataLayer.EntityFramework;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Content;

public class MessageManager : IGenericService<Message>, IMessageService
{
	private readonly IMessageDal _messageDal;

	public MessageManager(IMessageDal messageDal)
	{
		_messageDal = messageDal;
	}

	public void TAdd(Message t)
	{
		_messageDal.Add(t);
	}

	public void TDelete(Message t)
	{
		throw new NotImplementedException();
	}

	public Message TGetById(int id)
	{
		throw new NotImplementedException();
	}

	public List<Message> TGetList()
	{
		return _messageDal.GetList();
	}

	public void TUpdate(Message t)
	{
		throw new NotImplementedException();
	}
}
