using Microsoft.AspNetCore.Mvc;
using ThreeLayer.Service.Dtos;
using ThreeLayer.Service.Interfaces;
using ThreeLayer.WebApi.Controllers.ViewModel;

namespace ThreeLayer.WebApi.Controllers;

/// <summary>
/// 員工控制器
/// </summary>
/// <remarks>
/// ctor
/// </remarks>
/// <param name="employeeService"></param>
[ApiController]
[Route("api/v1/employees")]
public class EmployeeController(IEmployeeService employeeService) : ControllerBase
{
    private readonly IEmployeeService _employeeService = employeeService;

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
            Name = $"{dto.FirstName} {dto.LastName}",
            Title = dto.Title,
            HeadEmployeeId = dto.HeadEmployeeId,
            HeadEmployee = ParseToHeadEmployeeViewModel(dto),
            BirthDate = dto.BirthDate,
            HireDate = dto.HireDate,
            Address = dto.Address,
            City = dto.City,
            State = dto.State,
            Country = dto.Country,
            PostalCode = dto.PostalCode,
            Phone = dto.Phone,
            Fax = dto.Fax,
            Email = dto.Email
        };

        return this.Ok(viewModel);
    }

    /// <summary>
    /// 轉換上級主管資訊
    /// </summary>
    /// <param name="dto"></param>
    /// <returns></returns>
    private static SimpleEmployeeViewModel ParseToHeadEmployeeViewModel(EmployeeDto dto)
    {
        if (dto.HeadEmployee is null)
        {
            return null;
        }

        return new SimpleEmployeeViewModel
        {
            EmployeeId = dto.HeadEmployee.EmployeeId,
            LastName = dto.HeadEmployee.LastName,
            FirstName = dto.HeadEmployee.FirstName,
            Title = dto.HeadEmployee.Title
        };
    }
}