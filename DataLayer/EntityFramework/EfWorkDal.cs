using DataLayer.Abstract;
using DataLayer.Repository;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.EntityFramework;

public class EfWorkDal : GenericRepository<Portfolio>, IWorkDal
{
	public EfWorkDal(AppDbContext appDbContext) : base(appDbContext)
	{
	}
}
