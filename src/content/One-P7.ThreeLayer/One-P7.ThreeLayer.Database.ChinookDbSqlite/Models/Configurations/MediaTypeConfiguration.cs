using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace One_P7.ThreeLayer.Database.ChinookDbSqlite.Models.Configurations;

public partial class MediaTypeConfiguration : IEntityTypeConfiguration<MediaType>
{
    public void Configure(EntityTypeBuilder<MediaType> entity)
    {
        entity.ToTable("MediaType");

        entity.Property(e => e.MediaTypeId).ValueGeneratedNever();
        entity.Property(e => e.Name).HasColumnType("NVARCHAR(120)");

        this.OnConfigurePartial(entity);
    }

    partial void OnConfigurePartial(EntityTypeBuilder<MediaType> entity);
}
