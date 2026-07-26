using Microsoft.EntityFrameworkCore;
using Multimedia.Domain.Models.Catalogo;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Multimedia.Infrastructure.Configurations.Catalogo;

public class RolConfiguration : IEntityTypeConfiguration<Rol>
{
    public void Configure(EntityTypeBuilder<Rol> builder)
    {
        builder.ToTable("Rol", "Multimedia");

        builder.HasKey(c => c.RolId);
        builder.Property(c => c.RolId)
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