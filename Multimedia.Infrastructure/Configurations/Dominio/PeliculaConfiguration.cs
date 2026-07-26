using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Multimedia.Domain.Models.Dominio;

namespace Multimedia.Infrastructure.Configurations.Dominio;

public class PeliculaConfiguration : IEntityTypeConfiguration<Pelicula>
{
    public void Configure(EntityTypeBuilder<Pelicula> builder)
    {
        builder.ToTable("Peliculas", "Multimedia");

        // No es necesario re-configurar la llave primaria (ContenidoId)

        builder.Property(p => p.DuracionMinutos)
            .IsRequired();
    }
}