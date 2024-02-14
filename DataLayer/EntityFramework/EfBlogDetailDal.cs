using DataLayer;
using DataLayer.Repository;
using DataLayers.Abstract;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayers.EntityFramework;

public class EfBlogDetailDal : GenericRepository<BlogDetail>, IBlogDetailDal
{
	public EfBlogDetailDal(AppDbContext appDbContext) : base(appDbContext)
	{
	}
}
