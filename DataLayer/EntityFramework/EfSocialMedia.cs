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
	public class EfSocialMedia : GenericRepository<SocialMedia>, ISocialMediaDal
	{
		public EfSocialMedia(AppDbContext appDbContext) : base(appDbContext)
		{
		}
	}
}
