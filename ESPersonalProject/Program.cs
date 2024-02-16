using Bussines.Container;
using DataLayer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc.Authorization;
using Microsoft.EntityFrameworkCore;
using Models;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<AppDbContext>(options =>
options.UseSqlServer(builder.Configuration.GetConnectionString("constr")));

builder.Services.AddIdentity<AppUser, AppRole>().AddEntityFrameworkStores<AppDbContext>();



builder.Services.AddMvc(config =>
{
	var policy = new AuthorizationPolicyBuilder().RequireAuthenticatedUser().Build();
	config.Filters.Add(new AuthorizeFilter(policy));


});

builder.Services.ConfigureApplicationCookie(options =>
{
	options.LoginPath = "/Admin/Login/Index";

});


// Add services to the container.
builder.Services.AddControllersWithViews();
ExtensionsDb.ContainerDependencies(builder.Services);
var app = builder.Build();


// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
	app.UseExceptionHandler("/Home/Error");
}
app.UseStaticFiles();

app.UseRouting();
//Login  için eklendi
app.UseAuthentication();

app.UseAuthorization();

app.MapControllerRoute(
	name: "areas",
	pattern: "{area}/{controller=Home}/{action=Index}/{id?}"
	);

app.MapControllerRoute(
	name: "default",
	pattern: "{controller=Default}/{action=Index}/{id?}");

app.Run();
