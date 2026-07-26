using Multimedia.Domain.Models.Dominio;

namespace Multimedia.Domain.Models.Catalogo;

public class Editorial 
{ 
    public Guid EditorialId { get; set; } 
    public string Nombre { get; set; } = string.Empty; 
    public ICollection<Libro> Libros { get; set; } = new List<Libro>();
}