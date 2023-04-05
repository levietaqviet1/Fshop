using FA.JustBlog.Core.DataContext;
using FA.JustBlog.Core.Models;
using FA.JustBlog.Core.Repositories;
using FA.JustBlog.Core.Repositories.Impl;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

/* nhap
// Add services to the container.
// Load configuration from appsettings.json of Object B
var configBuilder = new ConfigurationBuilder()
    .SetBasePath(builder.Environment.ContentRootPath)
    .AddJsonFile("..\\FA.JustBlog.Core\\appsettings.json", optional: true, reloadOnChange: true);
var configuration = configBuilder.Build();

builder.Services.AddDbContext<JustBlogContext>(options =>
{
    // Use the "MyCnn" connection string from Object B's appsettings.json
    var connectionString = configuration.GetConnectionString("MyCnn");
    options.UseSqlServer(connectionString);
});

*/


// Add services to the container.
var connectionString = builder.Configuration.GetConnectionString("MyCnn");
builder.Services.AddDbContext<JustBlogContext>(options =>
    options.UseSqlServer(connectionString));

builder.Services.AddDatabaseDeveloperPageExceptionFilter();

// RequireConfirmedAccount ko can Confirmed
builder.Services.AddDefaultIdentity<UsingIdentityUser>(options => options.SignIn.RequireConfirmedAccount = false)
    .AddRoles<IdentityRole>().AddEntityFrameworkStores<JustBlogContext>();

builder.Services.AddControllersWithViews();
// cau hinh identity
builder.Services.AddRazorPages();

builder.Services.AddScoped<IPostRepository, PostRepository>();



var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseMigrationsEndPoint();
}
else
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}


app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthentication();
app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.UseEndpoints(endpoints =>
{
    endpoints.MapControllerRoute(
      name: "areas",
      pattern: "{area:exists}/{controller=Home}/{action=Index}/{id?}"

    );

});
app.MapRazorPages();

app.Run();
