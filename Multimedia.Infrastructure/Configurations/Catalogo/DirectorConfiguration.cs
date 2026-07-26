using Microsoft.EntityFrameworkCore;
using Multimedia.Domain.Models.Catalogo;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Multimedia.Infrastructure.Configurations.Catalogo;

public class DirectorConfiguration : IEntityTypeConfiguration<Director>
{
    public void Configure(EntityTypeBuilder<Director> builder)
    {
        builder.ToTable("Directores", "Multimedia");

        builder.HasKey(c => c.DirectorId);
        builder.Property(c => c.DirectorId)
            .HasDefaultValueSql("NEWSEQUENTIALID()");

        builder.Property(c => c.Nombre)
            .IsRequired()
            .HasMaxLength(30);

        builder.Property(c => c.PrimerApellido)
            .IsRequired()
            .HasMaxLength(30);

        builder.Property(c => c.SegundoApellido)
            .HasMaxLength(30)
            .HasDefaultValue("");
    }
}