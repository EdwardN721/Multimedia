using Microsoft.EntityFrameworkCore;
using Multimedia.Domain.Models.Dominio;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Multimedia.Infrastructure.Configurations.Dominio;

public class MusicaConfiguration : IEntityTypeConfiguration<Musica>
{
    public void Configure(EntityTypeBuilder<Musica> builder)
    {
        builder.ToTable("Musica", "Multimedia");

        // No es necesario re-configurar la llave primaria (ContenidoId)

        builder.Property(m => m.ArtistaId)
        .IsRequired();
        
        builder.Property(m => m.Album)
            .HasMaxLength(100);
        
        builder.Property(m => m.DuracionMinutos)
            .IsRequired();
    }
}