using Business.Content;
using Business.Service;
using DataLayer.Abstract;
using DataLayer.EntityFramework;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
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

			services.AddScoped<IServiceService, ServiceManager>();
			services.AddScoped<IServiceDal, EfServiceDal>();

			services.AddScoped<IWorkDal, EfWorkDal>(); // Portfolio
			services.AddScoped<IWorkService, WorkManager>();// Portfolio

			services.AddScoped<IContactDal, EfContactDal>();
			services.AddScoped<IContactService, ContactManager>();

			services.AddScoped<IMessageDal, EfMessageDal>();
			services.AddScoped<IMessageService, MessageManager>();

			services.AddScoped<ISkillDal, EfSkillDal>();
			services.AddScoped<ISkillService, SkillManager>();

			services.AddScoped<ISocialMediaDal, EfSocialMediaDal>();
			services.AddScoped<ISocialMediaService, SocialMediaManager>();
		}
	}
}
