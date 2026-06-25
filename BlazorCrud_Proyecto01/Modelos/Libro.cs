using System.ComponentModel.DataAnnotations;

namespace BlazorCrud_Proyecto01.Modelos;

public class Libro
{
    [Key]
    public int Id { get; set; }

    [Required(ErrorMessage = "El título es obligatorio")]
    public string Titulo { get; set; }

    [Required(ErrorMessage = "La descripción es obligatoria")]
    public string Descripcion { get; set; }

    [Required(ErrorMessage = "El Autor es obligatorio")]
    public string Autor { get; set; }

    [Required(ErrorMessage = "El número de páginas es obligatorio")]
    public int Paginas { get; set; }

    [Required(ErrorMessage = "El precio es obligatorio")]
    public int Precio { get; set; }

    public DateTime FechaCreacion { get; set; }
}