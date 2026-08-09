using Multimedia.Domain.Interfaces;
using Multimedia.Domain.Models.Catalogo;

namespace Multimedia.Domain.Models;

public class Usuario : ISoftDeletable, IAuditable
{
    public Guid UsuarioId { get; set; }
    public string Nombre { get; set; } = string.Empty;
    public string Apellidos { get; set; } = string.Empty;
    public string Correo { get; set; } = string.Empty;
    public byte[] PasswordHash { get; set; } = null!;
    public Guid RolId { get; set; } 
    public bool EsActivo { get; set; } = true;
    public DateTimeOffset FechaCreacion { get; set; }
    public DateTimeOffset? FechaModificacion { get; set; }

    public Rol Rol { get; set; } = null!;
}