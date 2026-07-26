namespace Multimedia.Domain.Interfaces;

public interface IAuditable
{
    DateTimeOffset FechaCreacion { get; set; }
    DateTimeOffset? FechaModificacion { get; set; }
}