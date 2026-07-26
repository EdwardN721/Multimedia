using Microsoft.EntityFrameworkCore;
using Multimedia.Domain.Models.Dominio;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Multimedia.Infrastructure.Configurations.Dominio;

public class ContenidoConfiguration : IEntityTypeConfiguration<Contenido>
{
    public void Configure(EntityTypeBuilder<Contenido> builder)
    {
        builder.ToTable("Contenido", "Multimedia");

        builder.HasKey(c => c.ContenidoId);
        builder.Property(c => c.ContenidoId).HasDefaultValueSql("NEWSEQUENTIALID()");

        builder.Property(c => c.Titulo).IsRequired().HasMaxLength(200);
        builder.Property(c => c.Portada).HasMaxLength(255);
        
        builder.Property(c => c.EsActivo).HasDefaultValue(true);
        builder.Property(c => c.FechaCreacion).HasDefaultValueSql("SYSDATETIME()");

        builder.HasIndex(c => c.Titulo);
        builder.HasQueryFilter(c => c.EsActivo);
    }
}