using Business.Service;
using DataLayer.Abstract;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Content;

public class WorkManager : IGenericService<Portfolio>, IWorkService
{
	private IWorkDal _workDal;

	public WorkManager(IWorkDal workDal)
	{
		_workDal = workDal;
	}

	public void TAdd(Portfolio t)
	{
		_workDal.Add(t);
	}

	public void TDelete(Portfolio t)
	{
		_workDal.Delete(t);
	}

	public Portfolio TGetById(int id)
	{
		return _workDal.GetById(id);
	}

	public List<Portfolio> TGetList()
	{
		return _workDal.GetList();
	}

	public void TUpdate(Portfolio t)
	{
		_workDal.Update(t);
	}
}
