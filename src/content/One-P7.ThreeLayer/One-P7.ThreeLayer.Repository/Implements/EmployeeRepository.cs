using Microsoft.EntityFrameworkCore;
using ThreeLayer.Database.ChinookDbSqlite;
using ThreeLayer.Repository.Interfaces;
using ThreeLayer.Repository.ResultModels;

namespace ThreeLayer.Repository.Implements;

/// <summary>
/// 員工資訊 Repository
/// </summary>
/// <remarks>
/// ctor
/// </remarks>
/// <param name="chinookSqliteContext"></param>
public class EmployeeRepository(ChinookSqliteContext chinookSqliteContext) : IEmployeeRepository
{
    /// <summary>
    /// 根據 id 取得員工編號
    /// </summary>
    /// <param name="id"></param>
    /// <returns></returns>
    /// <exception cref="NotImplementedException"></exception>
    public async Task<EmployeeResultModel> GetByIdAsync(int id)
    {
        var result = await chinookSqliteContext.Employees
            .Where(e => e.EmployeeId == id)
            .Select(e => new EmployeeResultModel
            {
                EmployeeId = e.EmployeeId,
                FirstName = e.FirstName,
                LastName = e.LastName,
                Title = e.Title,
                ReportsTo = e.ReportsTo,
                Address = e.Address,
                City = e.City,
                State = e.State,
                Country = e.Country,
                PostalCode = e.PostalCode,
                Phone = e.Phone,
                Fax = e.Fax,
                Email = e.Email
            })
            .FirstOrDefaultAsync();

        return result;
    }
}