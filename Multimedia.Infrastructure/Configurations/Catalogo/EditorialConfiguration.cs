using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Multimedia.Domain.Models.Catalogo;

namespace Multimedia.Infrastructure.Configurations.Catalogo;

public class EditorialConfiguration : IEntityTypeConfiguration<Editorial>
{
    public void Configure(EntityTypeBuilder<Editorial> builder)
    {
        builder.ToTable("Editoriales", "Multimedia");

        builder.HasKey(c => c.EditorialId);
        builder.Property(c => c.EditorialId)
            .HasDefaultValueSql("NEWSEQUENTIALID()");

        builder.Property(c => c.Nombre)
            .IsRequired()
            .HasMaxLength(30);
    }
}