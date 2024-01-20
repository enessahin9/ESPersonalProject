﻿using DataLayer.Abstract;
using DataLayer.Repository;
using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.EntityFramework
{
	internal class EfWorkDal : GenericRepository<Work>, IWorkDal
	{
		public EfWorkDal(AppDbContext appDbContext) : base(appDbContext)
		{
		}
	}
}
