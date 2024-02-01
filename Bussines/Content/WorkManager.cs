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
	public class WorkManager : IGenericService<Portfolio>, IWorkService
	{
		private IWorkDal _workDal;

		public WorkManager(IWorkDal workDal)
		{
			_workDal = workDal;
		}

		public void TAdd(Portfolio t)
		{
			throw new NotImplementedException();
		}

		public void TDelete(Portfolio t)
		{
			throw new NotImplementedException();
		}

		public Portfolio TGetById(int id)
		{
			throw new NotImplementedException();
		}

		public List<Portfolio> TGetList()
		{
			return _workDal.GetList();
		}

		public void TUpdate(Portfolio t)
		{
			throw new NotImplementedException();
		}
	}
}
