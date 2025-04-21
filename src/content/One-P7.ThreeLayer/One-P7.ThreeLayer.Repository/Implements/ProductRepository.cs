using One_P7.ThreeLayer.Database.SQLiteAdventureWorks;
using ThreeLayer.Repository.Interfaces;
using ThreeLayer.Repository.ResultModels;

namespace ThreeLayer.Repository.Implements;

/// <summary>
/// 產品資料存取
/// </summary>
/// <param name="adventureWorksSqliteDbContext"></param>
public class ProductRepository(AdventureWorksSqliteDbContext adventureWorksSqliteDbContext) : IProductRepository
{

    /// <summary>
    /// 取得產品資料
    /// </summary>
    /// <param name="productId"></param>
    /// <returns></returns>
    /// <exception cref="Exception"></exception>
    public ProductResultModel GetById(int productId)
    {
        var product = adventureWorksSqliteDbContext.Products
            .Where(p => p.ProductId == productId)
            .Select(p => new ProductResultModel()
            {
                ProductId = p.ProductId,
                Name = p.Name,
                ProductNumber = p.ProductNumber,
                Color = p.Color,
                StandardCost = p.StandardCost,
                ListPrice = p.ListPrice,
                Size = p.Size,
                Weight = p.Weight,
                ProductCategoryId = p.ProductCategoryId,
                ProductModelId = p.ProductModelId,
                SellStartDate = p.SellStartDate,
                SellEndDate = p.SellEndDate,
                DiscontinuedDate = p.DiscontinuedDate,
                ThumbnailPhotoFileName = p.ThumbnailPhotoFileName,
                ModifiedDate = p.ModifiedDate
            })
            .FirstOrDefault();

        if (product == null)
        {
            throw new Exception($"Product with ID {productId} not found.");
        }
        return product;
    }
}
