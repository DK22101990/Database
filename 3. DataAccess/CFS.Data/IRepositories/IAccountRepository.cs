using CFS.Data.Domains;
using CFS.Data.Models;
using CFS.Model.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CFS.Data.IRepositories
{
    public interface IAccountRepository
    {
        /// <summary>
        /// Get Account List
        /// </summary>
        /// <returns></returns>
        Task<List<AccountList>> GetAccountList();
        /// <summary>
        /// Get Account Response
        /// </summary>
        /// <returns></returns>

        Task<List<AccountResponseList>> GetAccountResponseList();

        // <summary>
        /// Get ComplianceType List
        /// </summary>
        /// <returns></returns>
        Task<List<Domains.ComplianceType>> GetComplianceTypeList(int StageId);

        /// <summary>
        /// Get All Sprints
        /// </summary>
        /// <param name="ProjectId"></param>
        /// <param name="SowId"></param>
        /// <returns></returns>
        Task<List<SprintList>> GetSprintList(int SowId);

        /// <summary>
        /// Get Agile Questions
        /// </summary>
        /// <param name="RoleId"></param>
        /// <returns></returns>
        Task<List<AgileQuestion>> GetAgileQuestionList(int ComplianceTypeId,
            int ProjectId,
            int AccountId,
            int SowId,
            int StageId,
            int SprintId);

        /// <summary>
        /// Post Kick Start Response
        /// </summary>
        /// <returns></returns>
        Task InsertProjectKickStartQuestion(InsertQuestion kickStartResponse);

        /// <summary>
        /// Post SOW Start Question
        /// </summary>
        /// <returns></returns>
        Task InsertSOWKickStartQuestion(InsertQuestion kickStartResponse);

        /// <summary>
        /// Post Sprint Start Question
        /// </summary>
        /// <returns></returns>
        Task InsertSprintKickStartQuestion(InsertQuestion kickStartResponse);

        /// <summary>
        /// Get Master List
        /// </summary>
        /// <returns></returns>
        Task<List<SelectList>> GetMasterList(string Entity);

        /// <summary>
        /// Add Artifact
        /// </summary>
        /// <param name="artefact"></param>
        /// <returns></returns>
        Task<Artefact> AddArtifactAsync(Models.Artefact artefact);

        /// <summary>
        /// Get Project KickStart Questions
        /// </summary>
        /// <param name="ComplianceTypeId"></param>
        /// <param name="ProjectId"></param>
        /// <param name="AccountId"></param>
        /// <param name="SowId"></param>
        /// <param name="StageId"></param>
        /// <returns></returns>
        Task<List<ProjectKickStartQuestions>> GetProjectKickStartQuestionList(int ComplianceTypeId,
            int ProjectId,
            int AccountId,
            int SowId,
            int StageId);

        /// <summary>
        /// Get Projects
        /// </summary>
        /// <param name="AccountId"></param>
        /// <returns></returns>
        Task<List<Projects>> GetProjectList(int AccountId);

        /// <summary>
        /// Get SOW
        /// </summary>
        ///
        /// <returns></returns>

        Task<List<ProjectDomain>> GetProjectDomainList();

        #region Projects

        // <summary>
        /// Insert project response
        /// </summary>
        /// <param name="objprojectModel"></param>
        /// <returns></returns>
        Task<ReturnResponseModel> InsertProjectResponse(InsertProjectResponseModel objprojectModel);


        // <summary>
        /// Update project response
        /// </summary>
        /// <param name="objprojectModel"></param>
        /// <returns></returns>
        Task<ReturnResponseModel> UpdateProjectResponse(UpdateProjectResponseModel objprojectModel);
      
        /// <summary>
        /// Get All Project Response
        /// </summary>
        /// <param name="AccountId"></param>
        /// <returns></returns>
        Task<List<ProjectResponse>> GetAllProjectResponse(int AccountId);

        #endregion

        /// <summary>
        /// Get SOW
        /// </summary>
        /// <returns></returns>
        Task<List<SOW>> GetSOWList(int ProjectId, int AccountId);

        /// <summary>
        /// Get Stage
        /// </summary>        
        /// <returns></returns>
        Task<List<Domains.Stage>> GetStageList();

        /// <summary>
        /// Get Question List
        /// </summary>
        /// <param name="StageId"></param>
        /// <param name="ComplianceTypeId"></param>
        /// <returns></returns>
        Task<List<Domains.QuestionList>> GetQuestionList(int StageId,int ComplianceTypeId);
        
        Task SaveSowQuestionResponse(SaveSowQuestionResponse request);

        Task SaveAgileQuestionResponse(SaveAgileQuestionResponse request);

        /// <summary>
        /// Get Artefact by artefact id
        /// </summary>
        /// <param name="ArtefactId"></param>
        /// <returns></returns>
        Task<ArtefactList> GetArtefactById(int ArtefactId);

        /// <summary>
        /// Delete SOW Question Response
        /// </summary>
        /// <param name="ArtefactId"></param>
        /// <returns></returns>
        Task DeleteSowQuestionResponse(int ArtefactId);

        /// <summary>
        /// Delete Sprint Question Response
        /// </summary>
        /// <param name="ArtefactId"></param>
        /// <returns></returns>
        Task DeleteSprintQuestionResponse(int ArtefactId);

        #region Sprint Details
        /// <summary>
        /// Insert Sprint Details  
        /// </summary>
        /// <param name="objsprintModel"></param>
        /// <returns></returns>
        Task<ReturnResponseModel> InsertSprintDetails(SprintModel objsprintModel);

        /// <summary>
        /// Update Sprint Details  
        /// </summary>
        /// <param name="objsprintModel"></param>
        /// <returns></returns>
        Task<ReturnResponseModel> UpdateSprintDetails(SprintModel objsprintModel);

        /// <summary>
        /// Get Sprint By Id
        /// </summary>
        /// <param name="sprintId"></param>
        /// <returns></returns>
        Task<SprintInformation> GetSprintById(int sprintId);

        /// <summary>
        /// Get Sprint Informations
        /// </summary>
        /// <param name="sowId"></param>
        /// <param name="projectId"></param>
        /// <returns></returns>
        Task<List<SprintDetailList>> GetSprintInformationAsync(int sowId, int projectId);

        /// <summary>
        /// Delete Sprint information
        /// </summary>
        /// <param name="sprintId"></param>
        /// <returns></returns>
        Task<ReturnResponseModel> DeleteSprintAsync(int sprintId);
        #endregion

        /// <summary>
        /// Delete Project Response
        /// </summary>
        /// <param name="projectId"></param>
        /// <returns>Response Model</returns>
        Task DeleteProjectResponse(int projectId);

        #region SowResponse

        /// <summary>
        /// Insert SowResponse
        /// </summary>
        /// <param name="SowResponse"></param>
        /// <returns></returns>
        Task<ReturnResponseModel> InsertSowResponseAsync(InsertUpdateSowResponseModel SowResponse);

        /// <summary>
        /// Update SowResponse
        /// </summary>
        /// <param name="SowResponse"></param>
        /// <returns></returns>
        Task<ReturnResponseModel> UpdateSowResponseAsync(InsertUpdateSowResponseModel SowResponse);

        /// <summary>
        /// Get All Project Response
        /// </summary>
        /// <param name="AccountId"></param>
        /// <returns></returns>
        Task<List<SowResponse>> GetAllSowResponseAsync(int AccountId, int ProjectId);


        /// <summary>
        /// Get Sow By Id
        /// </summary>
        /// <param name="SowId"></param>
        /// <returns></returns>
        Task<Sow> GetSowByIdAsync(int SowId);

        /// <summary>
        /// Delete SOW Response
        /// </summary>
        /// <param name="sowId">sowId</param>
        /// <returns></returns>
        Task DeleteSowResponseAsync(int sowId);

        /// <summary>
        /// Get Sow Response By Id
        /// </summary>
        /// <param name="sowId"></param>
        /// <returns></returns>
        Task<SowDataResponse> GetSowDataByIdAsync(int sowId);
        /// <summary>
        /// Insert Account Response
        /// </summary>
        /// <returns></returns>
        Task<ReturnResponseModel> InsertAccountResponse(InsertAccountResponseModel objAccountModel);
        // <summary>
        /// Update Account response
        /// </summary>
        /// <param name="objAccountModel"></param>
        /// <returns></returns>
        Task<ReturnResponseModel> UpdateAccountResponse(UpdateAccountResponseModel objAccountModel);
        /// <summary>
        /// Delete Account Response
        /// </summary>
        /// <param name="AccountId"></param>
        /// <returns>Response Model</returns>
        Task DeleteAccountResponse(int AccountId);


        #endregion
    }
}
