using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace One_P7.ThreeLayer.Database.ChinookDbSqlite.Models.Configurations;

public partial class InvoiceConfiguration : IEntityTypeConfiguration<Invoice>
{
    public void Configure(EntityTypeBuilder<Invoice> entity)
    {
        entity.ToTable("Invoice");

        entity.HasIndex(e => e.CustomerId, "IFK_InvoiceCustomerId");

        entity.Property(e => e.InvoiceId).ValueGeneratedNever();
        entity.Property(e => e.BillingAddress).HasColumnType("NVARCHAR(70)");
        entity.Property(e => e.BillingCity).HasColumnType("NVARCHAR(40)");
        entity.Property(e => e.BillingCountry).HasColumnType("NVARCHAR(40)");
        entity.Property(e => e.BillingPostalCode).HasColumnType("NVARCHAR(10)");
        entity.Property(e => e.BillingState).HasColumnType("NVARCHAR(40)");
        entity.Property(e => e.InvoiceDate).HasColumnType("DATETIME");
        entity.Property(e => e.Total).HasColumnType("NUMERIC(10,2)");

        entity.HasOne(d => d.Customer).WithMany(p => p.Invoices)
            .HasForeignKey(d => d.CustomerId)
            .OnDelete(DeleteBehavior.ClientSetNull);

        this.OnConfigurePartial(entity);
    }

    partial void OnConfigurePartial(EntityTypeBuilder<Invoice> entity);
}
