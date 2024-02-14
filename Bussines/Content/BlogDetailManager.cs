using Business.Service;
using DataLayers.Abstract;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Content;

public class BlogDetailManager : IGenericService<BlogDetail>, IBlogDetailService
{
	private readonly IBlogDetailDal _blogDetailDal;

	public BlogDetailManager(IBlogDetailDal blogDetailDal)
	{
		_blogDetailDal = blogDetailDal;
	}

	public void TAdd(BlogDetail t)
	{
		_blogDetailDal.Add(t);
	}

	public void TDelete(BlogDetail t)
	{
		_blogDetailDal.Delete(t);
	}

	public BlogDetail TGetById(int id)
	{
		return _blogDetailDal.GetById(id);
	}

	public List<BlogDetail> TGetList()
	{
		return _blogDetailDal.GetList();
	}

	public void TUpdate(BlogDetail t)
	{
		_blogDetailDal.Update(t);
	}
}
