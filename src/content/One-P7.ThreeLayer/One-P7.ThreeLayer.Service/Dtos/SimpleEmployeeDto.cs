namespace ThreeLayer.Service.Dtos;

/// <summary>
/// 簡易員工資訊資
/// </summary>
public class SimpleEmployeeDto
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
