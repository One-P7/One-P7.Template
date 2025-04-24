using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ThreeLayer.Database.ChinookDbSqlite.Models.Configurations;

public partial class ArtistConfiguration : IEntityTypeConfiguration<Artist>
{
    public void Configure(EntityTypeBuilder<Artist> entity)
    {
        entity.ToTable("Artist");

        entity.Property(e => e.ArtistId).ValueGeneratedNever();
        entity.Property(e => e.Name).HasColumnType("NVARCHAR(120)");

        this.OnConfigurePartial(entity);
    }

    partial void OnConfigurePartial(EntityTypeBuilder<Artist> entity);
}
