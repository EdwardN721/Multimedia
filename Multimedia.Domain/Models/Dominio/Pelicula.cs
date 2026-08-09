using Multimedia.Domain.Models.Catalogo;

namespace Multimedia.Domain.Models.Dominio;

public class Pelicula : Contenido
{
    public Guid DirectorId { get; set; }
    public int DuracionMinutos { get; set; }

    public virtual Director? Director { get; set; } 
    public virtual ICollection<Idioma> Idiomas { get; set; } = new List<Idioma>();    
}