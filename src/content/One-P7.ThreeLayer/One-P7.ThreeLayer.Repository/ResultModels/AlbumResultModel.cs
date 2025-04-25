namespace ThreeLayer.Repository.ResultModels;

/// <summary>
/// 專輯 ResultModel
/// </summary>
public class AlbumResultModel
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

    /// <summary>
    /// 專輯類型
    /// </summary>
    public string Genre { get; set; }

    /// <summary>
    /// 專輯價格
    /// </summary>
    public decimal Price { get; set; }
}
