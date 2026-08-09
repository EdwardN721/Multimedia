using Microsoft.EntityFrameworkCore;
using Multimedia.Domain.Models.Dominio;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Multimedia.Infrastructure.Configurations.Dominio;

public class ContenidoConfiguration : IEntityTypeConfiguration<Contenido>
{
    public void Configure(EntityTypeBuilder<Contenido> builder)
    {
        // 1. Tabla, esquema y Check Constraint de años
        builder.ToTable("Contenido", "Multimedia", c => 
        {
            c.HasCheckConstraint("CK_Contenido_Anio", "[Anio] >= 1800 AND [Anio] <= YEAR(SYSDATETIME()) + 5");
        });

        // 2. Llave Primaria
        builder.HasKey(c => c.ContenidoId);
        builder.Property(c => c.ContenidoId).HasDefaultValueSql("NEWSEQUENTIALID()");

        // 3. Propiedades y Valores por Defecto
        builder.Property(c => c.Titulo).IsRequired().HasMaxLength(200);
        builder.Property(c => c.Portada).HasMaxLength(255);
        
        builder.Property(c => c.EsActivo).HasDefaultValue(true);
        builder.Property(c => c.FechaCreacion).HasDefaultValueSql("SYSDATETIME()");

        // 4. Índices y Filtros
        builder.HasIndex(c => c.Titulo);
        builder.HasQueryFilter(c => c.EsActivo);

        // CONFIGURACIÓN DE RELACIONES (Foreign Keys)
        
        builder.HasOne(c => c.TipoContenido)
            .WithMany()
            .HasForeignKey(c => c.TipoContenidoId)
            .OnDelete(DeleteBehavior.Restrict);

        builder.HasOne(c => c.Genero)
            .WithMany()
            .HasForeignKey(c => c.GeneroId)
            .OnDelete(DeleteBehavior.Restrict);

        builder.HasOne(c => c.Idioma)
            .WithMany()
            .HasForeignKey(c => c.IdiomaId)
            .OnDelete(DeleteBehavior.Restrict);

        builder.HasOne(c => c.Clasificacion)
            .WithMany()
            .HasForeignKey(c => c.ClasificacionId)
            .OnDelete(DeleteBehavior.Restrict);

        builder.HasOne(c => c.Formato)
            .WithMany()
            .HasForeignKey(c => c.FormatoId)
            .OnDelete(DeleteBehavior.Restrict);
        
        builder.HasOne(c => c.EstadoContenido)
            .WithMany()
            .HasForeignKey(c => c.EstadoContenidoId)
            .OnDelete(DeleteBehavior.Restrict);

        // Usuarios (Creador y Actualizador)
        builder.HasOne(c => c.CreadoPorUsuario)
            .WithMany()
            .HasForeignKey(c => c.CreadoPorUsuarioId)
            .OnDelete(DeleteBehavior.Restrict);

        builder.HasOne(c => c.UsuarioActualizacion)
            .WithMany()
            .HasForeignKey(c => c.UsuarioActualizacionId)
            .OnDelete(DeleteBehavior.Restrict);
    }
}