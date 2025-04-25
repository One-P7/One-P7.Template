namespace ThreeLayer.WebApi.Controllers.ViewModel;

/// <summary>
/// 藝術家 View Model
/// </summary>
public class ArtistViewModel
{
    /// <summary>
    /// 專輯數量
    /// </summary>
    public int AlbumCount { get; set; }

    /// <summary>
    /// 歌曲數量
    /// </summary>
    public int TracksCount { get; set; }

    /// <summary>
    /// 藝術家名稱
    /// </summary>
    public string Name { get; set; }

    /// <summary>
    /// 藝術家 Id
    /// </summary>
    public int ArtistId { get; set; }
}