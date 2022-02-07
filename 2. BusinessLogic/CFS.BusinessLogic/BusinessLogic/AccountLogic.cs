using AutoMapper;
using CFS.BusinessLogic.IBusinessLogic;
using CFS.Data.Domains;
using CFS.Data.IRepositories;
using CFS.Model.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CFS.BusinessLogic.BusinessLogic
{
    public class AccountLogic : IAccountLogic
    {
        #region Variables

        private readonly IAccountRepository _iAccountRepository;

        #endregion Variables

        #region Constructor
        public AccountLogic(IAccountRepository iAccountRepository)
        {
            _iAccountRepository = iAccountRepository;
        }

        #endregion Constructor

        #region Methods

        /// <summary>
        /// Get Account List
        /// </summary>
        /// <returns></returns>
        public async Task<List<AccountListViewModel>> GetAccountList()
        {
            var config = new MapperConfiguration(cfg => {
                cfg.CreateMap<AccountList, AccountListViewModel>();
            });

            IMapper mapper = config.CreateMapper();
            return mapper.Map<List<AccountListViewModel>>(await _iAccountRepository.GetAccountList());
        }

        /// <summary>
        /// Get ComplianceType List
        /// </summary>
        /// <returns></returns>
        public async Task<List<ComplianceTypeViewModel>> GetComplianceTypeList(int RoleId)
        {
            var config = new MapperConfiguration(cfg => {
                cfg.CreateMap<ComplianceType, ComplianceTypeViewModel>();
            });

            IMapper mapper = config.CreateMapper();
            return mapper.Map<List<ComplianceTypeViewModel>>(await _iAccountRepository.GetComplianceTypeList(RoleId));
        }

        /// <summary>
        ///  Get Agile Questions
        /// </summary>
        /// <returns></returns>
        public async Task<List<AgileQuestionViewModel>> GetAgileQuestionList(int ComplianceTypeId,
            int ProjectId,
            int AccountId,
            int SowId,
            int StageId,
            int SprintId)
        {
            var config = new MapperConfiguration(cfg => {
                cfg.CreateMap<AgileQuestion, AgileQuestionViewModel>();
            });

            IMapper mapper = config.CreateMapper();
            return mapper.Map<List<AgileQuestionViewModel>>(await _iAccountRepository.GetAgileQuestionList(ComplianceTypeId,
                ProjectId,
                AccountId,
                SowId,
                StageId,
                SprintId));
        }

        /// <summary>
        ///  Get Agile Questions
        /// </summary>
        /// <returns></returns>
        public async Task<List<ProjectKickStartQuestionViewModel>> GetProjectKickStartQuestionList(int ComplianceTypeId,
            int ProjectId,
            int AccountId,
            int SowId,
            int StageId)
        {
            var config = new MapperConfiguration(cfg => {
                cfg.CreateMap<AgileQuestion, ProjectKickStartQuestionViewModel>();
            });

            IMapper mapper = config.CreateMapper();
            return mapper.Map<List<ProjectKickStartQuestionViewModel>>(await _iAccountRepository.GetProjectKickStartQuestionList(ComplianceTypeId,
                ProjectId,
                AccountId,
                SowId,
                StageId));
        }

        /// <summary>
        /// Get Project List
        /// </summary>
        /// <returns></returns>
        public async Task<List<ProjectViewModel>> GetProjectList(int AccountId)
        {
            var config = new MapperConfiguration(cfg => {
                cfg.CreateMap<Projects, ProjectViewModel>();
            });

            IMapper mapper = config.CreateMapper();
            return mapper.Map<List<ProjectViewModel>>(await _iAccountRepository.GetProjectList(AccountId));
        }

        /// <summary>
        /// Get SOW List
        /// </summary>
        /// <returns></returns>
        public async Task<List<SOWViewModel>> GetSOWList(int ProjectId)
        {
            var config = new MapperConfiguration(cfg => {
                cfg.CreateMap<SOW, SOWViewModel>();
            });

            IMapper mapper = config.CreateMapper();
            return mapper.Map<List<SOWViewModel>>(await _iAccountRepository.GetSOWList(ProjectId));
        }

        /// <summary>
        /// Get Stage List
        /// </summary>
        /// <returns></returns>
        public async Task<List<StageViewModel>> GetStageList(int ProjectId, int ComplianceTypeId)
        {
            var config = new MapperConfiguration(cfg => {
                cfg.CreateMap<Stage, StageViewModel>();
            });

            IMapper mapper = config.CreateMapper();
            return mapper.Map<List<StageViewModel>>(await _iAccountRepository.GetStageList(ProjectId, ComplianceTypeId));
        }

        /// <summary>
        ///  Post Kick Start Response
        /// </summary>
        /// <returns></returns>
        public async Task InsertProjectKickStartQuestion(InsertQuestion kickStartResponse)
        {
            await _iAccountRepository.InsertProjectKickStartQuestion(kickStartResponse);
        }

        /// <summary>
        ///  Post SOW Kick Start Question
        /// </summary>
        /// <returns></returns>
        public async Task InsertSOWKickStartQuestion(InsertQuestion kickStartResponse)
        {
            await _iAccountRepository.InsertSOWKickStartQuestion(kickStartResponse);
        }

        /// <summary>
        ///  Post Sprint Kick Start Question
        /// </summary>
        /// <returns></returns>
        public async Task InsertSprintKickStartQuestion(InsertQuestion kickStartResponse)
        {
            await _iAccountRepository.InsertSprintKickStartQuestion(kickStartResponse);
        }

        /// <summary>
        /// Get Master List
        /// </summary>
        /// <returns></returns>
        public async Task<List<SelectListViewModel>> GetMasterList(string Entity)
        {
            var config = new MapperConfiguration(cfg => {
                cfg.CreateMap<SelectList, SelectListViewModel>();
            });

            IMapper mapper = config.CreateMapper();
            return mapper.Map<List<SelectListViewModel>>(await _iAccountRepository.GetMasterList(Entity));
        }
        #endregion
    }
}
