using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace One_P7.ThreeLayer.Database.ChinookDbSqlite.Models.Configurations;

public partial class PlaylistConfiguration : IEntityTypeConfiguration<Playlist>
{
    public void Configure(EntityTypeBuilder<Playlist> entity)
    {
        entity.ToTable("Playlist");

        entity.Property(e => e.PlaylistId).ValueGeneratedNever();
        entity.Property(e => e.Name).HasColumnType("NVARCHAR(120)");

        entity.HasMany(d => d.Tracks).WithMany(p => p.Playlists)
            .UsingEntity<Dictionary<string, object>>(
                "PlaylistTrack",
                r => r.HasOne<Track>().WithMany()
                    .HasForeignKey("TrackId")
                    .OnDelete(DeleteBehavior.ClientSetNull),
                l => l.HasOne<Playlist>().WithMany()
                    .HasForeignKey("PlaylistId")
                    .OnDelete(DeleteBehavior.ClientSetNull),
                j =>
                {
                    j.HasKey("PlaylistId", "TrackId");
                    j.ToTable("PlaylistTrack");
                    j.HasIndex(new[] { "TrackId" }, "IFK_PlaylistTrackTrackId");
                });

        this.OnConfigurePartial(entity);
    }

    partial void OnConfigurePartial(EntityTypeBuilder<Playlist> entity);
}
