using ThreeLayer.Common.Enums;
using ThreeLayer.Repository.Interfaces;
using ThreeLayer.Repository.ResultModels;
using ThreeLayer.Service.Dtos;
using ThreeLayer.Service.Interfaces;

namespace ThreeLayer.Service.Implements;

/// <summary>
/// 員工服務 業務層
/// </summary>
public class EmployeeService:IEmployeeService
{
    private readonly IEmployeeRepository _employeeRepository;

    /// <summary>
    /// ctor
    /// </summary>
    public EmployeeService(IEmployeeRepository employeeRepository)
    {
        this._employeeRepository = employeeRepository;
    }

    /// <summary>
    /// 根據 Id 取得員工資訊
    /// </summary>
    /// <param name="id"></param>
    /// <returns></returns>
    public async Task<EmployeeDto> GetByIdAsync(int id)
    {
        var employeeInfo = await this._employeeRepository.GetByIdAsync(id);

        var dto = new EmployeeDto
        {
            EmployeeId = employeeInfo.EmployeeId,
            Name = employeeInfo.FirstName + employeeInfo.LastName,
            JobTitle = employeeInfo.JobTitle,
            JobFlag = this.GetJobFlag(employeeInfo),
            Department = employeeInfo.Department,
            Shift = employeeInfo.Shift,
            HireDate = employeeInfo.HireDate,
            EmailAddress = employeeInfo.EmailAddress,
            PhoneNumber = employeeInfo.PhoneNumber,
            IsLeaved = employeeInfo.LeavedDate.HasValue,
        };

        if (employeeInfo.HeadEmployeeId is null)
        {
            return dto;
        }

        var headEmployeeInfo = await this._employeeRepository.GetByIdAsync(employeeInfo.HeadEmployeeId.Value);

        if (headEmployeeInfo is null)
        {
            return dto;
        }

        dto.HeadEmployeeId = headEmployeeInfo.EmployeeId;
        dto.HeadName = headEmployeeInfo.FirstName + headEmployeeInfo.LastName;
        dto.HeadJobFlag = this.GetJobFlag(headEmployeeInfo);
        dto.HeadJobTitle = headEmployeeInfo.JobTitle;
        return dto;
    }
    
    /// <summary>
    /// 取得 JobFlag
    /// </summary>
    /// <param name="resultModel"></param>
    /// <returns></returns>
    private JobFlag GetJobFlag(EmployeeResultModel resultModel)
    {
        switch (resultModel.JobTitle)
        {
            case "Chief Executive Officer":
                return JobFlag.ChiefExecutiveOfficer;

            case "Vice President of Engineering":
            case "Vice President of Finance":
            case "Vice President of Sales":
            case "Vice President of Marketing":
                return JobFlag.VicePresident;

            case "Chief Financial Officer":
                return JobFlag.ChiefFinancialOfficer;

            case "Finance Manager":
                if (resultModel.OrganizationLevel == 2)
                {
                    return JobFlag.FinanceManager;
                }
                return JobFlag.Undefined;

            case "Research and Development Manager":
                if (resultModel.OrganizationLevel == 3)
                {
                    return JobFlag.ResearchAndDevelopmentManager;
                }
                return JobFlag.Undefined;

            case "Senior Design Engineer":
                if (resultModel.OrganizationLevel == 3)
                {
                    return JobFlag.SeniorDesignEngineer;
                }
                return JobFlag.Undefined;

            case "Design Engineer":
                if (resultModel.OrganizationLevel == 3)
                {
                    return JobFlag.DesignEngineer;
                }
                return JobFlag.Undefined;

            case "Senior Tool Designer":
                if (resultModel.OrganizationLevel == 3)
                {
                    return JobFlag.SeniorToolDesigner;
                }
                return JobFlag.Undefined;

            case "Tool Designer":
                if (resultModel.OrganizationLevel == 3)
                {
                    return JobFlag.ToolDesigner;
                }
                return JobFlag.Undefined;

            case "Marketing Manager":
                if (resultModel.OrganizationLevel == 2)
                {
                    return JobFlag.MarketingManagerSenior;
                }
                return JobFlag.Undefined;

            case "Marketing Specialist":
                if (resultModel.OrganizationLevel == 3)
                {
                    return JobFlag.MarketingSpecialist;
                }
                return JobFlag.Undefined;

            case "Human Resources Manager":
                if (resultModel.OrganizationLevel == 2)
                {
                    return JobFlag.HumanResourcesManager;
                }
                return JobFlag.Undefined;

            case "Human Resources Representative":
                if (resultModel.OrganizationLevel == 3)
                {
                    return JobFlag.HumanResourcesRepresentative;
                }
                return JobFlag.Undefined;

            case "Senior Purchase Agent":
                if (resultModel.OrganizationLevel == 2)
                {
                    return JobFlag.SeniorPurchaseAgentSenior;
                }
                return JobFlag.Undefined;

            case "Purchasing Agent":
                if (resultModel.OrganizationLevel == 3)
                {
                    return JobFlag.PurchasingAgent;
                }
                return JobFlag.Undefined;

            case "Quality Assurance Manager":
                if (resultModel.OrganizationLevel == 2)
                {
                    return JobFlag.QualityAssuranceManagerSenior;
                }
                return JobFlag.Undefined;

            case "Quality Assurance Technician":
                if (resultModel.OrganizationLevel == 3)
                {
                    return JobFlag.QualityAssuranceTechnician;
                }
                return JobFlag.Undefined;

            case "Executive Assistant":
                return JobFlag.ExecutiveAssistant;

            case "Administrative Assistant":
                return JobFlag.AdministrativeAssistant;

            case "Control":
                if (resultModel.OrganizationLevel == 2)
                {
                    return JobFlag.ProductionControlSenior;
                }
                if (resultModel.OrganizationLevel == 3)
                {
                    return JobFlag.ProductionControl;
                }
                return JobFlag.Undefined;

            case "Supervisor":
                if (resultModel.OrganizationLevel == 2)
                {
                    return JobFlag.SupervisorSenior;
                }
                if (resultModel.OrganizationLevel == 3)
                {
                    return JobFlag.Supervisor;
                }
                return JobFlag.Undefined;

            case "Technician":
                if (resultModel.OrganizationLevel == 3)
                {
                    return JobFlag.TechnicianIntermediate;
                }
                if (resultModel.OrganizationLevel == 4)
                {
                    return JobFlag.TechnicianJunior;
                }
                return JobFlag.Undefined;

            default:
                return JobFlag.Other;
        }
    }
}