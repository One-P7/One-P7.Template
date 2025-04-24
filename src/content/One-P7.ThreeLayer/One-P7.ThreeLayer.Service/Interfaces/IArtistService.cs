using ThreeLayer.Service.Dtos;

namespace ThreeLayer.Service.Interfaces;

/// <summary>
/// 藝術家服務
/// </summary>
public interface IArtistService
{
    /// <summary>
    /// 取得所有藝術家
    /// </summary>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    Task<IEnumerable<ArtistDto>> GetAllAsync(CancellationToken cancellationToken = default);

    /// <summary>
    /// 根據 id 取得藝術家
    /// </summary>
    /// <param name="id"></param>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    Task<ArtistDto> GetByIdAsync(int id, CancellationToken cancellationToken = default);
}
