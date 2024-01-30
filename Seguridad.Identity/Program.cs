using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Seguridad.Identity.DbContext;
using Seguridad.Identity.Models;
using System.Security.Claims;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();


builder.Services.AddDbContext<AuthenticationContext>(options =>options.UseSqlServer(@"Data Source=localhost\SQLEXPRESS;Database=Seguridad;Trusted_Connection=True;TrustServerCertificate=True;"));
builder.Services.AddIdentity<Usuario, IdentityRole>().AddEntityFrameworkStores<AuthenticationContext>();
builder.Services.AddAuthorization(options =>
{
    options.AddPolicy("RequireEmail", policy =>
    policy.RequireClaim(ClaimTypes.Email));
});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Auth}/{action=Registro}/{id?}");

app.Run();


  async void CreateRoles(RoleManager<IdentityRole> roleManager)
{
    string[] roleNames = { "Administrator", "Manager", "User" };
    foreach (var roleName in roleNames)
    {
        bool roleExists = await roleManager.RoleExistsAsync(roleName);
        if (!roleExists)
        {
            IdentityRole role = new IdentityRole();
            role.Name = roleName;
            await roleManager.CreateAsync(role);
        }
    }
}

