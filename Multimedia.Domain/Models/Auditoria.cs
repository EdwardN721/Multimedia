namespace Multimedia.Domain.Models;

public class Auditoria
{
    public Guid AuditoriaId { get; set; }
    public string Tabla { get; set; } = string.Empty;
    public string Operacion { get; set; } = string.Empty;
    public string UsuarioDb { get; set; } = string.Empty;
    public DateTime FechaHora { get; set; }
    public string? ValorAnterior { get; set; }
    public string? ValorNuevo { get; set; }
}