using Multimedia.Domain.Interfaces;
using Multimedia.Domain.Models.Catalogo;

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
    public Guid? UsuarioActualizacionId { get; set; }
    
    public bool EsActivo { get; set; } = true;
    public DateTimeOffset FechaCreacion { get; set; }
    public DateTimeOffset? FechaModificacion { get; set; }

    public virtual TipoContenido? TipoContenido { get; set; }
    public virtual Genero? Genero { get; set; }
    public virtual Idioma? Idioma { get; set; }
    public virtual Clasificacion? Clasificacion { get; set; }
    public virtual Formato? Formato { get; set; }
    public virtual EstadoContenido? EstadoContenido { get; set; }
    
    public virtual Usuario? CreadoPorUsuario { get; set; }
    public virtual Usuario? UsuarioActualizacion { get; set; }
}