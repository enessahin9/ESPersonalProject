using Bussines.Content;
using Bussines.Service;
using DataLayer.Abstract;
using DataLayer.EntityFramework;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bussines.Container
{
	public class ExtensionsDb
	{
		public static void ContainerDependencies(IServiceCollection services)
		{
			services.AddScoped<IAboutService, AboutManager>();
			services.AddScoped<IAboutDal, EfAboutDal>();
		}
	}
}
