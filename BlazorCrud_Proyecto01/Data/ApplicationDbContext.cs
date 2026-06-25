using BlazorCrud_Proyecto01.Modelos;
using Microsoft.EntityFrameworkCore;

namespace BlazorCrud_Proyecto01.Data;

public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
    {
    }

    //Colocamos cada uno de los modelos
    public DbSet<Libro> Libro { get; set; }
}