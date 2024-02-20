using Business.Service;
using DataLayers.Abstract;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Content;

public class ResumeManager : IGenericService<Resume>, IResumeService
{
	private readonly IResumeDal _resumeDal;

	public ResumeManager(IResumeDal resumeDal)
	{
		_resumeDal = resumeDal;
	}

	public void TAdd(Resume t)
	{
		_resumeDal.Add(t);
	}

	public void TDelete(Resume t)
	{
		_resumeDal.Delete(t);
	}

	public Resume TGetById(int id)
	{
		return _resumeDal.GetById(id);
	}

	public List<Resume> TGetList()
	{
		return _resumeDal.GetList();
	}

	public void TUpdate(Resume t)
	{
		_resumeDal.Update(t);
	}
}
