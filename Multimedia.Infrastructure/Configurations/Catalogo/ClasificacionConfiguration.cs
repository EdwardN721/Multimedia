using Microsoft.EntityFrameworkCore;
using Multimedia.Domain.Models.Catalogo;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Multimedia.Infrastructure.Configurations.Catalogo;

public class ClasificacionConfiguration : IEntityTypeConfiguration<Clasificacion>
{
    public void Configure(EntityTypeBuilder<Clasificacion> builder)
    {
        builder.ToTable("Clasificacion", "Multimedia");

        builder.HasKey(c => c.ClasificacionId);
        builder.Property(c => c.ClasificacionId)
            .HasDefaultValueSql("NEWSEQUENTIALID()");

        builder.Property(c => c.Nombre)
            .IsRequired()
            .HasMaxLength(30);

        builder.Property(c => c.Descripcion)
            .HasMaxLength(100);

        builder.Property(c => c.EsActivo)
            .IsRequired()
            .HasDefaultValue(true);

        builder.HasIndex(c => c.Nombre)
            .IsUnique();
    }
}