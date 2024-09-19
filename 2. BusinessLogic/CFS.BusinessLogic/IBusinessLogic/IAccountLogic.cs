using CFS.Data.Models;
using CFS.Model.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CFS.BusinessLogic.IBusinessLogic
{
    public interface IAccountLogic
    {
        /// <summary>
        /// Get Account List
        /// </summary>
        /// <returns></returns>
        Task<List<AccountListViewModel>> GetAccountList();
        /// <summary>
        /// Get Account Response
        /// </summary>
        /// <returns></returns>

        Task<List<AccountResponseViewModel>> GetAccountResponseList();

        // <summary>
        /// Get ComplianceType List
        /// </summary>
        /// <returns></returns>
        Task<List<ComplianceTypeViewModel>> GetComplianceTypeList(int StageId);

        /// <summary>
        /// Get All Sprints
        /// </summary>
        /// <param name="ProjectId"></param>
        /// <param name="SowId"></param>
        /// <returns></returns>
        Task<List<SprintViewModel>> GetSprintList(int SowId);
        
        /// <summary>
        ///  Get Agile Questions
        /// </summary>
        /// <returns></returns>
        Task<List<AgileQuestionViewModel>> GetAgileQuestionList(int ComplianceTypeId,
            int ProjectId,
            int AccountId,
            int SowId,
            int StageId,
            int SprintId);

        /// <summary>
        /// Get Projects
        /// </summary>
        /// <param name="AccountId"></param>
        /// <returns></returns>
        Task<List<ProjectViewModel>> GetProjectList(int AccountId);

        /// <summary>
        /// Get SOW
        /// </summary>
        ///
        /// <returns></returns>
        /// 
        Task<List<ProjectDomainViewModel>> GetProjectDomainList();

        /// <summary>
        /// Get SOW
        /// </summary>
        
       
        
        /// <returns></returns>
        Task<List<SOWViewModel>> GetSOWList(int ProjectId, int AccountId);

        /// <summary>
        /// Get Stage
        /// </summary>       
        /// <param name="ProjectId">
        /// <param name="AccountId"
        /// <returns></returns>
        Task<List<StageViewModel>> GetStageList();

        /// <summary>
        ///  Get Projct Kick Start Questions
        /// </summary>
        /// <returns></returns>
        Task<List<ProjectKickStartQuestionViewModel>> GetProjectKickStartQuestionList(int ComplianceTypeId,
            int ProjectId,
            int AccountId,
            int SowId,
            int StageId);

        /// <summary>
        ///  Post Kick Start Response
        /// </summary>
        /// <returns></returns>
        Task InsertProjectKickStartQuestion(InsertQuestion kickStartResponse);

        /// <summary>
        ///  Post SOW Kick Start Question
        /// </summary>
        /// <returns></returns>
        Task InsertSOWKickStartQuestion(InsertQuestion kickStartResponse);

        /// <summary>
        ///  Post Sprint Kick Start Question
        /// </summary>
        /// <returns></returns>
        Task InsertSprintKickStartQuestion(InsertQuestion kickStartResponse);

        /// <summary>
        /// Get Master List
        /// </summary>
        /// <returns></returns>
        Task<List<SelectListViewModel>> GetMasterList(string Entity);

        /// <summary>
        /// Get Question List
        /// </summary>
        /// <param name="StageId"></param>
        /// <param name="ComplianceTypeId"></param>
        /// <returns></returns>
        /// 
        Task<List<QuestionListViewModel>> GetQuestionList(int StageId, int ComplianceTypeId);

        /// <summary>
        /// SaveSowQuestionResponse
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        Task<ReturnResponseModel> SaveSowQuestionResponse(SaveSowQuestionResponse request);

        /// <summary>
        /// SaveAgileQuestionResponse
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        Task<ReturnResponseModel> SaveAgileQuestionResponse(SaveAgileQuestionResponse request);        

        /// <summary>
        /// Delete SOW Question Response
        /// </summary>
        /// <param name="ArtefactId"></param>
        /// <returns></returns>
        Task<ReturnResponseModel> DeleteSowQuestionResponse(int ArtefactId);

        /// <summary>
        /// Delete Sprint Question Response
        /// </summary>
        /// <param name="ArtefactId"></param>
        /// <returns></returns>
        Task<ReturnResponseModel> DeleteSprintQuestionResponse(int ArtefactId);

        /// <summary>
        /// Download Artefact document
        /// </summary>
        /// <param name="ArtefactId"></param>
        /// <returns>Response Model</returns>
        Task<ArtefactDownload> DownloadArtefact(int ArtefactId);

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
        Task<SprintModel> GetSprintById(int sprintId);

        /// <summary>
        /// Get Sprint Informations
        /// </summary>
        /// <param name="sowId"></param>
        /// <param name="projectId"></param>
        /// <returns></returns>
        Task<List<SprintModel>> GetSprintInformationAsync(int sowId, int projectId);

        /// <summary>
        /// Delete Sprint information
        /// </summary>
        /// <param name="sprintId"></param>
        /// <returns></returns>
        Task<ReturnResponseModel> DeleteSprintAsync(int sprintId);
        #endregion

        #region Projects

        /// <summary>
        /// Update insert project response
        /// </summary>
        /// <param name="objprojectModel"></param>
        /// <returns></returns>
        Task<ReturnResponseModel> InsertProjectResponse(InsertProjectResponseModel objprojectModel);

        /// <summary>
        /// insert project response
        /// </summary>
        /// <param name="objprojectModel"></param>
        /// <returns></returns>
        Task<ReturnResponseModel> UpdateProjectResponse(UpdateProjectResponseModel objprojectModel);

        /// <summary>
        /// Get All Project Response
        /// </summary>
        /// <param name="AccountId"></param>
        /// <returns></returns>
        Task<List<ProjectViewModel>> GetAllProjectResponse(int AccountId);

        /// <summary>
        /// Delete Project Response
        /// </summary>
        /// <param name="projectId">project id</param>
        /// <returns></returns>
        Task<ReturnResponseModel> DeleteProjectResponse(int projectId);

        #endregion

        #region SOWResponse

        /// <summary>
        /// Insert SOW Response
        /// </summary>
        /// <param name="objSowResponse"></param>
        /// <returns></returns>
        Task<ReturnResponseModel> InsertSowResponse(InsertUpdateSowResponseModel objSowResponse);

        /// <summary>
        /// Update SOW Response
        /// </summary>
        /// <param name="objSowResponse"></param>
        /// <returns></returns>
        Task<ReturnResponseModel> UpdateSowResponse(InsertUpdateSowResponseModel objSowResponse);

        /// <summary>
        /// Get All Project Response
        /// </summary>
        /// <returns></returns>
        Task<List<SOWViewModel>> GetAllSowResponse(int AccountId, int ProjectId);

        /// <summary>
        /// Delete SOW Response
        /// </summary>
        /// <param name="sowId">sowId</param>
        /// <returns></returns>
        Task<ReturnResponseModel> DeleteSowResponse(int sowId);

        /// <summary>
        /// Get Sow Response By Id
        /// </summary>
        /// <param name="sowId"></param>
        /// <returns></returns>
        Task<SowDataViewModel> GetSowByIdAsync(int sowId);
        /// <summary>
        /// Insert Account Response
        /// </summary>
        /// <param name="objAccountModel"></param>
        /// <returns></returns>
        Task<ReturnResponseModel> InsertAccountResponse(InsertAccountResponseModel objAccountModel);

        /// <summary>
        /// Update Account Response 
        /// </summary>
        /// <param name="objAccountModel"></param>
        /// <returns></returns>
        Task<ReturnResponseModel> UpdateAccountResponse(UpdateAccountResponseModel objAccountModel);
        /// <summary>
        /// Delete Account Response
        /// </summary>
        /// <param name="AccountId">project id</param>
        /// <returns></returns>
        Task<ReturnResponseModel> DeleteAccountResponse(int AccountId);
        #endregion
    }
}
