namespace Multimedia.Domain.Models.Catalogo;

public class Rol : CatalogoBase
{
    public Guid RolId { get; set; }
    public string? Descripcion { get; set; } = string.Empty;

    public ICollection<Usuario> Usuarios { get; set; } = new List<Usuario>();
}
