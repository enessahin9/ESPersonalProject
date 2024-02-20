﻿using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
	public class AppDbContext : IdentityDbContext<AppUser, AppRole, int>
	{
		public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }
		public DbSet<About> Abouts { get; set; }
		public DbSet<Contact> Contacts { get; set; }
		public DbSet<Message> Messages { get; set; }
		public DbSet<Service> Services { get; set; }
		public DbSet<Skill> Skill { get; set; }
		public DbSet<SocialMedia> SocialMedias { get; set; }
		public DbSet<Portfolio> Works { get; set; }
		public DbSet<BlogCategory> BlogCategories { get; set; }
		public DbSet<BlogDetail> BlogDetails { get; set; }
		public DbSet<Resume> Resumes { get; set; }

	}
}
