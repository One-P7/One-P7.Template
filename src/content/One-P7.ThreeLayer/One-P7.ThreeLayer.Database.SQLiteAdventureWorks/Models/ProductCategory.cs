namespace One_P7.ThreeLayer.Database.SQLiteAdventureWorks.Models;
public partial class ProductCategory
{
    public int ProductCategoryId { get; set; }
    public int? ParentProductCategoryId { get; set; }
    public string Name { get; set; }
    public Guid RowGuid { get; set; }
    public DateTime ModifiedDate { get; set; }

    public ProductCategory ParentCategory { get; set; }
    public ICollection<ProductCategory> ChildCategories { get; set; }
}
