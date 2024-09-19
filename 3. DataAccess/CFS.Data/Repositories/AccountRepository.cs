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
        /// Get Account Response
        /// </summary>
        /// <returns></returns>
        public async Task<List<AccountResponseList>> GetAccountResponseList()
        {
            var commandText = string.Format(StoreProcedure.GetAccountResponseList);
            return await Context.GetAccountResponseList.FromSqlRaw<AccountResponseList>(commandText).ToListAsync();
        }
        /// <summary>
        /// Get All Sprints
        /// </summary>
        /// <param name="ProjectId"></param>
        /// <param name="SowId"></param>
        /// <returns></returns>
        public async Task<List<SprintList>> GetSprintList(int SowId)
        {
            var commandText = string.Format(StoreProcedure.SprintList, SowId);
            return await Context.GetSprintList.FromSqlRaw<SprintList>(commandText).ToListAsync();
        }

        /// <summary>
        /// Get ComplianceType List
        /// </summary>
        /// <returns></returns>
        public async Task<List<Domains.ComplianceType>> GetComplianceTypeList(int StageId)
        {
            var commandText = string.Format(StoreProcedure.ComplianceTypeList, StageId);
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
        //
        /// <returns></returns>
        /// 

        public async Task<List<ProjectDomain>> GetProjectDomainList()
        {
            var commandText = string.Format(StoreProcedure.ProjectDomainList);
            return await Context.GetProjectDomainList.FromSqlRaw<ProjectDomain>(commandText).ToListAsync();
        }



        /// <summary>
        /// Get SOW
        /// </summary>
        /// <param name="ProjectId"></param>
        /// <param name="AccountId"></param>
        /// <returns></returns>
        public async Task<List<SOW>> GetSOWList(int ProjectId, int AccountId)
        {
            var commandText = string.Format(StoreProcedure.SOWList, ProjectId, AccountId);
            return await Context.GetSowList.FromSqlRaw<SOW>(commandText).ToListAsync();
        }

        /// <summary>
        /// Get Stage
        /// </summary>
        /// <param name="RoleId"></param>
        /// <returns></returns>
        public async Task<List<Domains.Stage>> GetStageList()
        {
            var commandText = string.Format(StoreProcedure.StageList);
            return await Context.GetStageList.FromSqlRaw<Domains.Stage>(commandText).ToListAsync();
        }

        /// <summary>
        /// Get Question List
        /// </summary>
        /// <param name="StageId"></param>
        /// <param name="ComplianceTypeId"></param>
        /// <returns></returns>
        public async Task<List<Domains.QuestionList>> GetQuestionList(int StageId, int ComplianceTypeId)
        {
            var commandText = string.Format(StoreProcedure.QuestionList, StageId, ComplianceTypeId);
            return await Context.GetQuestionList.FromSqlRaw<Domains.QuestionList>(commandText).ToListAsync();
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


        public async Task SaveSowQuestionResponse(SaveSowQuestionResponse request)
        {
            var commandText = string.Format(StoreProcedure.SaveSowQuestionResponse,
                request.AccountId,
                request.ProjectId,
                request.SowId,
                request.StageId,
                request.ComplianceTypeId,
                request.QuestionId,
                request.ComplianceStatusId,
                request.Comments,
                request.CommentsTypeId,
                request.FileName,
                request.FilePath,
                request.FileSize,
                request.DisplayName,
                request.IsUploaded,
                request.ArtefactId);
            await Context.Database.ExecuteSqlRawAsync(commandText);
        }


        public async Task SaveAgileQuestionResponse(SaveAgileQuestionResponse request)
        {
            var commandText = string.Format(StoreProcedure.SaveAgileQuestionResponse,
                request.AccountId,
                request.ProjectId,
                request.SowId,
                request.StageId,
                request.ComplianceTypeId,
                request.SprintId,
                request.QuestionId,
                request.ComplianceStatusId,
                request.Comments,
                request.CommentsTypeId,
                request.FileName,
                request.FilePath,
                request.FileSize,
                request.DisplayName,
                request.IsUploaded,
                request.ArtefactId);
            await Context.Database.ExecuteSqlRawAsync(commandText);
        }

        /// <summary>
        /// Get Artefact by artefact id
        /// </summary>
        /// <param name="ArtefactId"></param>
        /// <returns></returns>
        public async Task<ArtefactList> GetArtefactById(int ArtefactId)
        {
            var commandText = string.Format(StoreProcedure.ArtefactsList, ArtefactId);
            var objData = await Context.GetArtefact.FromSqlRaw<ArtefactList>(commandText).ToListAsync();
            return objData.FirstOrDefault();
        }

        /// <summary>
        /// Delete SOW Question Response
        /// </summary>
        /// <param name="ArtefactId"></param>
        /// <returns></returns>
        public async Task DeleteSowQuestionResponse(int ArtefactId)
        {
            var commandText = string.Format(StoreProcedure.DeleteSowQuestionResponse, ArtefactId);
            await Context.Database.ExecuteSqlRawAsync(commandText);
        }

        /// <summary>
        /// Delete Sprint Question Response
        /// </summary>
        /// <param name="ArtefactId"></param>
        /// <returns></returns>
        public async Task DeleteSprintQuestionResponse(int ArtefactId)
        {
            var commandText = string.Format(StoreProcedure.DeleteSprintQuestionResponse, ArtefactId);
            await Context.Database.ExecuteSqlRawAsync(commandText);
        }

        #endregion

        #region Sprint Details
        /// <summary>
        /// Insert Sprint Details  
        /// </summary>
        /// <param name="objsprintModel"></param>
        /// <returns></returns>
        public async Task<ReturnResponseModel> InsertSprintDetails(SprintModel objsprintModel)
        {
            try
            {
                var commandText = string.Format(StoreProcedure.InsertSprintDetails,
              objsprintModel.ProjectId,
              objsprintModel.SowId,
                 objsprintModel.SprintName,
              objsprintModel.StartDate,
              objsprintModel.EndDate,
              objsprintModel.US_PlannedAtStart,
              objsprintModel.US_PlannedAtCompletion,
              objsprintModel.TaskPlannedAtStart,
              objsprintModel.TaskPlannedAtCompletion,
              objsprintModel.TotalEstimationSizeAtStart,
              objsprintModel.TotalEstimationSizeAtCompletion);
                await Context.Database.ExecuteSqlRawAsync(commandText);
                return new ReturnResponseModel { Status = true };
            }
            catch (Exception)
            {

                return new ReturnResponseModel { Status = false };
            }
        }

        /// <summary>
        /// Update Sprint Details  
        /// </summary>
        /// <param name="objsprintModel"></param>
        /// <returns></returns>
        public async Task<ReturnResponseModel> UpdateSprintDetails(SprintModel objsprintModel)
        {
            try
            {
                var commandText = string.Format(StoreProcedure.UpdateSprintDetails,
              objsprintModel.SprintId,
              objsprintModel.ProjectId,
              objsprintModel.SowId,
              objsprintModel.SprintName,
              objsprintModel.StartDate,
              objsprintModel.EndDate,
              objsprintModel.US_PlannedAtStart,
              objsprintModel.US_PlannedAtCompletion,
              objsprintModel.TaskPlannedAtStart,
              objsprintModel.TaskPlannedAtCompletion,
              objsprintModel.TotalEstimationSizeAtStart,
              objsprintModel.TotalEstimationSizeAtCompletion);
                await Context.Database.ExecuteSqlRawAsync(commandText);
                return new ReturnResponseModel { Status = true };
            }
            catch (Exception)
            {

                return new ReturnResponseModel { Status = false };
            }
        }
        /// <summary>
        /// Get Sprint By Id
        /// </summary>
        /// <param name="sprintId"></param>
        /// <returns></returns>
        public async Task<SprintInformation> GetSprintById(int sprintId)
        {
            var commandText = string.Format(StoreProcedure.SprintDetails, sprintId);
            var objData = await Context.GetSprintDetail.FromSqlRaw<SprintInformation>(commandText).ToListAsync();
            return objData.FirstOrDefault();
        }

        /// <summary>
        /// Get Sprint Informations
        /// </summary>
        /// <param name="sowId"></param>
        /// <param name="projectId"></param>
        /// <returns></returns>
        public async Task<List<SprintDetailList>> GetSprintInformationAsync(int sowId, int projectId)
        {
            var commandText = string.Format(StoreProcedure.SprintInformationList, sowId, projectId);
            return await Context.GetSprintInformationList.FromSqlRaw<SprintDetailList>(commandText).ToListAsync();
        }

        /// <summary>
        /// Delete Sprint information
        /// </summary>
        /// <param name="sprintId"></param>
        /// <returns></returns>
        public async Task<ReturnResponseModel> DeleteSprintAsync(int sprintId)
        {
            try
            {
                var commandText = string.Format(StoreProcedure.DeleteSprintInformation, sprintId);
                await Context.Database.ExecuteSqlRawAsync(commandText);
                return new ReturnResponseModel { Status = true };
            }
            catch (Exception ex)
            {

                return new ReturnResponseModel { Status = false, Message = ex.Message };
            }
        }
        #endregion

        #region Projects
        // <summary>
        /// insert project response
        /// </summary>
        /// <param name="objprojectModel"></param>
        /// <returns></returns>

        public async Task<ReturnResponseModel> InsertProjectResponse(InsertProjectResponseModel objprojectModel)
        {
            try 
            { 
            var commandText = string.Format(StoreProcedure.InsertProjectResponse,
                objprojectModel.ProjectName,
                objprojectModel.ProjectDescription,
                objprojectModel.StartDate,
                objprojectModel.EndDate,
                objprojectModel.AccountId,
                objprojectModel.ClientContactPerson,
                objprojectModel.ClientEmailId,
                objprojectModel.ClientContactNumber,
                objprojectModel.ProjectTypeId,
                objprojectModel.ProjectDomainId,
                objprojectModel.ProjectManagerId,
                objprojectModel.ProjectAccountManagerId,
                objprojectModel.SowId,
                objprojectModel.IsActive,
                objprojectModel.LastModifiedOn,
                objprojectModel.ModifiedById);
            await Context.Database.ExecuteSqlRawAsync(commandText);
            return new ReturnResponseModel { Status = true };
            }
            catch (Exception)
            {
                return new ReturnResponseModel { Status = false };
            }
        }


        // <summary>
        /// Update project response
        /// </summary>
        /// <param name="objprojectModel"></param>
        /// <returns></returns>
        public async Task<ReturnResponseModel> UpdateProjectResponse(UpdateProjectResponseModel objprojectModel)
        {
            try
            {
                var commandText = string.Format(StoreProcedure.UpdateProjectResponse,
                    objprojectModel.AccountId,
                    objprojectModel.ProjectName,
                    objprojectModel.ProjectDescription,
                    objprojectModel.StartDate,
                    objprojectModel.EndDate,
                    objprojectModel.ClientContactPerson,
                    objprojectModel.ClientEmailId,
                    objprojectModel.ClientContactNumber,
                    objprojectModel.ProjectTypeId,
                    objprojectModel.ProjectDomainId,
                    objprojectModel.ProjectManagerId,
                    objprojectModel.ProjectAccountManagerId,
                    objprojectModel.IsActive,
                    objprojectModel.LastModifiedOn,
                    objprojectModel.ModifiedById,
                    objprojectModel.ProjectId,
                    objprojectModel.SowId);
                await Context.Database.ExecuteSqlRawAsync(commandText);

                return new ReturnResponseModel { Status = true };
            }
            catch (Exception)
            {
                return new ReturnResponseModel { Status = false };
            }
        }

        /// <summary>
        /// Get All Project Response
        /// </summary>
        /// <param name="AccountId"></param>
        /// <returns></returns>
        public async Task<List<ProjectResponse>> GetAllProjectResponse(int AccountId)
        {
            var commandText = string.Format(StoreProcedure.GetProjectResponse, AccountId);
            return await Context.GetProjectResponse.FromSqlRaw<ProjectResponse>(commandText).ToListAsync();
        }

        /// <summary>
        /// Delete Project Response
        /// </summary>
        /// <param name="projectId"></param>
        /// <returns>Response Model</returns>
        public async Task DeleteProjectResponse(int projectId)
        {
            var commandText = string.Format(StoreProcedure.DeleteProjectResponse, projectId);
            await Context.Database.ExecuteSqlRawAsync(commandText);
        }

        ///// <summary>
        ///// Get Project by projectId
        ///// </summary>
        ///// <param name="projectId"></param>
        ///// <returns></returns>
        //public async Task<Projects> GetProjectResponsById(int projectId)
        //{
        //    var commandText = string.Format(StoreProcedure.ArtefactsList, projectId);
        //    var objData = await Context.GetProjectResponse<Projects>(commandText).ToListAsync();
        //    return objData.FirstOrDefault();
        //}
        #endregion

        #region SowResponse

        /// <summary>
        /// Insert SowResponse
        /// </summary>
        /// <param name="SowResponse"></param>
        /// <returns></returns>
        public async Task<ReturnResponseModel> InsertSowResponseAsync(InsertUpdateSowResponseModel SowResponse)
        {
            try
            {
                var commandText = string.Format(StoreProcedure.InsertSowResponse,
                    SowResponse.AccountId,
                    SowResponse.ProjectId,
                    SowResponse.SowStartDate,
                    SowResponse.SowEndDate,
                    SowResponse.SowName,
                    SowResponse.EngagementWeeks,
                    SowResponse.SowValue,
                    SowResponse.OpportunityId,
                    SowResponse.CurrencyId,
                    SowResponse.ContractTypeId,
                    SowResponse.SowPath,
                    SowResponse.ProjectDuration);
                await Context.Database.ExecuteSqlRawAsync(commandText);
                return new ReturnResponseModel { Status = true };
            }
            catch (Exception)
            {
                return new ReturnResponseModel { Status = false };
            }

        }

        /// <summary>
        /// Update SowResponse
        /// </summary>
        /// <param name="SowResponse"></param>
        /// <returns></returns>
        public async Task<ReturnResponseModel> UpdateSowResponseAsync(InsertUpdateSowResponseModel SowResponse)
        {
            try
            {
                var commandText = string.Format(StoreProcedure.UpdateSowResponse,
                    SowResponse.AccountId,
                    SowResponse.ProjectId,
                    SowResponse.SowId,
                    SowResponse.SowStartDate,
                    SowResponse.SowEndDate,
                    SowResponse.SowName,
                    SowResponse.EngagementWeeks,
                    SowResponse.SowValue,
                    SowResponse.OpportunityId,
                    SowResponse.CurrencyId,
                    SowResponse.ContractTypeId,
                    SowResponse.SowPath,
                    SowResponse.ProjectDuration,
                    SowResponse.IsActive);
                await Context.Database.ExecuteSqlRawAsync(commandText);
                return new ReturnResponseModel { Status = true };
            }
            catch (Exception)
            {
                return new ReturnResponseModel { Status = false };
            }

        }

        /// <summary>
        /// Get All Sow Response
        /// </summary>
        /// <param name="AccountId"></param>
        /// <param name="ProjectId"></param>
        /// <returns></returns>
        public async Task<List<SowResponse>> GetAllSowResponseAsync(int AccountId, int ProjectId)
        {
            var commandText = string.Format(StoreProcedure.GetSowResponse, AccountId,ProjectId);
            return await Context.GetSowResponse.FromSqlRaw<SowResponse>(commandText).ToListAsync();
        }

        /// <summary>
        /// Get Sow By Id
        /// </summary>
        /// <param name="SowId"></param>
        /// <returns></returns>
        public async Task<Sow> GetSowByIdAsync(int SowId)
        {
            return await Context.Sows.Where(x=>x.SowId == SowId).FirstOrDefaultAsync();
        }

        /// <summary>
        /// Delete SOW Response
        /// </summary>
        /// <param name="sowId">sowId</param>
        /// <returns></returns>
        public async Task DeleteSowResponseAsync(int sowId)
        {
            var commandText = string.Format(StoreProcedure.DeleteSowResponse, sowId );
            await Context.Database.ExecuteSqlRawAsync(commandText);
        }

        /// <summary>
        /// Get Sow Response By Id
        /// </summary>
        /// <param name="sowId"></param>
        /// <returns></returns>
        public async Task<SowDataResponse> GetSowDataByIdAsync(int sowId)
        {
            var commandText = string.Format(StoreProcedure.GetSowDataResponse, sowId);
            var objdata = await Context.GetSowDataResponse.FromSqlRaw<SowDataResponse>(commandText).ToListAsync();
            return objdata.FirstOrDefault();
        }

        // <summary>
        /// insert project response
        /// </summary>
        /// <param name="objprojectModel"></param>
        /// <returns></returns>

        public async Task<ReturnResponseModel> InsertAccountResponse(InsertAccountResponseModel objAccountModel)
        {
            try
            {
                var commandText = string.Format(StoreProcedure.InsertAccountResponse,
                    objAccountModel.AccountName,
                    objAccountModel.AccountDescription,
                    objAccountModel.AccountManagerId,
                    objAccountModel.HeadQuater,
                    objAccountModel.State,
                    objAccountModel.Country,
                    objAccountModel.PhoneNumber,
                    objAccountModel.MSA,
                    objAccountModel.Geography,
                    objAccountModel.CeoName,
                    objAccountModel.LeadChannelTypeId,
                    objAccountModel.EmployeeStrength,
                    objAccountModel.YearlyRevenue,
                    objAccountModel.ModifiedById);
                await Context.Database.ExecuteSqlRawAsync(commandText);
                return new ReturnResponseModel { Status = true };
            }
            catch (Exception)
            {
                return new ReturnResponseModel { Status = false };
            }
        }
        // <summary>
        /// Update project response
        /// </summary>
        /// <param name="objprojectModel"></param>
        /// <returns></returns>
        public async Task<ReturnResponseModel> UpdateAccountResponse(UpdateAccountResponseModel objAccountModel)
        {
            try
            {
                var commandText = string.Format(StoreProcedure.UpdateAccountResponse,

                   objAccountModel.AccountId,
                    objAccountModel.AccountName,
                    objAccountModel.AccountDescription,
                    objAccountModel.AccountManagerId,
                    objAccountModel.HeadQuater,
                    objAccountModel.State,
                    objAccountModel.Country,
                    objAccountModel.PhoneNumber,
                    objAccountModel.MSA,
                    objAccountModel.Geography,
                    objAccountModel.CeoName,
                    objAccountModel.LeadChannelTypeId,
                    objAccountModel.EmployeeStrength,
                    objAccountModel.YearlyRevenue,
                    objAccountModel.ModifiedById,
                    objAccountModel.IsActive);
                await Context.Database.ExecuteSqlRawAsync(commandText);

                return new ReturnResponseModel { Status = true };
            }
            catch (Exception)
            {
                return new ReturnResponseModel { Status = false };
            }
        }
        /// <summary>
        /// Delete Account Response
        /// </summary>
        /// <param name="AccountId"></param>
        /// <returns>Response Model</returns>
        public async Task DeleteAccountResponse(int AccountId)
        {
            var commandText = string.Format(StoreProcedure.DeleteAccountResponse, AccountId);
            await Context.Database.ExecuteSqlRawAsync(commandText);
        }

        #endregion

    }
}

