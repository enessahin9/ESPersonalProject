using DataLayer.Abstract;
using DataLayer.Repository;
using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.EntityFramework
{
	public class EfMessageDal : GenericRepository<Message>, IMessageDal
	{
		public EfMessageDal(AppDbContext appDbContext) : base(appDbContext)
		{
		}
	}
}
