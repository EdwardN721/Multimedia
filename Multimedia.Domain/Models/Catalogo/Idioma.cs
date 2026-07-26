namespace Multimedia.Domain.Models.Catalogo;

public class Idioma : CatalogoBase
{
    public Guid IdiomaId { get; set; }
    public string CodigoIso { get; set; } = string.Empty;
}