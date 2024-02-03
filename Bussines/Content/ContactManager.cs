using Business.Service;
using DataLayer.Abstract;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Content
{
	public class ContactManager : IGenericService<Contact>, IContactService
	{
		private IContactDal _contactDal;

		public ContactManager(IContactDal contactDal)
		{
			_contactDal = contactDal;
		}

		public void TAdd(Contact t)
		{
			throw new NotImplementedException();
		}

		public void TDelete(Contact t)
		{
			throw new NotImplementedException();
		}

		public Contact TGetById(int id)
		{
			throw new NotImplementedException();
		}

		public List<Contact> TGetList()
		{
			return _contactDal.GetList();
		}

		public void TUpdate(Contact t)
		{
			throw new NotImplementedException();
		}
	}
}
