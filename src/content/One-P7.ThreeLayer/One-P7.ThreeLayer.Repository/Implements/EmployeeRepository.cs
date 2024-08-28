using Microsoft.EntityFrameworkCore;
using ThreeLayer.Database.AdventureWorks;
using ThreeLayer.Repository.Interfaces;
using ThreeLayer.Repository.ResultModels;

namespace ThreeLayer.Repository.Implements;

/// <summary>
/// 員工資訊 Repository
/// </summary>
public class EmployeeRepository:IEmployeeRepository
{
    private readonly AdventureWorksContext _adventureWorksContext;

    /// <summary>
    /// ctor
    /// </summary>
    /// <param name="adventureWorksContext"></param>
    public EmployeeRepository(AdventureWorksContext adventureWorksContext)
    {
        this._adventureWorksContext = adventureWorksContext;
    }

    /// <summary>
    /// 根據 id 取得員工編號
    /// </summary>
    /// <param name="id"></param>
    /// <returns></returns>
    /// <exception cref="NotImplementedException"></exception>
    public async Task<EmployeeResultModel> GetByIdAsync(int id)
    {
        var employee = await (
            from e in this._adventureWorksContext.Employees
            join p in this._adventureWorksContext.People on
                e.BusinessEntityId equals p.BusinessEntityId
            join edh in this._adventureWorksContext.EmployeeDepartmentHistories on
                e.BusinessEntityId equals edh.BusinessEntityId
            join d in this._adventureWorksContext.Departments on
                edh.DepartmentId equals d.DepartmentId
            join s in this._adventureWorksContext.Shifts on
                edh.ShiftId equals s.ShiftId
            join ea in this._adventureWorksContext.EmailAddresses on
                p.BusinessEntityId equals ea.BusinessEntityId into emailGroup
            from email in emailGroup.DefaultIfEmpty()
            join pp in this._adventureWorksContext.PersonPhones on p.BusinessEntityId equals pp.BusinessEntityId into phoneGroup
            from phone in phoneGroup.DefaultIfEmpty()
            where e.BusinessEntityId == id
            select new EmployeeResultModel
            {
                EmployeeId = e.BusinessEntityId,
                FirstName = p.FirstName,
                LastName = p.LastName,
                JobTitle = e.JobTitle,
                Department = d.Name,
                Shift = s.Name,
                HireDate = e.HireDate,
                EmailAddress = email.EmailAddress1,
                PhoneNumber = phone.PhoneNumber,
                LeavedDate = edh.EndDate,
                OrganizationLevel = e.OrganizationLevel,
                HeadEmployeeId = (from pm in this._adventureWorksContext.Employees
                             where e.OrganizationNode.GetAncestor(1) == pm.OrganizationNode
                             select pm.BusinessEntityId).FirstOrDefault(),
            }).FirstOrDefaultAsync();

        return employee;
    }
}