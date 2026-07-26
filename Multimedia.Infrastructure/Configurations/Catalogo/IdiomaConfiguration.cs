using Microsoft.EntityFrameworkCore;
using Multimedia.Domain.Models.Catalogo;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Multimedia.Infrastructure.Configurations.Catalogo;

public class IdiomaConfiguration : IEntityTypeConfiguration<Idioma>
{
    public void Configure(EntityTypeBuilder<Idioma> builder)
    {
        builder.ToTable("Idiomas", "Multimedia");

        builder.HasKey(c => c.IdiomaId);
        builder.Property(c => c.IdiomaId)
            .HasDefaultValueSql("NEWSEQUENTIALID()");

        builder.Property(c => c.Nombre)
            .IsRequired()
            .HasMaxLength(30);

        builder.Property(c => c.CodigoIso)
            .IsRequired()
            .HasMaxLength(100);

        builder.Property(c => c.EsActivo)
            .IsRequired()
            .HasDefaultValue(true);
    }
}