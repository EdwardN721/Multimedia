using Multimedia.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Multimedia.Infrastructure.Configurations;

public class BibliotecaConfiguration : IEntityTypeConfiguration<Biblioteca>
{
    public void Configure(EntityTypeBuilder<Biblioteca> builder)
    {
        builder.ToTable("Biblioteca", "Multimedia");

        builder.HasKey(b => b.BibliotecaId);
        builder.Property(b => b.BibliotecaId)
            .HasDefaultValueSql("NEWSEQUENTIALID()");

        builder.Property(b => b.Observaciones)
            .HasMaxLength(500);
        
        builder.Property(b => b.FechaAgregado)
            .HasDefaultValueSql("SYSDATETIME()");
        builder.Property(b => b.EsFavorito)
            .HasDefaultValue(false);
        builder.Property(b => b.EsActivo)
            .HasDefaultValue(true);

        // Constraint Unique para evitar que un usuario agregue dos veces el mismo contenido
        builder.HasIndex(b => new { b.UsuarioId, b.ContenidoId }).IsUnique();
        
        builder.HasQueryFilter(b => b.EsActivo);
    }
}