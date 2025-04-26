using ThreeLayer.Repository.Interfaces;
using ThreeLayer.Repository.ResultModels;
using ThreeLayer.Service.Dtos;
using ThreeLayer.Service.Interfaces;

namespace ThreeLayer.Service.Implements;

/// <summary>
/// 員工服務 業務層
/// </summary>
/// <remarks>
/// ctor
/// </remarks>
public class EmployeeService(IEmployeeRepository employeeRepository) : IEmployeeService
{
    /// <summary>
    /// 根據 Id 取得員工資訊
    /// </summary>
    /// <param name="id"></param>
    /// <returns></returns>
    public async Task<EmployeeDto> GetByIdAsync(int id)
    {
        var resultModel = await employeeRepository.GetByIdAsync(id);
        if (resultModel is null)
        {
            return null;
        }

        var dto = new EmployeeDto
        {
            EmployeeId = resultModel.EmployeeId,
            LastName = resultModel.LastName,
            FirstName = resultModel.FirstName,
            Title = resultModel.Title,
            HeadEmployeeId = resultModel.ReportsTo,
            HeadEmployee = await this.GetHeadEmployee(resultModel),
            BirthDate = resultModel.BirthDate,
            HireDate = resultModel.HireDate,
            Address = resultModel.Address,
            City = resultModel.City,
            State = resultModel.State,
            Country = resultModel.Country,
            PostalCode = resultModel.PostalCode,
            Phone = resultModel.Phone,
            Fax = resultModel.Fax,
            Email = resultModel.Email
        };

        return dto;
    }

    /// <summary>
    /// 取得上級主管資訊
    /// </summary>
    /// <param name="resultModel"></param>
    /// <returns></returns>
    private async Task<SimpleEmployeeDto> GetHeadEmployee(EmployeeResultModel resultModel)
    {
        if (resultModel.ReportsTo is null)
        {
            return null;
        }

        var result = await employeeRepository.GetByIdAsync(resultModel.ReportsTo.Value);
        if (result is null)
        {
            return null;
        }

        var headEmployee = new SimpleEmployeeDto
        {
            EmployeeId = result.EmployeeId,
            LastName = result.LastName,
            FirstName = result.FirstName,
            Title = result.Title
        };

        return headEmployee;
    }
}