namespace ThreeLayer.Repository.ResultModels;

/// <summary>
/// 員工資訊結果資料模型
/// </summary>
public class EmployeeResultModel
{
    /// <summary>
    /// 獲取或設置員工的唯一識別碼
    /// </summary>
    public int EmployeeId { get; set; }

    /// <summary>
    /// 獲取或設置員工的名字
    /// </summary>
    public string FirstName { get; set; }

    /// <summary>
    /// 獲取或設置員工的姓氏
    /// </summary>
    public string LastName { get; set; }

    /// <summary>
    /// 獲取或設置員工的職稱
    /// </summary>
    public string JobTitle { get; set; }

    /// <summary>
    /// 獲取或設置員工所屬的部門名稱
    /// </summary>
    public string Department { get; set; }

    /// <summary>
    /// 獲取或設置員工的班次名稱
    /// </summary>
    public string Shift { get; set; }

    /// <summary>
    /// 獲取或設置員工的入職日期
    /// </summary>
    public DateOnly HireDate { get; set; }

    /// <summary>
    /// 獲取或設置員工的電子郵件地址
    /// </summary>
    public string EmailAddress { get; set; }

    /// <summary>
    /// 獲取或設置員工的電話號碼
    /// </summary>
    public string PhoneNumber { get; set; }

    /// <summary>
    /// 離職日期
    /// </summary>
    public DateOnly? LeavedDate { get; set; }

    /// <summary>
    /// 組織層級
    /// </summary>
    public int? OrganizationLevel { get; set; }

    /// <summary>
    /// 主管員工編號
    /// </summary>
    public int? HeadEmployeeId { get; set; }
}