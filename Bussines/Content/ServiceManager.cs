using Business.Service;
using DataLayer.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Content;

public class ServiceManager : IGenericService<Models.Service>, IServiceService
{
	private IServiceDal _serviceDal;

	public ServiceManager(IServiceDal serviceDal)
	{
		_serviceDal = serviceDal;
	}

	public void TAdd(Models.Service t)
	{
		throw new NotImplementedException();
	}

	public void TDelete(Models.Service t)
	{
		throw new NotImplementedException();
	}

	public Models.Service TGetById(int id)
	{
		throw new NotImplementedException();
	}

	public List<Models.Service> TGetList()
	{
		return _serviceDal.GetList();
	}

	public void TUpdate(Models.Service t)
	{
		throw new NotImplementedException();
	}
}
