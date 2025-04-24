using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ThreeLayer.Database.ChinookDbSqlite.Models.Configurations;

public partial class EmployeeConfiguration : IEntityTypeConfiguration<Employee>
{
    public void Configure(EntityTypeBuilder<Employee> entity)
    {
        entity.ToTable("Employee");

        entity.HasIndex(e => e.ReportsTo, "IFK_EmployeeReportsTo");

        entity.Property(e => e.EmployeeId).ValueGeneratedNever();
        entity.Property(e => e.Address).HasColumnType("NVARCHAR(70)");
        entity.Property(e => e.BirthDate).HasColumnType("DATETIME");
        entity.Property(e => e.City).HasColumnType("NVARCHAR(40)");
        entity.Property(e => e.Country).HasColumnType("NVARCHAR(40)");
        entity.Property(e => e.Email).HasColumnType("NVARCHAR(60)");
        entity.Property(e => e.Fax).HasColumnType("NVARCHAR(24)");
        entity.Property(e => e.FirstName)
            .IsRequired()
            .HasColumnType("NVARCHAR(20)");
        entity.Property(e => e.HireDate).HasColumnType("DATETIME");
        entity.Property(e => e.LastName)
            .IsRequired()
            .HasColumnType("NVARCHAR(20)");
        entity.Property(e => e.Phone).HasColumnType("NVARCHAR(24)");
        entity.Property(e => e.PostalCode).HasColumnType("NVARCHAR(10)");
        entity.Property(e => e.State).HasColumnType("NVARCHAR(40)");
        entity.Property(e => e.Title).HasColumnType("NVARCHAR(30)");

        entity.HasOne(d => d.ReportsToNavigation).WithMany(p => p.InverseReportsToNavigation).HasForeignKey(d => d.ReportsTo);

        this.OnConfigurePartial(entity);
    }

    partial void OnConfigurePartial(EntityTypeBuilder<Employee> entity);
}
