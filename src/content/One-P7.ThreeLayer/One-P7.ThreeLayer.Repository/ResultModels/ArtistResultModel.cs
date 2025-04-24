namespace ThreeLayer.Repository.ResultModels;

/// <summary>
/// 藝術家 ResultModel
/// </summary>
public class ArtistResultModel
{
    /// <summary>
    /// 專輯 Id
    /// </summary>
    public int AlbumId { get; set; }

    /// <summary>
    /// 專輯名稱
    /// </summary>
    public string Title { get; set; }

    /// <summary>
    /// 藝術家 Id
    /// </summary>
    public int ArtistId { get; set; }
}
