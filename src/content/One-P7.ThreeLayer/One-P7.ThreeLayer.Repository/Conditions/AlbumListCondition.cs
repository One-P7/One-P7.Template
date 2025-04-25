namespace ThreeLayer.Repository.Conditions;

/// <summary>
/// 專輯列表 Condition
/// </summary>
public class AlbumListCondition
{
    /// <summary>
    /// 頁碼
    /// </summary>
    public int Page { get; set; }

    /// <summary>
    /// 每頁筆數
    /// </summary>
    public int PageSize { get; set; }

    /// <summary>
    /// 降冪 / 升冪 排序
    /// </summary>
    public bool Descending { get; set; }

    /// <summary>
    /// 排序欄位
    /// </summary>
    public string Order { get; set; }
}
