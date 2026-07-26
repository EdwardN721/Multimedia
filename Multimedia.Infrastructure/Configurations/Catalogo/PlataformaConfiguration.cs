using Microsoft.EntityFrameworkCore;
using Multimedia.Domain.Models.Catalogo;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Multimedia.Infrastructure.Configurations.Catalogo;

public class PlataformaConfiguration : IEntityTypeConfiguration<Plataforma>
{
    public void Configure(EntityTypeBuilder<Plataforma> builder)
    {
        builder.ToTable("Plataformas", "Multimedia");

        builder.HasKey(c => c.PlataformaId);
        builder.Property(c => c.PlataformaId)
            .HasDefaultValueSql("NEWSEQUENTIALID()");

        builder.Property(c => c.Nombre)
            .IsRequired()
            .HasMaxLength(30);
    }
}