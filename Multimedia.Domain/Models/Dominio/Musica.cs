using Multimedia.Domain.Models.Catalogo;

namespace Multimedia.Domain.Models.Dominio;

public class Musica : Contenido
{
    public Guid ArtistaId { get; set; }
    public virtual Artista? Artista { get; set; }
    public string? Album { get; set; }
    public int DuracionMinutos { get; set; }
}