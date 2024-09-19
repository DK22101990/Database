using AutoMapper;
using CFS.Data.Domains;
using CFS.Data.Models;
using CFS.Model.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CFS.BusinessLogic.AutoMapper
{
    public class DataMappingProfile : Profile
    {
        public DataMappingProfile()
        {
            CreateMap<AccountList, AccountListViewModel>();
            CreateMap<SprintList, SprintViewModel>();
            CreateMap<EmpMonthlyHoursList   , EmpMonthlyHoursViewModel>();
            CreateMap<GetYearsList, GetYearsModel>();
            CreateMap<GetMonthsList, GetMonthsModel>();
            CreateMap<Data.Domains.ComplianceType, ComplianceTypeViewModel>();
            CreateMap<AgileQuestion, AgileQuestionViewModel>();
            CreateMap<ProjectKickStartQuestions, ProjectKickStartQuestionViewModel>();
            CreateMap<Projects, ProjectViewModel>();
            CreateMap<ProjectDomain, ProjectDomainViewModel>();
            CreateMap<SOW, SOWViewModel>();
            CreateMap<Data.Domains.Stage, StageViewModel>();
            CreateMap<SelectList, SelectListViewModel>();
            CreateMap<SprintInformation, SprintModel>();
            CreateMap<SprintDetailList, SprintModel>();
            CreateMap<AccountManagerMapList, AccountManagerMapModel>();
            CreateMap<ProjectAllocationList, ProjectAllocationModel>();
            CreateMap<EmployeeBillability, EmployeeBillabilityModel>();
            CreateMap<EmployeeDetails, EmployeeDetailsModel>();
            CreateMap<InsertProjectResponse, InsertProjectResponseModel>();
            CreateMap<UpdateProjectResponse, UpdateProjectResponseModel>();
            CreateMap<ProjectResponse, ProjectViewModel>();
            CreateMap<SowResponse, SOWViewModel>();
            CreateMap<ProjectAccountManagerList, ProjectAccountManagerViewModel>();
            CreateMap<BilllabilityandUtilizationList, BillabilityandUtilizationModel>();
            CreateMap<SowDataResponse, SowDataViewModel>();
            CreateMap<AccountResponseList, AccountResponseViewModel>();
            CreateMap<InsertAccountResponse, InsertAccountResponseModel>();
            CreateMap<UpdateAccountResponse, UpdateAccountResponseModel>();
            CreateMap<InsertProjectAllocationList, InsertProjectAllocation>();
            CreateMap<UpdateProjectAllocationList, UpdateProjectAllocation>();
        }
    }
}
