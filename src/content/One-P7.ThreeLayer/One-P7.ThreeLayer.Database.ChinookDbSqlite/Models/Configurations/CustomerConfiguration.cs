using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ThreeLayer.Database.ChinookDbSqlite.Models.Configurations;

public partial class CustomerConfiguration : IEntityTypeConfiguration<Customer>
{
    public void Configure(EntityTypeBuilder<Customer> entity)
    {
        entity.ToTable("Customer");

        entity.HasIndex(e => e.SupportRepId, "IFK_CustomerSupportRepId");

        entity.Property(e => e.CustomerId).ValueGeneratedNever();
        entity.Property(e => e.Address).HasColumnType("NVARCHAR(70)");
        entity.Property(e => e.City).HasColumnType("NVARCHAR(40)");
        entity.Property(e => e.Company).HasColumnType("NVARCHAR(80)");
        entity.Property(e => e.Country).HasColumnType("NVARCHAR(40)");
        entity.Property(e => e.Email)
            .IsRequired()
            .HasColumnType("NVARCHAR(60)");
        entity.Property(e => e.Fax).HasColumnType("NVARCHAR(24)");
        entity.Property(e => e.FirstName)
            .IsRequired()
            .HasColumnType("NVARCHAR(40)");
        entity.Property(e => e.LastName)
            .IsRequired()
            .HasColumnType("NVARCHAR(20)");
        entity.Property(e => e.Phone).HasColumnType("NVARCHAR(24)");
        entity.Property(e => e.PostalCode).HasColumnType("NVARCHAR(10)");
        entity.Property(e => e.State).HasColumnType("NVARCHAR(40)");

        entity.HasOne(d => d.SupportRep).WithMany(p => p.Customers).HasForeignKey(d => d.SupportRepId);

        this.OnConfigurePartial(entity);
    }

    partial void OnConfigurePartial(EntityTypeBuilder<Customer> entity);
}
