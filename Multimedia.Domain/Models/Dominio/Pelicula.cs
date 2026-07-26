namespace Multimedia.Domain.Models.Dominio;

public class Pelicula : Contenido
{
    public Guid DirectorId { get; set; }
    public int DuracionMinutos { get; set; }
}