namespace ThreeLayer.Common.ViewModels;

/// <summary>
/// API 請求失敗的結果。
/// </summary>
public class FailInformation
{
    /// <summary>
    /// 錯誤代碼。
    /// </summary>
    public int ErrorCode { get; set; }

    /// <summary>
    /// 錯誤訊息。
    /// </summary>
    public string Message { get; set; }

    /// <summary>
    /// 錯誤描述。
    /// </summary>
    public string Description { get; set; }
}