namespace ThreeLayer.Service.Dtos;

/// <summary>
/// 專輯資料傳輸物件
/// </summary>
public class ListResultDto<T>
{
    /// <summary>
    /// 總筆數
    /// </summary>
    public int TotalCount { get; set; }

    /// <summary>
    /// 當前頁碼
    /// </summary>
    public int Page { get; set; }

    /// <summary>
    /// 每頁筆數
    /// </summary>
    public int PageSize { get; set; }

    /// <summary>
    /// 結果集合
    /// </summary>
    public IEnumerable<T> Results { get; set; }
}
