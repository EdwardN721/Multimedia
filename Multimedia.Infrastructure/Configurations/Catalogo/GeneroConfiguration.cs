using Microsoft.EntityFrameworkCore;
using Multimedia.Domain.Models.Catalogo;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Multimedia.Infrastructure.Configurations.Catalogo;

public class GeneroConfiguration : IEntityTypeConfiguration<Genero>
{
    public void Configure(EntityTypeBuilder<Genero> builder)
    {
        builder.ToTable("Generos", "Multimedia");

        builder.HasKey(c => c.GeneroId);
        builder.Property(c => c.GeneroId)
            .HasDefaultValueSql("NEWSEQUENTIALID()");

        builder.Property(c => c.Nombre)
            .IsRequired()
            .HasMaxLength(30);
        
        builder.Property(c => c.EsActivo)
            .IsRequired()
            .HasDefaultValue(true);
    }
}