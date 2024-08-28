using Microsoft.EntityFrameworkCore;
using ThreeLayer.Database.AdventureWorks.Models;

namespace ThreeLayer.Database.AdventureWorks;

public partial class AdventureWorksContext(DbContextOptions<AdventureWorksContext> options) : DbContext(options)
{
    public virtual DbSet<Address> Addresses { get; set; }

    public virtual DbSet<AddressType> AddressTypes { get; set; }

    public virtual DbSet<AwbuildVersion> AwbuildVersions { get; set; }

    public virtual DbSet<BillOfMaterial> BillOfMaterials { get; set; }

    public virtual DbSet<BusinessEntity> BusinessEntities { get; set; }

    public virtual DbSet<BusinessEntityAddress> BusinessEntityAddresses { get; set; }

    public virtual DbSet<BusinessEntityContact> BusinessEntityContacts { get; set; }

    public virtual DbSet<ContactType> ContactTypes { get; set; }

    public virtual DbSet<CountryRegion> CountryRegions { get; set; }

    public virtual DbSet<CountryRegionCurrency> CountryRegionCurrencies { get; set; }

    public virtual DbSet<CreditCard> CreditCards { get; set; }

    public virtual DbSet<Culture> Cultures { get; set; }

    public virtual DbSet<Currency> Currencies { get; set; }

    public virtual DbSet<CurrencyRate> CurrencyRates { get; set; }

    public virtual DbSet<Customer> Customers { get; set; }

    public virtual DbSet<DatabaseLog> DatabaseLogs { get; set; }

    public virtual DbSet<Department> Departments { get; set; }

    public virtual DbSet<EmailAddress> EmailAddresses { get; set; }

    public virtual DbSet<Employee> Employees { get; set; }

    public virtual DbSet<EmployeeDepartmentHistory> EmployeeDepartmentHistories { get; set; }

    public virtual DbSet<EmployeePayHistory> EmployeePayHistories { get; set; }

    public virtual DbSet<ErrorLog> ErrorLogs { get; set; }

    public virtual DbSet<Illustration> Illustrations { get; set; }

    public virtual DbSet<JobCandidate> JobCandidates { get; set; }

    public virtual DbSet<Location> Locations { get; set; }

    public virtual DbSet<Password> Passwords { get; set; }

    public virtual DbSet<Person> People { get; set; }

    public virtual DbSet<PersonCreditCard> PersonCreditCards { get; set; }

    public virtual DbSet<PersonPhone> PersonPhones { get; set; }

    public virtual DbSet<PhoneNumberType> PhoneNumberTypes { get; set; }

    public virtual DbSet<Product> Products { get; set; }

    public virtual DbSet<ProductCategory> ProductCategories { get; set; }

    public virtual DbSet<ProductCostHistory> ProductCostHistories { get; set; }

    public virtual DbSet<ProductDescription> ProductDescriptions { get; set; }

    public virtual DbSet<ProductInventory> ProductInventories { get; set; }

    public virtual DbSet<ProductListPriceHistory> ProductListPriceHistories { get; set; }

    public virtual DbSet<ProductModel> ProductModels { get; set; }

    public virtual DbSet<ProductModelIllustration> ProductModelIllustrations { get; set; }

    public virtual DbSet<ProductModelProductDescriptionCulture> ProductModelProductDescriptionCultures { get; set; }

    public virtual DbSet<ProductPhoto> ProductPhotos { get; set; }

    public virtual DbSet<ProductProductPhoto> ProductProductPhotos { get; set; }

    public virtual DbSet<ProductReview> ProductReviews { get; set; }

    public virtual DbSet<ProductSubcategory> ProductSubcategories { get; set; }

    public virtual DbSet<ProductVendor> ProductVendors { get; set; }

    public virtual DbSet<PurchaseOrderDetail> PurchaseOrderDetails { get; set; }

    public virtual DbSet<PurchaseOrderHeader> PurchaseOrderHeaders { get; set; }

    public virtual DbSet<SalesOrderDetail> SalesOrderDetails { get; set; }

    public virtual DbSet<SalesOrderHeader> SalesOrderHeaders { get; set; }

    public virtual DbSet<SalesOrderHeaderSalesReason> SalesOrderHeaderSalesReasons { get; set; }

    public virtual DbSet<SalesPerson> SalesPeople { get; set; }

    public virtual DbSet<SalesPersonQuotaHistory> SalesPersonQuotaHistories { get; set; }

    public virtual DbSet<SalesReason> SalesReasons { get; set; }

    public virtual DbSet<SalesTaxRate> SalesTaxRates { get; set; }

    public virtual DbSet<SalesTerritory> SalesTerritories { get; set; }

    public virtual DbSet<SalesTerritoryHistory> SalesTerritoryHistories { get; set; }

    public virtual DbSet<ScrapReason> ScrapReasons { get; set; }

    public virtual DbSet<Shift> Shifts { get; set; }

    public virtual DbSet<ShipMethod> ShipMethods { get; set; }

    public virtual DbSet<ShoppingCartItem> ShoppingCartItems { get; set; }

    public virtual DbSet<SpecialOffer> SpecialOffers { get; set; }

    public virtual DbSet<SpecialOfferProduct> SpecialOfferProducts { get; set; }

    public virtual DbSet<StateProvince> StateProvinces { get; set; }

    public virtual DbSet<Store> Stores { get; set; }

    public virtual DbSet<TransactionHistory> TransactionHistories { get; set; }

    public virtual DbSet<TransactionHistoryArchive> TransactionHistoryArchives { get; set; }

    public virtual DbSet<UnitMeasure> UnitMeasures { get; set; }

    public virtual DbSet<Vendor> Vendors { get; set; }

    public virtual DbSet<WorkOrder> WorkOrders { get; set; }

    public virtual DbSet<WorkOrderRouting> WorkOrderRoutings { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfiguration(new Models.Configurations.AddressConfiguration());
        modelBuilder.ApplyConfiguration(new Models.Configurations.AddressTypeConfiguration());
        modelBuilder.ApplyConfiguration(new Models.Configurations.AwbuildVersionConfiguration());
        modelBuilder.ApplyConfiguration(new Models.Configurations.BillOfMaterialConfiguration());
        modelBuilder.ApplyConfiguration(new Models.Configurations.BusinessEntityConfiguration());
        modelBuilder.ApplyConfiguration(new Models.Configurations.BusinessEntityAddressConfiguration());
        modelBuilder.ApplyConfiguration(new Models.Configurations.BusinessEntityContactConfiguration());
        modelBuilder.ApplyConfiguration(new Models.Configurations.ContactTypeConfiguration());
        modelBuilder.ApplyConfiguration(new Models.Configurations.CountryRegionConfiguration());
        modelBuilder.ApplyConfiguration(new Models.Configurations.CountryRegionCurrencyConfiguration());
        modelBuilder.ApplyConfiguration(new Models.Configurations.CreditCardConfiguration());
        modelBuilder.ApplyConfiguration(new Models.Configurations.CultureConfiguration());
        modelBuilder.ApplyConfiguration(new Models.Configurations.CurrencyConfiguration());
        modelBuilder.ApplyConfiguration(new Models.Configurations.CurrencyRateConfiguration());
        modelBuilder.ApplyConfiguration(new Models.Configurations.CustomerConfiguration());
        modelBuilder.ApplyConfiguration(new Models.Configurations.DatabaseLogConfiguration());
        modelBuilder.ApplyConfiguration(new Models.Configurations.DepartmentConfiguration());
        modelBuilder.ApplyConfiguration(new Models.Configurations.EmailAddressConfiguration());
        modelBuilder.ApplyConfiguration(new Models.Configurations.EmployeeConfiguration());
        modelBuilder.ApplyConfiguration(new Models.Configurations.EmployeeDepartmentHistoryConfiguration());
        modelBuilder.ApplyConfiguration(new Models.Configurations.EmployeePayHistoryConfiguration());
        modelBuilder.ApplyConfiguration(new Models.Configurations.ErrorLogConfiguration());
        modelBuilder.ApplyConfiguration(new Models.Configurations.IllustrationConfiguration());
        modelBuilder.ApplyConfiguration(new Models.Configurations.JobCandidateConfiguration());
        modelBuilder.ApplyConfiguration(new Models.Configurations.LocationConfiguration());
        modelBuilder.ApplyConfiguration(new Models.Configurations.PasswordConfiguration());
        modelBuilder.ApplyConfiguration(new Models.Configurations.PersonConfiguration());
        modelBuilder.ApplyConfiguration(new Models.Configurations.PersonCreditCardConfiguration());
        modelBuilder.ApplyConfiguration(new Models.Configurations.PersonPhoneConfiguration());
        modelBuilder.ApplyConfiguration(new Models.Configurations.PhoneNumberTypeConfiguration());
        modelBuilder.ApplyConfiguration(new Models.Configurations.ProductConfiguration());
        modelBuilder.ApplyConfiguration(new Models.Configurations.ProductCategoryConfiguration());
        modelBuilder.ApplyConfiguration(new Models.Configurations.ProductCostHistoryConfiguration());
        modelBuilder.ApplyConfiguration(new Models.Configurations.ProductDescriptionConfiguration());
        modelBuilder.ApplyConfiguration(new Models.Configurations.ProductInventoryConfiguration());
        modelBuilder.ApplyConfiguration(new Models.Configurations.ProductListPriceHistoryConfiguration());
        modelBuilder.ApplyConfiguration(new Models.Configurations.ProductModelConfiguration());
        modelBuilder.ApplyConfiguration(new Models.Configurations.ProductModelIllustrationConfiguration());
        modelBuilder.ApplyConfiguration(new Models.Configurations.ProductModelProductDescriptionCultureConfiguration());
        modelBuilder.ApplyConfiguration(new Models.Configurations.ProductPhotoConfiguration());
        modelBuilder.ApplyConfiguration(new Models.Configurations.ProductProductPhotoConfiguration());
        modelBuilder.ApplyConfiguration(new Models.Configurations.ProductReviewConfiguration());
        modelBuilder.ApplyConfiguration(new Models.Configurations.ProductSubcategoryConfiguration());
        modelBuilder.ApplyConfiguration(new Models.Configurations.ProductVendorConfiguration());
        modelBuilder.ApplyConfiguration(new Models.Configurations.PurchaseOrderDetailConfiguration());
        modelBuilder.ApplyConfiguration(new Models.Configurations.PurchaseOrderHeaderConfiguration());
        modelBuilder.ApplyConfiguration(new Models.Configurations.SalesOrderDetailConfiguration());
        modelBuilder.ApplyConfiguration(new Models.Configurations.SalesOrderHeaderConfiguration());
        modelBuilder.ApplyConfiguration(new Models.Configurations.SalesOrderHeaderSalesReasonConfiguration());
        modelBuilder.ApplyConfiguration(new Models.Configurations.SalesPersonConfiguration());
        modelBuilder.ApplyConfiguration(new Models.Configurations.SalesPersonQuotaHistoryConfiguration());
        modelBuilder.ApplyConfiguration(new Models.Configurations.SalesReasonConfiguration());
        modelBuilder.ApplyConfiguration(new Models.Configurations.SalesTaxRateConfiguration());
        modelBuilder.ApplyConfiguration(new Models.Configurations.SalesTerritoryConfiguration());
        modelBuilder.ApplyConfiguration(new Models.Configurations.SalesTerritoryHistoryConfiguration());
        modelBuilder.ApplyConfiguration(new Models.Configurations.ScrapReasonConfiguration());
        modelBuilder.ApplyConfiguration(new Models.Configurations.ShiftConfiguration());
        modelBuilder.ApplyConfiguration(new Models.Configurations.ShipMethodConfiguration());
        modelBuilder.ApplyConfiguration(new Models.Configurations.ShoppingCartItemConfiguration());
        modelBuilder.ApplyConfiguration(new Models.Configurations.SpecialOfferConfiguration());
        modelBuilder.ApplyConfiguration(new Models.Configurations.SpecialOfferProductConfiguration());
        modelBuilder.ApplyConfiguration(new Models.Configurations.StateProvinceConfiguration());
        modelBuilder.ApplyConfiguration(new Models.Configurations.StoreConfiguration());
        modelBuilder.ApplyConfiguration(new Models.Configurations.TransactionHistoryConfiguration());
        modelBuilder.ApplyConfiguration(new Models.Configurations.TransactionHistoryArchiveConfiguration());
        modelBuilder.ApplyConfiguration(new Models.Configurations.UnitMeasureConfiguration());
        modelBuilder.ApplyConfiguration(new Models.Configurations.VendorConfiguration());
        modelBuilder.ApplyConfiguration(new Models.Configurations.WorkOrderConfiguration());
        modelBuilder.ApplyConfiguration(new Models.Configurations.WorkOrderRoutingConfiguration());

        this.OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
