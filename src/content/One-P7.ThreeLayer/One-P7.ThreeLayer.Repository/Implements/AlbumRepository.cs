using Microsoft.EntityFrameworkCore;
using ThreeLayer.Database.ChinookDbSqlite;
using ThreeLayer.Database.ChinookDbSqlite.Models;
using ThreeLayer.Repository.Conditions;
using ThreeLayer.Repository.Interfaces;
using ThreeLayer.Repository.ResultModels;

namespace ThreeLayer.Repository.Implements;

/// <summary>
/// 專輯 Repository
/// </summary>
/// <param name="chinookSqliteContext"></param>
public class AlbumRepository(ChinookSqliteContext chinookSqliteContext) : IAlbumRepository
{
    /// <summary>
    /// 取得所有專輯
    /// </summary>
    /// <param name="condition"></param>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    public async Task<ListResultModel<AlbumResultModel>> GetAllAsync(AlbumListCondition condition, CancellationToken cancellationToken = default)
    {
        var result = await chinookSqliteContext.Albums
        .Skip(condition.Page * condition.PageSize)
        .Take(condition.PageSize)
        .ToListAsync(cancellationToken);

        var totalCount = await chinookSqliteContext.Albums.CountAsync(cancellationToken);

        return new ListResultModel<AlbumResultModel>
        {
            TotalCount = totalCount,
            Page = condition.Page,
            PageSize = condition.PageSize,
            Results = result.Select(ParseToResultModel)
        };
    }

    /// <summary>
    /// 根據 id 取得專輯
    /// </summary>
    /// <param name="id"></param>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    public Task<AlbumResultModel> GetByIdAsync(int id, CancellationToken cancellationToken = default)
    {
        var result = chinookSqliteContext.Albums
            .Where(a => a.AlbumId == id)
            .Select(a => ParseToResultModel(a))
            .FirstOrDefaultAsync(cancellationToken);

        return result;
    }

    /// <summary>
    /// 解析為 ResultModel
    /// </summary>
    /// <param name="a"></param>
    /// <returns></returns>
    private static AlbumResultModel ParseToResultModel(Album a)
    {
        return new AlbumResultModel
        {
            AlbumId = a.AlbumId,
            Title = a.Title,
            ArtistName = a.Artist.Name,
            ArtistId = a.ArtistId,
        };
    }
}
