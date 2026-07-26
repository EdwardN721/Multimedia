namespace Multimedia.Domain.Models.Catalogo;

public class Artista
{ 
    public Guid ArtistaId { get; set; } 
    public string Nombre { get; set; } = string.Empty;
    public string PrimerApellido { get; set; } = string.Empty;
    public string? SegundoApellido { get; set; } = string.Empty;
}