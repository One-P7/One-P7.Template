using Microsoft.EntityFrameworkCore;
using One_P7.ThreeLayer.Database.SQLiteAdventureWorks.Models;

namespace One_P7.ThreeLayer.Database.SQLiteAdventureWorks;

public partial class AdventureWorksSqliteDbContext(
    DbContextOptions<AdventureWorksSqliteDbContext> options) : DbContext(options)
{
    public virtual DbSet<Address> Addresses { get; set; }

    public virtual DbSet<BuildVersion> BuildVersions { get; set; }

    public virtual DbSet<Customer> Customers { get; set; }

    public virtual DbSet<CustomerAddress> CustomerAddresses { get; set; }

    public virtual DbSet<ErrorLog> ErrorLogs { get; set; }

    public virtual DbSet<Product> Products { get; set; }

    public virtual DbSet<ProductDescription> ProductDescriptions { get; set; }

    public virtual DbSet<ProductModel> ProductModels { get; set; }

    public virtual DbSet<ProductModelProductDescription> ProductModelProductDescriptions { get; set; }

    public virtual DbSet<SalesOrderDetail> SalesOrderDetails { get; set; }

    public virtual DbSet<SalesOrderHeader> SalesOrderHeaders { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfiguration(new Models.Configurations.AddressConfiguration());
        modelBuilder.ApplyConfiguration(new Models.Configurations.BuildVersionConfiguration());
        modelBuilder.ApplyConfiguration(new Models.Configurations.CustomerConfiguration());
        modelBuilder.ApplyConfiguration(new Models.Configurations.CustomerAddressConfiguration());
        modelBuilder.ApplyConfiguration(new Models.Configurations.ErrorLogConfiguration());
        modelBuilder.ApplyConfiguration(new Models.Configurations.ProductConfiguration());
        modelBuilder.ApplyConfiguration(new Models.Configurations.ProductDescriptionConfiguration());
        modelBuilder.ApplyConfiguration(new Models.Configurations.ProductModelConfiguration());
        modelBuilder.ApplyConfiguration(new Models.Configurations.ProductModelProductDescriptionConfiguration());
        modelBuilder.ApplyConfiguration(new Models.Configurations.SalesOrderDetailConfiguration());
        modelBuilder.ApplyConfiguration(new Models.Configurations.SalesOrderHeaderConfiguration());
        modelBuilder.ApplyConfiguration(new Models.Configurations.ProductCategoryConfiguration());

        this.OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
