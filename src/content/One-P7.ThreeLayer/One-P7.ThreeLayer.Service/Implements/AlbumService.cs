using ThreeLayer.Repository.Conditions;
using ThreeLayer.Repository.Interfaces;
using ThreeLayer.Repository.ResultModels;
using ThreeLayer.Service.Dtos;
using ThreeLayer.Service.Interfaces;
using ThreeLayer.Service.Queries;

namespace ThreeLayer.Service.Implements;

/// <summary>
/// 專輯 Service
/// </summary>
public class AlbumService(IAlbumRepository albumRepository) : IAlbumService
{
    /// <summary>
    /// 取得所有專輯
    /// </summary>
    /// <param name="query"></param>
    /// <returns></returns>
    public async Task<ListResultDto<AlbumDto>> GetAllAsync(AlbumListQuery query)
    {
        var condition = new AlbumListCondition
        {
            Page = query.Page,
            PageSize = query.PageSize,
            Descending = query.Descending,
            Order = query.Order,
        };

        var resultModels = await albumRepository.GetAllAsync(condition);

        var result = new ListResultDto<AlbumDto>
        {
            TotalCount = resultModels.TotalCount,
            Page = resultModels.Page,
            PageSize = resultModels.PageSize,
            Results = resultModels.Results.Select(ParseToDto)
        };

        return result;
    }

    /// <summary>
    /// 根據 Id 取得專輯
    /// </summary>
    /// <param name="id"></param>
    /// <returns></returns>
    /// <exception cref="NotImplementedException"></exception>
    public async Task<AlbumDto> GetByIdAsync(int id)
    {
        var resultModel = await albumRepository.GetByIdAsync(id);

        var dto = ParseToDto(resultModel);

        return dto;
    }

    /// <summary>
    /// 轉換為 Dto
    /// </summary>
    /// <param name="resultModel"></param>
    /// <returns></returns>
    private static AlbumDto ParseToDto(AlbumResultModel resultModel)
    {
        return new AlbumDto
        {
            AlbumId = resultModel.AlbumId,
            Title = resultModel.Title,
            ArtistId = resultModel.ArtistId,
            ArtistName = resultModel.ArtistName
        };
    }
}