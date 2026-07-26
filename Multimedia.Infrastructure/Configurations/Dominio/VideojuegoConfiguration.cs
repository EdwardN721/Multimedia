using Microsoft.EntityFrameworkCore;
using Multimedia.Domain.Models.Dominio;
using Multimedia.Domain.Models.Catalogo;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Multimedia.Infrastructure.Configurations.Dominio;

public class VideojuegoConfiguration : IEntityTypeConfiguration<Videojuego>
{
    public void Configure(EntityTypeBuilder<Videojuego> builder)
    {
        // Configuración de la relación con Plataforma
        builder.HasOne<Plataforma>()
               .WithMany()
               .HasForeignKey(v => v.PlataformaId)
               .OnDelete(DeleteBehavior.Cascade);

        // Configuración de la propiedad EsMultijugador
        builder.Property(v => v.EsMultijugador)
               .IsRequired();
    }
}