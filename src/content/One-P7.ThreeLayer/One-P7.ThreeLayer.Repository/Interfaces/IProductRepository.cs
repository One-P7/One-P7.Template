using ThreeLayer.Repository.ResultModels;

namespace ThreeLayer.Repository.Interfaces;

/// <summary>
/// 產品資料存取
/// </summary>
public interface IProductRepository
{
    /// <summary>
    /// 取得產品資料
    /// </summary>
    /// <param name="productId"></param>
    /// <returns></returns>
    ProductResultModel GetById(int productId);
}
