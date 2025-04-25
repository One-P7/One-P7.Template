namespace ThreeLayer.Repository.ResultModels;

public class ListResultModel<T>
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
