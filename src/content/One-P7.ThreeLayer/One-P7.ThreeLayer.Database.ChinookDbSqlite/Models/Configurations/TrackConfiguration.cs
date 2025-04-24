using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ThreeLayer.Database.ChinookDbSqlite.Models.Configurations;

public partial class TrackConfiguration : IEntityTypeConfiguration<Track>
{
    public void Configure(EntityTypeBuilder<Track> entity)
    {
        entity.ToTable("Track");

        entity.HasIndex(e => e.AlbumId, "IFK_TrackAlbumId");

        entity.HasIndex(e => e.GenreId, "IFK_TrackGenreId");

        entity.HasIndex(e => e.MediaTypeId, "IFK_TrackMediaTypeId");

        entity.Property(e => e.TrackId).ValueGeneratedNever();
        entity.Property(e => e.Composer).HasColumnType("NVARCHAR(220)");
        entity.Property(e => e.Name)
            .IsRequired()
            .HasColumnType("NVARCHAR(200)");
        entity.Property(e => e.UnitPrice).HasColumnType("NUMERIC(10,2)");

        entity.HasOne(d => d.Album).WithMany(p => p.Tracks).HasForeignKey(d => d.AlbumId);

        entity.HasOne(d => d.Genre).WithMany(p => p.Tracks).HasForeignKey(d => d.GenreId);

        entity.HasOne(d => d.MediaType).WithMany(p => p.Tracks)
            .HasForeignKey(d => d.MediaTypeId)
            .OnDelete(DeleteBehavior.ClientSetNull);

        this.OnConfigurePartial(entity);
    }

    partial void OnConfigurePartial(EntityTypeBuilder<Track> entity);
}
