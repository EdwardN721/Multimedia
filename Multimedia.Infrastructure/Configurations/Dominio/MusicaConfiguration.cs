using Microsoft.EntityFrameworkCore;
using Multimedia.Domain.Models.Dominio;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Multimedia.Infrastructure.Configurations.Dominio;

public class MusicaConfiguration : IEntityTypeConfiguration<Musica>
{
    public void Configure(EntityTypeBuilder<Musica> builder)
    {
        builder.ToTable("Musica", "Multimedia", m => m.HasCheckConstraint("CK_Musica_Duracion", "\"DuracionMinutos\" > 0"));

        // No es necesario re-configurar la llave primaria (ContenidoId)

        builder.Property(m => m.ArtistaId)
        .IsRequired();
        
        builder.Property(m => m.Album)
            .HasMaxLength(150);
        
        builder.Property(m => m.DuracionMinutos)
            .IsRequired();

        builder.HasOne(m => m.Artista)        // La música tiene UN artista
            .WithMany(a => a.Albumes)         // Ese artista tiene MUCHOS álbumes
            .HasForeignKey(m => m.ArtistaId)  // La llave foránea es ArtistaId
            .OnDelete(DeleteBehavior.Restrict);
    }
}