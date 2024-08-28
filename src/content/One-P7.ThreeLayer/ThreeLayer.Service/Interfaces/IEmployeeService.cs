using ThreeLayer.Service.Dtos;

namespace ThreeLayer.Service.Interfaces;

/// <summary>
/// 員工服務
/// </summary>
public interface IEmployeeService
{
    Task<EmployeeDto> GetByIdAsync(int id);
}