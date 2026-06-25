using BlazorCrud_Proyecto01.Data;
using BlazorCrud_Proyecto01.Modelos;
using Microsoft.EntityFrameworkCore;

namespace BlazorCrud.Repositorio;

public class Repositorio : IRepositorio
{
    private readonly ApplicationDbContext _contexto;

    public Repositorio(ApplicationDbContext contexto)
    {
        _contexto = contexto;
    }

    public async Task<Libro> ActualizarLibro(int libroId, Libro actualizarLibro)
    {
        var LibroDesdeBd = await _contexto.Libro.FindAsync(libroId);
        LibroDesdeBd.Titulo = actualizarLibro.Titulo;
        LibroDesdeBd.Descripcion = actualizarLibro.Descripcion;
        LibroDesdeBd.Autor = actualizarLibro.Autor;
        LibroDesdeBd.Paginas = actualizarLibro.Paginas;
        LibroDesdeBd.Precio = actualizarLibro.Precio;
        await _contexto.SaveChangesAsync();
        return LibroDesdeBd;
    }

    public async Task<Libro> CrearLibro(Libro crearLibro)
    {
        if (crearLibro != null)
        {
            crearLibro.FechaCreacion = DateTime.Now;
            await _contexto.AddAsync(crearLibro);
            await _contexto.SaveChangesAsync();
            return crearLibro;
        }
        else { return new Libro(); }  // Para que retorne el formulario VACIO.
    }

    public async Task EliminarLibro(int libroId)
    {
        var LibrodesdeBd = await _contexto.Libro.FindAsync(libroId);
        _contexto.Remove(LibrodesdeBd);
        await _contexto.SaveChangesAsync();
    }

    public async Task<Libro> GetLibroId(int libroId)
    {
        var LibroDesdeBD = await _contexto.Libro.FindAsync(libroId);
        if (LibroDesdeBD == null)
        {
            return new Libro(); //Nueva instancia de Libro vacia
        }
        return LibroDesdeBD;
    }

    public Task<List<Libro>> GetLibros()
    {
        return _contexto.Libro.ToListAsync();
    }
}