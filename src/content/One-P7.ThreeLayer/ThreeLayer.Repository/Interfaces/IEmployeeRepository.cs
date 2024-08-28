using ThreeLayer.Repository.ResultModels;

namespace ThreeLayer.Repository.Interfaces;

/// <summary>
/// 員工資訊 Repository
/// </summary>
public interface IEmployeeRepository
{
    /// <summary>
    /// 根據 id 取得員工編號
    /// </summary>
    /// <param name="id"></param>
    /// <returns></returns>
    Task<EmployeeResultModel> GetByIdAsync(int id);
}