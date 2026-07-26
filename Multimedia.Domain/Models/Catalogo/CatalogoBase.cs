using Multimedia.Domain.Interfaces;

namespace Multimedia.Domain.Models.Catalogo;

public abstract class CatalogoBase : ISoftDeletable
{
    public string Nombre { get; set; } = string.Empty;
    public bool EsActivo { get; set; } = true;
}