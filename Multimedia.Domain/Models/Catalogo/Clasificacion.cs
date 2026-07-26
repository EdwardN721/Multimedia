namespace Multimedia.Domain.Models.Catalogo;

public class Clasificacion : CatalogoBase
{
    public Guid ClasificacionId { get; set; }
    public string? Descripcion { get; set; } = string.Empty;
}