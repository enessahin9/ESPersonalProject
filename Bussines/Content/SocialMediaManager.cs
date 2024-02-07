using Business.Service;
using DataLayer.Abstract;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Content;

public class SocialMediaManager : IGenericService<SocialMedia>, ISocialMediaService
{
	private readonly ISocialMediaDal _socialMediaDal;

	public SocialMediaManager(ISocialMediaDal socialMediaDal)
	{
		_socialMediaDal = socialMediaDal;
	}

	public void TAdd(SocialMedia t)
	{
		_socialMediaDal.Add(t);
	}

	public void TDelete(SocialMedia t)
	{
		_socialMediaDal.Delete(t);
	}

	public SocialMedia TGetById(int id)
	{
		return _socialMediaDal.GetById(id);
	}

	public List<SocialMedia> TGetList()
	{
		return _socialMediaDal.GetList();
	}

	public void TUpdate(SocialMedia t)
	{
		_socialMediaDal.Update(t);
	}
}
