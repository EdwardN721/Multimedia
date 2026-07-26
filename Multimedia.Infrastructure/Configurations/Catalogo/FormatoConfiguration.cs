using Microsoft.EntityFrameworkCore;
using Multimedia.Domain.Models.Catalogo;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Multimedia.Infrastructure.Configurations.Catalogo;

public class FormatoConfiguration : IEntityTypeConfiguration<Formato>
{
    public void Configure(EntityTypeBuilder<Formato> builder)
    {
        builder.ToTable("Formatos", "Multimedia");

        builder.HasKey(c => c.FormatoId);
        builder.Property(c => c.FormatoId)
            .HasDefaultValueSql("NEWSEQUENTIALID()");

        builder.Property(c => c.Nombre)
            .IsRequired()
            .HasMaxLength(30);

        builder.Property(c => c.EsActivo)
            .IsRequired()
            .HasDefaultValue(true);
    }
}