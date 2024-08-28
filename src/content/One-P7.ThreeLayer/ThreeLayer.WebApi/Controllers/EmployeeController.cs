using Microsoft.AspNetCore.Mvc;
using ThreeLayer.Service.Interfaces;
using ThreeLayer.WebApi.Controllers.ViewModel;

namespace ThreeLayer.WebApi.Controllers;

/// <summary>
/// 員工控制器
/// </summary>
[ApiController]
[Route("api/v1/employees")]
public class EmployeeController : ControllerBase
{
    private readonly IEmployeeService _employeeService;
    
    /// <summary>
    /// ctor
    /// </summary>
    /// <param name="employeeService"></param>
    public EmployeeController(IEmployeeService employeeService)
    {
        this._employeeService = employeeService;
    }
    
    /// <summary>
    /// 取得員工資訊
    /// </summary>
    /// <returns></returns>
    [HttpGet("{id:int}")]
    public async Task<IActionResult> GetEmployeeInfoAsync([FromRoute] int id)
    {
        var dto = await this._employeeService.GetByIdAsync(id);

        var viewModel = new EmployeeViewModel
        {
            EmployeeId = dto.EmployeeId,
            Name = dto.Name,
            JobFlag = dto.JobFlag,
            JobTitle = dto.JobTitle,
            Department = dto.Department,
            Shift = dto.Shift,
            HireDate = dto.HireDate,
            EmailAddress = dto.EmailAddress,
            PhoneNumber = dto.PhoneNumber,
            IsLeaved = dto.IsLeaved,
            HeadEmployeeId = dto.HeadEmployeeId,
            HeadName = dto.HeadName,
            HeadJobFlag = dto.HeadJobFlag,
            HeadJobTitle = dto.HeadJobTitle,

        };

        return this.Ok(viewModel);
    }
}