using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using InventarioFarmacia.Repositories; // Mis repositorios

var builder = WebApplication.CreateBuilder(args);

// 1. Registro de repositorio
builder.Services.AddControllersWithViews();
builder.Services.AddScoped<IMedicamentoRepository, MedicamentoRepository>();

var app = builder.Build();

// 2. Config... la tubería de peticiones HTTP
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

// 3. Definir la ruta por defecto
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Medicamentos}/{action=Index}/{id?}");

app.Run();
