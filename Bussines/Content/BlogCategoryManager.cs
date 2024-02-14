using Business.Service;
using DataLayers.Abstract;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Content;

public class BlogCategoryManager : IGenericService<BlogCategory>, IBlogCategoryService
{
	private readonly IBlogCategoryDal _blogCategoryDal;

	public BlogCategoryManager(IBlogCategoryDal blogCategoryDal)
	{
		_blogCategoryDal = blogCategoryDal;
	}

	public void TAdd(BlogCategory t)
	{
		_blogCategoryDal.Add(t);
	}

	public void TDelete(BlogCategory t)
	{
		_blogCategoryDal.Delete(t);
	}

	public BlogCategory TGetById(int id)
	{
		return _blogCategoryDal.GetById(id);
	}

	public List<BlogCategory> TGetList()
	{
		return _blogCategoryDal.GetList();
	}

	public void TUpdate(BlogCategory t)
	{
		_blogCategoryDal.Update(t);
	}
}
