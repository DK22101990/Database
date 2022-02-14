using CFS.Data.Context;
using CFS.Data.Domains;
using CFS.Data.IRepositories;
using CFS.Model.Constants;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using CFS.Model.Models;
using CFS.Data.Models;

namespace CFS.Data.Repositories
{
    public class AccountRepository : Repository, IAccountRepository
    {
        #region Constructor

        public AccountRepository(CFSContext applicationDbContext) : base(applicationDbContext)
        {
        }

        #endregion Constructor

        #region Methods

        /// <summary>
        /// Get Account List
        /// </summary>
        /// <returns></returns>
        public async Task<List<AccountList>> GetAccountList()
        {
            var commandText = string.Format(StoreProcedure.AccountList);
            return await Context.GetAccountList.FromSqlRaw<AccountList>(commandText).ToListAsync();
        }

        /// <summary>
        /// Get ComplianceType List
        /// </summary>
        /// <returns></returns>
        public async Task<List<Domains.ComplianceType>> GetComplianceTypeList(int RoleId)
        {
            var commandText = string.Format(StoreProcedure.ComplianceTypeList, RoleId);
            return await Context.GetComplianceTypeList.FromSqlRaw<Domains.ComplianceType>(commandText).ToListAsync();
        }

        /// <summary>
        /// Get Agile Questions
        /// </summary>
        /// <param name="RoleId"></param>
        /// <returns></returns>
        public async Task<List<AgileQuestion>> GetAgileQuestionList(int ComplianceTypeId,
            int ProjectId,
            int AccountId,
            int SowId,
            int StageId,
            int SprintId)
        {
            var commandText = string.Format(StoreProcedure.AgileQuestionList, ComplianceTypeId, ProjectId, AccountId, SowId, StageId, SprintId);
            return await Context.GetAgileQuestionList.FromSqlRaw<AgileQuestion>(commandText).ToListAsync();
        }

        /// <summary>
        /// Get Project KickStart Questions
        /// </summary>
        /// <param name="RoleId"></param>
        /// <returns></returns>
        public async Task<List<ProjectKickStartQuestions>> GetProjectKickStartQuestionList(int ComplianceTypeId,
            int ProjectId,
            int AccountId,
            int SowId,
            int StageId)
        {
            var commandText = string.Format(StoreProcedure.ProjectKickstartQuestionList, ComplianceTypeId, ProjectId, AccountId, SowId, StageId);
            return await Context.GetProjectKickStartQuestionList.FromSqlRaw<ProjectKickStartQuestions>(commandText).ToListAsync();
        }

        /// <summary>
        /// Get Projects
        /// </summary>
        /// <param name="AccountId"></param>
        /// <returns></returns>
        public async Task<List<Projects>> GetProjectList(int AccountId)
        {
            var commandText = string.Format(StoreProcedure.ProjectList, AccountId);
            return await Context.GetProjectList.FromSqlRaw<Projects>(commandText).ToListAsync();
        }

        /// <summary>
        /// Get SOW
        /// </summary>
        /// <param name="ProjectId"></param>
        /// <returns></returns>
        public async Task<List<SOW>> GetSOWList(int ProjectId)
        {
            var commandText = string.Format(StoreProcedure.SOWList, ProjectId);
            return await Context.GetSowList.FromSqlRaw<SOW>(commandText).ToListAsync();
        }

        /// <summary>
        /// Get Stage
        /// </summary>
        /// <param name="RoleId"></param>
        /// <returns></returns>
        public async Task<List<Domains.Stage>> GetStageList(int ProjectId, int ComplianceTypeId)
        {
            var commandText = string.Format(StoreProcedure.StageList, ProjectId, ComplianceTypeId);
            return await Context.GetStageList.FromSqlRaw<Domains.Stage>(commandText).ToListAsync();
        }

        /// <summary>
        /// Insert Kick Start Question
        /// </summary>
        /// <returns></returns>
        public async Task InsertProjectKickStartQuestion(InsertQuestion kickStartResponse)
        {
            var commandText = string.Format(StoreProcedure.InsertKickStartResponse,
                kickStartResponse.AccountId,
                kickStartResponse.ProjectId,
                kickStartResponse.SowId,
                kickStartResponse.StageId,
                kickStartResponse.ComplianceTypeId,
                kickStartResponse.QuestionId,
                kickStartResponse.ComplianceStatusId,
                kickStartResponse.Comments,
                kickStartResponse.CommentsTypeId,
                kickStartResponse.ArtefactId,
                kickStartResponse.Isactive);
            await Context.Database.ExecuteSqlRawAsync(commandText);
        }

        /// <summary>
        /// Insert SOW Kick Start Question
        /// </summary>
        /// <returns></returns>
        public async Task InsertSOWKickStartQuestion(InsertQuestion kickStartResponse)
        {
            var commandText = string.Format(StoreProcedure.InsertSOWKickStartQuestion,
                kickStartResponse.AccountId,
                kickStartResponse.ProjectId,
                kickStartResponse.SowId,
                kickStartResponse.StageId,
                kickStartResponse.ComplianceTypeId,
                kickStartResponse.QuestionId,
                kickStartResponse.ComplianceStatusId,
                kickStartResponse.Comments,
                kickStartResponse.CommentsTypeId,
                kickStartResponse.ArtefactId);
            await Context.Database.ExecuteSqlRawAsync(commandText);
        }

        /// <summary>
        /// Insert Sprint Kick Start Question
        /// </summary>
        /// <returns></returns>
        public async Task InsertSprintKickStartQuestion(InsertQuestion kickStartResponse)
        {
            var commandText = string.Format(StoreProcedure.InsertSprintKickStartQuestion,
                kickStartResponse.AccountId,
                kickStartResponse.ProjectId,
                kickStartResponse.SowId,
                kickStartResponse.StageId,
                kickStartResponse.ComplianceTypeId,
                kickStartResponse.QuestionId,
                kickStartResponse.SprintId,
                kickStartResponse.ComplianceStatusId,
                kickStartResponse.Comments,
                kickStartResponse.CommentsTypeId,
                kickStartResponse.ArtefactId);
            await Context.Database.ExecuteSqlRawAsync(commandText);
        }

        /// <summary>
        /// Get Master List
        /// </summary>
        /// <returns></returns>
        public async Task<List<SelectList>> GetMasterList(string Entity)
        {
            var commandText = string.Format(StoreProcedure.MasterList, Entity);
            return await Context.GetMasterList.FromSqlRaw<SelectList>(commandText).ToListAsync();
        }

        /// <summary>
        /// Add Artifact
        /// </summary>
        /// <param name="artefact"></param>
        /// <returns></returns>
        public async Task<Artefact> AddArtifactAsync(Artefact artefact)
        {

            Context.Artefacts.Add(artefact);
            await Context.SaveChangesAsync();
            return artefact;
        }
        #endregion
    }
}
