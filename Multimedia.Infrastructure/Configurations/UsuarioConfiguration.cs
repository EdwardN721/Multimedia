using Multimedia.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Multimedia.Infrastructure.Configurations;

public class UsuarioConfiguration : IEntityTypeConfiguration<Usuario>
{
    public void Configure(EntityTypeBuilder<Usuario> builder)
    {
        builder.ToTable("Usuario", "Multimedia");

        builder.HasKey(u => u.UsuarioId);
        builder.Property(u => u.UsuarioId).HasDefaultValueSql("NEWSEQUENTIALID()");

        builder.Property(u => u.Nombre)
            .IsRequired()
            .HasMaxLength(100);

        builder.Property(u => u.Apellidos)
            .IsRequired()
            .HasMaxLength(100);

        builder.Property(u => u.Correo)
            .IsRequired()
            .HasMaxLength(150);

        builder.Property(u => u.PasswordHash)
            .IsRequired()
            .HasMaxLength(256);

        builder.Property(u => u.EsActivo)
            .HasDefaultValue(true);

        builder.Property(u => u.FechaCreacion)
            .HasDefaultValueSql("SYSDATETIME()");

        builder.HasIndex(u => u.Correo)
               .IsUnique()
               .IncludeProperties(u => new { u.PasswordHash, u.RolId, u.EsActivo });

        builder.HasQueryFilter(u => u.EsActivo);

        // Rol del usuario
        builder.HasOne(u => u.Rol)
               .WithMany(r => r.Usuarios)
               .HasForeignKey(u => u.RolId)
               .OnDelete(DeleteBehavior.Restrict);
    }
}
