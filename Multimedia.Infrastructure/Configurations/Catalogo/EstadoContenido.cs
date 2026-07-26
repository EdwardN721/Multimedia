using Microsoft.EntityFrameworkCore;
using Multimedia.Domain.Models.Catalogo;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Multimedia.Infrastructure.Configurations.Catalogo;

public class EstadoContenidoConfiguration : IEntityTypeConfiguration<EstadoContenido>
{
    public void Configure(EntityTypeBuilder<EstadoContenido> builder)
    {
        builder.ToTable("EstadoContenido", "Multimedia");

        builder.HasKey(c => c.EstadoContenidoId);
        builder.Property(c => c.EstadoContenidoId)
            .HasDefaultValueSql("NEWSEQUENTIALID()");

        builder.Property(c => c.Nombre)
            .IsRequired()
            .HasMaxLength(30);

        builder.Property(c => c.EsActivo)
            .IsRequired()
            .HasDefaultValue(true);

        builder.HasIndex(c => c.Nombre)
            .IsUnique();
    }
}