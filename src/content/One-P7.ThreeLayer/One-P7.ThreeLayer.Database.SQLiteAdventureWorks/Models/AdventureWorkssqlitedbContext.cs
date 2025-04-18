using Microsoft.EntityFrameworkCore;

namespace One_P7.ThreeLayer.Database.SQLiteAdventureWorks.Models;

public partial class AdventureWorkssqlitedbContext(
    DbContextOptions<AdventureWorkssqlitedbContext> options) : DbContext(options)
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
        modelBuilder.ApplyConfiguration(new Configurations.AddressConfiguration());
        modelBuilder.ApplyConfiguration(new Configurations.BuildVersionConfiguration());
        modelBuilder.ApplyConfiguration(new Configurations.CustomerConfiguration());
        modelBuilder.ApplyConfiguration(new Configurations.CustomerAddressConfiguration());
        modelBuilder.ApplyConfiguration(new Configurations.ErrorLogConfiguration());
        modelBuilder.ApplyConfiguration(new Configurations.ProductConfiguration());
        modelBuilder.ApplyConfiguration(new Configurations.ProductDescriptionConfiguration());
        modelBuilder.ApplyConfiguration(new Configurations.ProductModelConfiguration());
        modelBuilder.ApplyConfiguration(new Configurations.ProductModelProductDescriptionConfiguration());
        modelBuilder.ApplyConfiguration(new Configurations.SalesOrderDetailConfiguration());
        modelBuilder.ApplyConfiguration(new Configurations.SalesOrderHeaderConfiguration());
        modelBuilder.ApplyConfiguration(new Configurations.ProductCategoryConfiguration());

        this.OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
