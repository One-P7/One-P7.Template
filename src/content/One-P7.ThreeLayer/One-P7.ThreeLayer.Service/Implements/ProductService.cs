using ThreeLayer.Repository.Interfaces;
using ThreeLayer.Service.Dtos;
using ThreeLayer.Service.Interfaces;

namespace ThreeLayer.Service.Implements;

/// <summary>
/// 產品服務
/// </summary>
/// <param name="productRepository"></param>
public class ProductService(IProductRepository productRepository) : IProductService
{
    /// <summary>
    /// 取得產品資料
    /// </summary>
    /// <param name="productId"></param>
    /// <returns></returns>
    public ProductDto GetById(int productId)
    {
        var result = productRepository.GetById(productId);
        var dto = new ProductDto()
        {
            ProductId = result.ProductId,
            Name = result.Name,
            ProductNumber = result.ProductNumber,
            Color = result.Color,
            StandardCost = result.StandardCost,
            ListPrice = result.ListPrice,
            Size = result.Size,
            Weight = result.Weight,
            ProductCategoryId = result.ProductCategoryId,
            ProductModelId = result.ProductModelId,
            SellStartDate = result.SellStartDate,
            SellEndDate = result.SellEndDate,
            DiscontinuedDate = result.DiscontinuedDate,
            ThumbnailPhotoFileName = result.ThumbnailPhotoFileName,
            ModifiedDate = result.ModifiedDate
        };
        return dto;
    }
}
