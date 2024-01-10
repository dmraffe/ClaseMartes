using CRUD.ENTITY.Persistencia;
using CRUD.ENTITY.Servicio;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

builder.Services.AddDbContext<CrudDbContext>(option =>
    option.UseSqlServer(builder.Configuration.GetConnectionString("ConnectionString"))
   
);

builder.Services.AddScoped<IServicePersonacs, ServicioPersona>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
}
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Persona}/{action=Index}/{id?}");

app.Run();
