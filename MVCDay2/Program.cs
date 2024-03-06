using Microsoft.EntityFrameworkCore;
using MVCDay2.Models;
using MVCDay2.Repository;

var builder = WebApplication.CreateBuilder(args);
//adding
builder.Services.AddDbContext<MyContext>(options => { options.UseSqlServer(builder.Configuration.GetConnectionString("mine"));});

// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.AddSession(options =>
{
    options.IdleTimeout = TimeSpan.FromMinutes(30);
});
//adding
builder.Services.AddScoped<IInstractorRepos,InstractorRepos>();
builder.Services.AddScoped<IDepartmentRepos,DepartmentRepos>();
builder.Services.AddScoped<ICourseRepos,CourseRepos>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
}
app.UseStaticFiles();

app.UseRouting();

app.UseSession();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
