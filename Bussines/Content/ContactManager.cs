using Business.Service;
using DataLayer.Abstract;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Content;

public class ContactManager : IGenericService<Contact>, IContactService
{
	private IContactDal _contactDal;

	public ContactManager(IContactDal contactDal)
	{
		_contactDal = contactDal;
	}

	public void TAdd(Contact t)
	{
		_contactDal.Add(t);
	}

	public void TDelete(Contact t)
	{
		_contactDal.Delete(t);
	}

	public Contact TGetById(int id)
	{
		return _contactDal.GetById(id);
	}

	public List<Contact> TGetList()
	{
		return _contactDal.GetList();
	}

	public void TUpdate(Contact t)
	{
		_contactDal.Update(t);
	}
}
