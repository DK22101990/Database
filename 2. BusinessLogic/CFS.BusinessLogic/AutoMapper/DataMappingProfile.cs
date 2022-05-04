using AutoMapper;
using CFS.Data.Domains;
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
            CreateMap<Data.Domains.ComplianceType, ComplianceTypeViewModel>();
            CreateMap<AgileQuestion, AgileQuestionViewModel>();
            CreateMap<ProjectKickStartQuestions, ProjectKickStartQuestionViewModel>();
            CreateMap<Projects, ProjectViewModel>();
            CreateMap<SOW, SOWViewModel>();
            CreateMap<Data.Domains.Stage, StageViewModel>();
            CreateMap<SelectList, SelectListViewModel>();
            CreateMap<SprintInformation, SprintModel>();
            CreateMap<SprintDetailList, SprintModel>();
            CreateMap<AccountManagerMapList, AccountManagerMapModel>();
            CreateMap<ProjectAllocationList, ProjectAllocationModel>();
            CreateMap<EmployeeBillability, EmployeeBillabilityModel>();
        }
    }
}
