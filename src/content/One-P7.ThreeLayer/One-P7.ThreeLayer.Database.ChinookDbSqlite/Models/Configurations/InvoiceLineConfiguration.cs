using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ThreeLayer.Database.ChinookDbSqlite.Models.Configurations;

public partial class InvoiceLineConfiguration : IEntityTypeConfiguration<InvoiceLine>
{
    public void Configure(EntityTypeBuilder<InvoiceLine> entity)
    {
        entity.ToTable("InvoiceLine");

        entity.HasIndex(e => e.InvoiceId, "IFK_InvoiceLineInvoiceId");

        entity.HasIndex(e => e.TrackId, "IFK_InvoiceLineTrackId");

        entity.Property(e => e.InvoiceLineId).ValueGeneratedNever();
        entity.Property(e => e.UnitPrice).HasColumnType("NUMERIC(10,2)");

        entity.HasOne(d => d.Invoice).WithMany(p => p.InvoiceLines)
            .HasForeignKey(d => d.InvoiceId)
            .OnDelete(DeleteBehavior.ClientSetNull);

        entity.HasOne(d => d.Track).WithMany(p => p.InvoiceLines)
            .HasForeignKey(d => d.TrackId)
            .OnDelete(DeleteBehavior.ClientSetNull);

        this.OnConfigurePartial(entity);
    }

    partial void OnConfigurePartial(EntityTypeBuilder<InvoiceLine> entity);
}
