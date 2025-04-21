using ThreeLayer.Service.Dtos;

namespace ThreeLayer.Service.Interfaces;

/// <summary>
/// 產品服務
/// </summary>
public interface IProductService
{
    /// <summary>
    /// 取得產品資料
    /// </summary>
    /// <param name="productId"></param>
    /// <returns></returns>
    ProductDto GetById(int productId);
}
