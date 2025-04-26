namespace ThreeLayer.Repository.ResultModels;

/// <summary>
/// 員工資訊結果資料模型
/// </summary>
public class EmployeeResultModel
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

    /// <summary>
    /// 上級主管編號
    /// </summary>
    public int? ReportsTo { get; set; }

    /// <summary>
    /// 出生日期
    /// </summary>
    public DateTime? BirthDate { get; set; }

    /// <summary>
    /// 雇用日期
    /// </summary>
    public DateTime? HireDate { get; set; }

    /// <summary>
    /// 地址
    /// </summary>
    public string Address { get; set; }

    /// <summary>
    /// 城市
    /// </summary>
    public string City { get; set; }

    /// <summary>
    /// 州/省
    /// </summary>
    public string State { get; set; }

    /// <summary>
    /// 國家
    /// </summary>
    public string Country { get; set; }

    /// <summary>
    /// 郵遞區號
    /// </summary>
    public string PostalCode { get; set; }

    /// <summary>
    /// 電話號碼
    /// </summary>
    public string Phone { get; set; }

    /// <summary>
    /// 傳真號碼
    /// </summary>
    public string Fax { get; set; }

    /// <summary>
    /// 電子郵件地址
    /// </summary>
    public string Email { get; set; }
}