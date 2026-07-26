namespace Multimedia.Domain.Models.Dominio;

public class Videojuego : Contenido
{
    public Guid PlataformaId { get; set; }
    public bool EsMultijugador { get; set; }
}