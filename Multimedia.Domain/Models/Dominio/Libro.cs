using Multimedia.Domain.Models.Catalogo;

namespace Multimedia.Domain.Models.Dominio;

public class Libro : Contenido
{
    public string ISBN { get; set; } = string.Empty;
    public Editorial? Editorial { get; set; } 
    public Guid EditorialId { get; set; }
    public int NumeroPaginas { get; set; }
}