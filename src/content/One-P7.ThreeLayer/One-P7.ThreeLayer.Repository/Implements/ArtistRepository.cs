using Microsoft.EntityFrameworkCore;
using ThreeLayer.Database.ChinookDbSqlite;
using ThreeLayer.Repository.Interfaces;
using ThreeLayer.Repository.ResultModels;

namespace ThreeLayer.Repository.Implements;

/// <summary>
/// 藝術家資訊 Repository
/// </summary>
/// <param name="chinookSqliteContext"></param>
public class ArtistRepository(ChinookSqliteContext chinookSqliteContext) : IArtistRepository
{
    /// <summary>
    /// 取得所有藝術家資訊
    /// </summary>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    public async Task<IEnumerable<ArtistResultModel>> GetAllAsync(CancellationToken cancellationToken = default)
    {
        var result = await chinookSqliteContext.Artists.Select(a => new ArtistResultModel
        {
            ArtistId = a.ArtistId,
            Name = a.Name,
            AlbumCount = chinookSqliteContext.Albums.Count(x => x.ArtistId == a.ArtistId),
            TracksCount = chinookSqliteContext.Tracks.Count(x => x.AlbumId == a.ArtistId)
        }).ToListAsync(cancellationToken);

        return result;
    }

    /// <summary>
    /// 根據 id 取得藝術家資訊
    /// </summary>
    /// <param name="id"></param>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    /// <exception cref="NotImplementedException"></exception>
    public async Task<ArtistResultModel> GetByIdAsync(int id, CancellationToken cancellationToken = default)
    {
        var result = await chinookSqliteContext.Artists
        .Where(a => a.ArtistId == id)
        .Select(a => new ArtistResultModel
        {
            ArtistId = a.ArtistId,
            Name = a.Name,
            AlbumCount = chinookSqliteContext.Albums.Count(x => x.ArtistId == a.ArtistId),
            TracksCount = chinookSqliteContext.Tracks.Count(x => x.AlbumId == a.ArtistId)
        }).FirstOrDefaultAsync(cancellationToken);

        return result;
    }
}
