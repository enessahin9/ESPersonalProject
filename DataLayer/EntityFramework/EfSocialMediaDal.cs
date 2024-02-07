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
	public class EfSocialMediaDal : GenericRepository<SocialMedia>, ISocialMediaDal
	{
		public EfSocialMediaDal(AppDbContext appDbContext) : base(appDbContext)
		{
		}
	}
}
