using ThreeLayer.Repository.Conditions;
using ThreeLayer.Repository.ResultModels;

namespace ThreeLayer.Repository.Interfaces;

/// <summary>
/// 專輯 Repository
/// </summary>
public interface IAlbumRepository
{
    /// <summary>
    /// 取得所有專輯
    /// </summary>
    /// <param name="condition"></param>
    /// <param name="cancellationToken"></param> 
    /// <returns></returns>
    Task<ListResultModel<AlbumResultModel>> GetAllAsync(AlbumListCondition condition, CancellationToken cancellationToken = default);

    /// <summary>
    /// 根據 Id 取得專輯
    /// </summary>
    /// <param name="id"></param>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    Task<AlbumResultModel> GetByIdAsync(int id, CancellationToken cancellationToken = default);
}
