using UserManagementApp.Data;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Register DbContext with SQL Server
builder.Services.AddDbContext<AppDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

// Add MVC support
builder.Services.AddControllersWithViews();

var app = builder.Build();

// Enable serving static files from wwwroot
app.UseStaticFiles();

// Enable routing
app.UseRouting();

// Optional: Add authorization middleware if needed
// app.UseAuthorization();

// Configure endpoint routing
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
