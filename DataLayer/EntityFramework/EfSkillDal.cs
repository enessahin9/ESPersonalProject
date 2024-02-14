using DataLayer.Abstract;
using DataLayer.Repository;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.EntityFramework;

public class EfSkillDal : GenericRepository<Skill>, ISkillDal
{
	public EfSkillDal(AppDbContext appDbContext) : base(appDbContext)
	{
	}
}
