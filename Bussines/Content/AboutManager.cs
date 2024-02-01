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
	public class AboutManager : IGenericService<About>, IAboutService
	{
		private readonly IAboutDal _aboutDal;

		public AboutManager(IAboutDal aboutDal)
		{
			_aboutDal = aboutDal;
		}

		public void TAdd(About t)
		{
			_aboutDal.Add(t);
		}

		public void TDelete(About t)
		{
			_aboutDal.Delete(t);
		}

		public About TGetById(int id)
		{
			return _aboutDal.GetById(id);
		}

		public List<About> TGetList()
		{
			return _aboutDal.GetList();
		}

		public void TUpdate(About t)
		{
			_aboutDal.Update(t);
		}
	}
}
