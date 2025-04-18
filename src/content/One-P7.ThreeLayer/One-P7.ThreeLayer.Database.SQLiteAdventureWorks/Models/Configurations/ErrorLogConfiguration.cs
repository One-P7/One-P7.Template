using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace One_P7.ThreeLayer.Database.SQLiteAdventureWorks.Models.Configurations;

public partial class ErrorLogConfiguration : IEntityTypeConfiguration<ErrorLog>
{
    public void Configure(EntityTypeBuilder<ErrorLog> entity)
    {
        entity.ToTable("ErrorLog");

        entity.Property(e => e.ErrorLogId).HasColumnName("ErrorLogID");
        entity.Property(e => e.ErrorMessage).IsRequired();
        entity.Property(e => e.ErrorTime)
            .HasDefaultValueSql("datetime('now')")
            .HasColumnType("DATETIME");
        entity.Property(e => e.UserName).IsRequired();

        this.OnConfigurePartial(entity);
    }

    partial void OnConfigurePartial(EntityTypeBuilder<ErrorLog> entity);
}
