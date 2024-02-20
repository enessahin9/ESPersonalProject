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

public class EfResumeDal : GenericRepository<Resume>, IResumeDal
{
	public EfResumeDal(AppDbContext appDbContext) : base(appDbContext)
	{
	}
}
