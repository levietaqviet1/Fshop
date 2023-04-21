using FA.JustBlog.Core.DataContext;
using FA.JustBlog.Core.Models;
using FA.JustBlog.Service.category;
using FA.JustBlog.Service.comment;
using FA.JustBlog.Service.map;
using FA.JustBlog.Service.post;
using FA.JustBlog.Service.tag;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

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
builder.Services.AddAutoMapper(typeof(MapperConfig));

builder.Services.AddScoped<IPostService, PostService>();
builder.Services.AddScoped<ITagService, TagService>();
builder.Services.AddScoped<ICategoryService, CategoryService>();
builder.Services.AddScoped<ICommentService, CommentService>();

builder.Services.AddScoped<ICommentService, CommentService>();

//cau hinh ConfigureServices

builder.Services.AddSingleton<IConfiguration>(builder.Configuration);

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
