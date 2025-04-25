using ThreeLayer.Repository.Interfaces;
using ThreeLayer.Service.Dtos;
using ThreeLayer.Service.Interfaces;

namespace ThreeLayer.Service.Implements;

/// <summary>
/// 藝術家服務
/// </summary>
/// <param name="artistRepository"></param>
public class ArtistService(IArtistRepository artistRepository) : IArtistService
{
    /// <summary>
    /// 取得所有藝術家
    /// </summary>
    /// <returns></returns>
    /// <exception cref="NotImplementedException"></exception>
    public async Task<IEnumerable<ArtistDto>> GetAllAsync(CancellationToken cancellationToken = default)
    {
        var results = await artistRepository.GetAllAsync(cancellationToken);

        var dtos = results.Select(ParseToDto);

        return dtos;
    }

    /// <summary>
    /// 根據 id 取得藝術家
    /// </summary>
    /// <param name="id"></param>
    /// <returns></returns>
    /// <exception cref="NotImplementedException"></exception>
    public async Task<ArtistDto> GetByIdAsync(int id, CancellationToken cancellationToken = default)
    {
        var result = await artistRepository.GetByIdAsync(id, cancellationToken);

        var dto = ParseToDto(result);

        return dto;
    }

    /// <summary>
    /// 解析成 Dto
    /// </summary>
    /// <param name="result"></param>
    /// <returns></returns>
    private static ArtistDto ParseToDto(Repository.ResultModels.ArtistResultModel result)
    {
        return new ArtistDto
        {
            AlbumId = 0,
            Title = result.Name,
            ArtistId = result.ArtistId
        };
    }
}
