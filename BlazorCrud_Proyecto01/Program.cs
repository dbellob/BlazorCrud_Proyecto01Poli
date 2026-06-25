using BlazorCrud.Repositorio;
using BlazorCrud_Proyecto01.Data;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();
builder.Services.AddServerSideBlazor();

//Configurar conexión a MSSQLLocalDB
//builder.Services.AddDbContext<ApplicationDbContext>(
//    options => options.UseSqlServer(
//    builder.Configuration.GetConnectionString("ConexionSQLLocalDB")));

//Nuevo: ------------------
//builder.Services.AddDbContext<ApplicationDbContext>(
//    options => options.UseSqlServer(
//builder.Configuration.GetConnectionString("DefaultConnection")));
//

builder.Services.AddScoped<IRepositorio, Repositorio>();

var app = builder.Build();

using (var scope = app.Services.CreateScope())
{
    var dbContext = scope.ServiceProvider.GetRequiredService<ApplicationDbContext>();
    dbContext.Database.Migrate();
}

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();

//Nuevo: ------------------
app.UseAuthentication();
//
app.UseStaticFiles();

app.UseRouting();

app.MapBlazorHub();
app.MapFallbackToPage("/_Host");

app.Run();