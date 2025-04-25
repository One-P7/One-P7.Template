using ThreeLayer.Service.Dtos;
using ThreeLayer.Service.Queries;

namespace ThreeLayer.Service.Interfaces;

/// <summary>
/// 專輯 Service
/// </summary>
public interface IAlbumService
{
    /// <summary>
    /// 取得所有專輯
    /// </summary>
    /// <returns></returns>
    Task<ListResultDto<AlbumDto>> GetAllAsync(AlbumListQuery query);

    /// <summary>
    /// 根據 Id 取得專輯
    /// </summary>
    /// <param name="id"></param>
    /// <returns></returns>
    Task<AlbumDto> GetByIdAsync(int id);
}
