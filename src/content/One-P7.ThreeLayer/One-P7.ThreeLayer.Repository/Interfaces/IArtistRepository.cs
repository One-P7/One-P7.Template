using ThreeLayer.Repository.ResultModels;

namespace ThreeLayer.Repository.Interfaces;

/// <summary>
/// 藝術家 Repository
/// </summary>
public interface IArtistRepository
{
    /// <summary>
    /// 取得所有藝術家
    /// </summary>
    /// <returns></returns>
    Task<IEnumerable<ArtistResultModel>> GetAllAsync(CancellationToken cancellationToken = default);

    /// <summary>
    /// 根據 id 取得藝術家
    /// </summary>
    /// <param name="id"></param>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    Task<ArtistResultModel> GetByIdAsync(int id, CancellationToken cancellationToken = default);
}
