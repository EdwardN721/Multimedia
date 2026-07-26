namespace Multimedia.Domain.Models.Catalogo;

public class Director 
{ 
    public Guid DirectorId { get; set; } 
    public string Nombre { get; set; } = string.Empty; 
    public string PrimerApellido { get; set; } = string.Empty;
    public string? SegundoApellido { get; set; } = string.Empty;
}