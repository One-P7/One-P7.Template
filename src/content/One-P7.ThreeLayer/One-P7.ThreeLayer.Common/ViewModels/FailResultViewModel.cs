namespace ThreeLayer.Common.ViewModels;

/// <summary>
/// API 請求失敗的結果模型。
/// </summary>
public class FailResultViewModel
{
    /// <summary>
    /// 請求的唯一識別碼。
    /// </summary>
    public string Id { get; set; }

    /// <summary>
    /// api 版本
    /// </summary>
    public string ApiVersion { get; set; }

    /// <summary>
    /// api 名稱
    /// </summary>
    public string Method { get; set; }

    /// <summary>
    /// Request 狀態
    /// </summary>
    public string Status { get; set; }

    /// <summary>
    /// 錯誤資訊
    /// </summary>
    public FailInformation Error { get; set; }
}