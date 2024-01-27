using DataLayer.Abstract;
using DataLayer.Repository;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.EntityFramework
{
	public class EfServiceDal : GenericRepository<Service>, IServiceDal
	{
		public EfServiceDal(AppDbContext appDbContext) : base(appDbContext)
		{
		}
	}
}
