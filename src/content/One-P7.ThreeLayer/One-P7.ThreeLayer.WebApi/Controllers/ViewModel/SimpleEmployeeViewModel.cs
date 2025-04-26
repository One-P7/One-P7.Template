namespace ThreeLayer.WebApi.Controllers.ViewModel;

/// <summary>
/// 簡易員工資訊
/// </summary>
public class SimpleEmployeeViewModel
{
    /// <summary>
    /// 員工編號
    /// </summary>
    public int EmployeeId { get; set; }

    /// <summary>
    /// 姓
    /// </summary>
    public string LastName { get; set; }

    /// <summary>
    /// 名
    /// </summary>
    public string FirstName { get; set; }

    /// <summary>
    /// 職稱
    /// </summary>
    public string Title { get; set; }
}