using ThreeLayer.Common.Enums;

namespace ThreeLayer.Service.Dtos;

public class EmployeeDto
{
    /// <summary>
    /// 員工編號
    /// </summary>
    public int EmployeeId { get; set; }

    /// <summary>
    /// 員工姓名
    /// </summary>
    public string Name { get; set; }

    /// <summary>
    /// 職位
    /// </summary>
    public JobFlag JobFlag { get; set; }

    /// <summary>
    /// 職位名稱
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
    /// 是否離職
    /// </summary>
    public bool IsLeaved { get; set; }

    /// <summary>
    /// 主管員工編號
    /// </summary>
    public int? HeadEmployeeId { get; set; }

    /// <summary>
    /// 主管姓名
    /// </summary>
    public string HeadName { get; set; }

    /// <summary>
    /// 主管職位
    /// </summary>
    public JobFlag HeadJobFlag { get; set; }

    /// <summary>
    /// 主管職位
    /// </summary>
    public string HeadJobTitle { get; set; }
}