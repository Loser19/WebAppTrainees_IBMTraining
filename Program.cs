using Microsoft.EntityFrameworkCore;
using WebAppTrainees.Models;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();
//builder.Services.AddDbContext<TraineeContext>(options =>options.UseSqlServer(builder.Configuration.GetConnectionString("TraineeContext")));
//builder.Services.AddDbContext<TraineeContext>(opt => opt.UseSqlServer());
builder.Services.AddDbContext<TraineeContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("TraineeConnection")));
builder.Services.AddMvc();
var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();
app.UseRouting();

app.UseAuthorization();

//Configuring the Route, Thsi is the deafult route for Home Controller
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
