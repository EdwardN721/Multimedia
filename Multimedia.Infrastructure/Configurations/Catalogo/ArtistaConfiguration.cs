using Microsoft.EntityFrameworkCore;
using Multimedia.Domain.Models.Catalogo;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Multimedia.Infrastructure.Configurations.Catalogo;

public class ArtistaConfiguration : IEntityTypeConfiguration<Artista>
{
    public void Configure(EntityTypeBuilder<Artista> builder)
    {
        builder.ToTable("Artistas", "Multimedia");

        builder.HasKey(c => c.ArtistaId);
        builder.Property(c => c.ArtistaId)
            .HasDefaultValueSql("NEWSEQUENTIALID()");

        builder.Property(c => c.Nombre)
            .IsRequired()
            .HasMaxLength(30);

        builder.Property(c => c.PrimerApellido)
            .IsRequired()
            .HasMaxLength(30);

        builder.Property(c => c.SegundoApellido)
            .HasMaxLength(30)
            .HasDefaultValue("");
    }
}
