using Microsoft.EntityFrameworkCore;
using Multimedia.Domain.Models.Catalogo;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Multimedia.Infrastructure.Configurations.Catalogo;

public class TipoContenidoConfiguration : IEntityTypeConfiguration<TipoContenido>
{
    public void Configure(EntityTypeBuilder<TipoContenido> builder)
    {
        builder.ToTable("TiposContenidos", "Multimedia");

        builder.HasKey(c => c.TipoContenidoId);
        builder.Property(c => c.TipoContenidoId)
            .HasDefaultValueSql("NEWSEQUENTIALID()");

        builder.Property(c => c.Nombre)
            .IsRequired()
            .HasMaxLength(30);

        builder.Property(c => c.EsActivo)
            .IsRequired()
            .HasDefaultValue(true);
    }
}