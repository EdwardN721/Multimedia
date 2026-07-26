using Multimedia.Domain.Interfaces;
using Multimedia.Domain.Models.Dominio;

namespace Multimedia.Domain.Models;

public class Biblioteca : ISoftDeletable
{
    public Guid BibliotecaId { get; set; }
    public Guid UsuarioId { get; set; }
    public Guid ContenidoId { get; set; }
    public DateTime FechaAgregado { get; set; }
    public bool EsFavorito { get; set; }
    public string? Observaciones { get; set; }
    public bool EsActivo { get; set; } = true;

    public Usuario Usuario { get; set; } = null!;
    public Contenido Contenido { get; set; } = null!;
}