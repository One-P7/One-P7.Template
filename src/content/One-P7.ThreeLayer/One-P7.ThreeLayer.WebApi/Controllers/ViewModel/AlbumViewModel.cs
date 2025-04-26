namespace ThreeLayer.WebApi.Controllers.ViewModel;

/// <summary>
/// 專輯 View Model
/// </summary>
public class AlbumViewModel
{
    /// <summary>
    /// 專輯編號
    /// </summary>
    public int AlbumId { get; set; }

    /// <summary>
    /// 專輯名稱
    /// </summary>
    public string Title { get; set; }

    /// <summary>
    /// 藝術家編號
    /// </summary>
    public int ArtistId { get; set; }

    /// <summary>
    /// 藝術家名稱
    /// </summary>
    public string ArtistName { get; set; }
}
