using Microsoft.EntityFrameworkCore;
using Multimedia.Domain.Models.Dominio;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Multimedia.Infrastructure.Configurations.Dominio;

public class LibroConfiguration : IEntityTypeConfiguration<Libro>
{
    public void Configure(EntityTypeBuilder<Libro> builder)
    {
        // Al heredar de Contenido, solo indicamos la tabla hija (TPT)
        builder.ToTable("Libro", "Multimedia");

        // No es necesario re-configurar la llave primaria (ContenidoId)
        
        builder.Property(l => l.ISBN)
            .IsRequired()
            .HasMaxLength(20);

        builder.HasIndex(l => l.ISBN)
            .IsUnique();

        builder.Property(l => l.NumeroPaginas)
            .IsRequired();

        builder.HasOne(l => l.Editorial)
            .WithMany(l => l.Libros)
            .HasForeignKey(l => l.EditorialId)
            .OnDelete(DeleteBehavior.Cascade);

        builder.HasIndex(l => l.EditorialId);
    }
}