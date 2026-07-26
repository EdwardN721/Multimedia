using Multimedia.Domain.Interfaces;

namespace Multimedia.Domain.Models.Dominio;

public class Contenido : ISoftDeletable, IAuditable
{
    public Guid ContenidoId { get; set; }
    public Guid TipoContenidoId { get; set; }
    public string Titulo { get; set; } = string.Empty;
    public string? Descripcion { get; set; }
    public int Anio { get; set; }
    public DateOnly? FechaLanzamiento { get; set; }
    public Guid GeneroId { get; set; }
    public Guid IdiomaId { get; set; }
    public Guid ClasificacionId { get; set; }
    public Guid FormatoId { get; set; }
    public string? Portada { get; set; }
    public Guid EstadoContenidoId { get; set; }
    public Guid CreadoPorUsuarioId { get; set; }
    public bool EsActivo { get; set; } = true;
    public DateTimeOffset FechaCreacion { get; set; }
    public DateTimeOffset? FechaModificacion { get; set; }
    public Guid? UsuarioModificacionId { get; set; }
}