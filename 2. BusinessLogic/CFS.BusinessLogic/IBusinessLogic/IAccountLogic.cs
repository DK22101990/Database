using CFS.Model.Models;
using CFS.Data.Domains;
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

        // <summary>
        /// Get ComplianceType List
        /// </summary>
        /// <returns></returns>
        Task<List<ComplianceTypeViewModel>> GetComplianceTypeList(int RoleId);

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
        /// <param name="ProjectId"></param>
        /// <returns></returns>
        Task<List<SOWViewModel>> GetSOWList(int ProjectId);

        /// <summary>
        /// Get Stage
        /// </summary>
        /// <param name="ProjectId"></param>
        /// <param name="ComplianceTypeId"></param>
        /// <returns></returns>
        Task<List<StageViewModel>> GetStageList(int ProjectId, int ComplianceTypeId);

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
        /// Upload Artificate Document
        /// </summary>        
        /// <returns></returns>
        Task<ReturnResponseModel<Artefact>> UploadArtificateDocument(FileUploadModel fileUploadModel);
    }
}
