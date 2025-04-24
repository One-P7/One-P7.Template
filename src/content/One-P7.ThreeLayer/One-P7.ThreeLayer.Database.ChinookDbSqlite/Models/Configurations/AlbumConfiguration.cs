using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ThreeLayer.Database.ChinookDbSqlite.Models.Configurations;

public partial class AlbumConfiguration : IEntityTypeConfiguration<Album>
{
    public void Configure(EntityTypeBuilder<Album> entity)
    {
        entity.ToTable("Album");

        entity.HasIndex(e => e.ArtistId, "IFK_AlbumArtistId");

        entity.Property(e => e.AlbumId).ValueGeneratedNever();
        entity.Property(e => e.Title)
            .IsRequired()
            .HasColumnType("NVARCHAR(160)");

        entity.HasOne(d => d.Artist).WithMany(p => p.Albums)
            .HasForeignKey(d => d.ArtistId)
            .OnDelete(DeleteBehavior.ClientSetNull);

        this.OnConfigurePartial(entity);
    }

    partial void OnConfigurePartial(EntityTypeBuilder<Album> entity);
}
