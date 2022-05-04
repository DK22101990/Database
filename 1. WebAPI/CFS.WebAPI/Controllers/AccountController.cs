using CFS.BusinessLogic.IBusinessLogic;
using CFS.Model.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CFS.WebAPI.Controllers
{
    [Route("api/v1/[controller]")]
    public class AccountController : Controller
    {
        #region Variables

        private readonly IAccountLogic _iAccountLogic;
        private readonly IConfiguration _configuration;
        private readonly ILogger _logger;
        #endregion Variables

        #region Constructor
        public AccountController(IAccountLogic iAccountLogic, ILoggerFactory factory,
            ILogger<AccountController> logger)
        {
            factory.CreateLogger<AccountController>();
            _iAccountLogic = iAccountLogic;
        }
        #endregion

        #region Actions 

        /// <summary>
        /// Get All Accounts
        /// </summary>
        /// <returns></returns>
        [Route("GetAllAccounts")]
        [HttpGet]
        public async Task<List<AccountListViewModel>> GetAccountList()
        {
            string Message = $"GetAccountList at {DateTime.UtcNow.ToLongTimeString()}";
            _logger.LogInformation(Message);
            return await _iAccountLogic.GetAccountList();
        }
        /// <summary>
        /// Get All Accounts
        /// </summary>
        /// <returns></returns>
        [Route("GetAllSprints")]
        [HttpGet]
        public async Task<List<SprintViewModel>> GetSprintList(int SowId)
        {
            return await _iAccountLogic.GetSprintList(SowId);
        }
        /// <summary>
        /// Get All Complience Types
        /// </summary>
        /// <param name="RoleId"></param>
        /// <returns></returns>
        [Route("GetAllComplianceTypes")]
        [HttpGet]
        public async Task<List<ComplianceTypeViewModel>> GetComplianceTypeList(int StageId)
        {
            return await _iAccountLogic.GetComplianceTypeList(StageId);
        }

        /// <summary>
        /// Get Agile Questions
        /// </summary>
        /// <param name="ComplianceTypeId"></param>
        /// <param name="ProjectId"></param>
        /// <param name="AccountId"></param>
        /// <param name="SowId"></param>
        /// <param name="StageId"></param>
        /// <param name="SprintId"></param>
        /// <returns></returns>
        [Route("GetAgileQuestions")]
        [HttpGet]
        public async Task<List<AgileQuestionViewModel>> GetAgileQuestionList(int ComplianceTypeId,
            int ProjectId,
            int AccountId,
            int SowId,
            int StageId,
            int SprintId)
        {
            return await _iAccountLogic.GetAgileQuestionList(ComplianceTypeId,
                ProjectId,
                AccountId,
                SowId,
                StageId,
                SprintId);
        }

        /// <summary>
        /// Get Project KickStart Questions
        /// </summary>
        /// <param name="ComplianceTypeId"></param>
        /// <param name="ProjectId"></param>
        /// <param name="AccountId"></param>
        /// <param name="SowId"></param>
        /// <param name="StageId"></param>        
        /// <returns></returns>
        [Route("GetProjectKickStartQuestions")]
        [HttpGet]
        public async Task<List<ProjectKickStartQuestionViewModel>> GetProjectKickStartQuestionList(int ComplianceTypeId,
            int ProjectId,
            int AccountId,
            int SowId,
            int StageId)
        {
            return await _iAccountLogic.GetProjectKickStartQuestionList(ComplianceTypeId,
                ProjectId,
                AccountId,
                SowId,
                StageId);
        }

        /// <summary>
        /// Get All Complience Types
        /// </summary>
        /// <param name="RoleId"></param>
        /// <returns></returns>
        [Route("GetAllProjectList")]
        [HttpGet]
        public async Task<List<ProjectViewModel>> GetProjectList(int AccountId)
        {
            return await _iAccountLogic.GetProjectList(AccountId);
        }

        /// <summary>
        /// Get All Project
        /// </summary>
        /// <param name="ProjectId"></param>
        /// <returns></returns>
        [Route("GetAllSOWList")]
        [HttpGet]
        public async Task<List<SOWViewModel>> GetSOWList(int ProjectId)
        {
            return await _iAccountLogic.GetSOWList(ProjectId);
        }

        /// <summary>
        /// Get All SOW
        /// </summary>
        /// <param name="ProjectId"></param>
        /// <param name="ComplianceTypeId"></param>
        /// <returns></returns>
        [Route("GetAllStageList")]
        [HttpGet]
        public async Task<List<StageViewModel>> GetStageList()
        {
            return await _iAccountLogic.GetStageList();
        }

        /// <summary>
        /// Get All Questions
        /// </summary>
        /// <param name="StageId"></param>
        /// <param name="ComplianceTypeId"></param>
        /// <returns></returns>
        [Route("GetAllQuestionList")]
        [HttpGet]
        public async Task<List<QuestionListViewModel>> GetQuestionList(int StageId, int ComplianceTypeId)
        {
            return await _iAccountLogic.GetQuestionList(StageId, ComplianceTypeId);
        }

        ///// <summary>
        ///// Insert Kick Start Response 
        ///// </summary>
        ///// <param name="kickStartResponse"></param>
        ///// <returns></returns>
        //[Route("InsertProjectKickStartQuestion")]
        //[HttpPost]
        //public async Task InsertProjectKickStartQuestion([FromBody] InsertQuestion kickStartResponse)
        //{
        //    await _iAccountLogic.InsertProjectKickStartQuestion(kickStartResponse);
        //}

        /// <summary>
        /// Insert SOW Start Question 
        /// </summary>
        /// <param name="kickStartResponse"></param>
        /// <returns></returns>
        [Route("InsertSOWKickStartQuestion")]
        [HttpPost]
        public async Task InsertSOWKickStartQuestion([FromBody] InsertQuestion SowQuestion)
        {
            await _iAccountLogic.InsertProjectKickStartQuestion(SowQuestion);
        }

        /// <summary>
        /// Insert Sprint Start Question 
        /// </summary>
        /// <param name="kickStartResponse"></param>
        /// <returns></returns>
        [Route("InsertSprintKickStartQuestion")]
        [HttpPost]
        public async Task InsertSprintKickStartQuestion([FromBody] InsertQuestion SprintQuestion)
        {
            await _iAccountLogic.InsertSprintKickStartQuestion(SprintQuestion);
        }

        /// <summary>
        /// Get Master Select List
        /// </summary>
        /// <param name="Entity"></param>
        /// <returns></returns>
        [Route("SelectList")]
        [HttpGet]
        public async Task<List<SelectListViewModel>> GetMasterList(string Entity)
        {
            return await _iAccountLogic.GetMasterList(Entity);
        }

        /// <summary>
        /// SaveSowQuestionResponse
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        [HttpPost, DisableRequestSizeLimit]
        [Route("SaveSowQuestionResponse")]
        public async Task<ReturnResponseModel> SaveSowQuestionResponse([FromBody] SaveSowQuestionResponse request)
        {
            return await _iAccountLogic.SaveSowQuestionResponse(request);

        }

        /// <summary>
        /// SaveAgileQuestionResponse
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        [HttpPost, DisableRequestSizeLimit]
        [Route("SaveAgileQuestionResponse")]
        public async Task<ReturnResponseModel> SaveAgileQuestionResponse([FromBody] SaveAgileQuestionResponse request)
        {
            return await _iAccountLogic.SaveAgileQuestionResponse(request);

        }

        /// <summary>
        /// Delete Sow Question Response
        /// </summary>
        /// <param name="ArtefactId">document id</param>
        /// <returns></returns>
        [Route("DeleteSowQuestionResponse")]
        [HttpDelete]
        public async Task<IActionResult> DeleteSowQuestionResponse(int ArtefactId)
        {
            ReturnResponseModel result = new ReturnResponseModel();
            result = await _iAccountLogic.DeleteSowQuestionResponse(ArtefactId);
            if (result.Status)
            {
                return NoContent();
            }
            return BadRequest(result);
        }

        /// <summary>
        /// Delete Sprint Question Response
        /// </summary>
        /// <param name="ArtefactId">document id</param>
        /// <returns></returns>
        [Route("DeleteSprintQuestionResponse")]
        [HttpDelete]
        public async Task<IActionResult> DeleteSprintQuestionResponse(int ArtefactId)
        {
            ReturnResponseModel result = new ReturnResponseModel();
            result = await _iAccountLogic.DeleteSprintQuestionResponse(ArtefactId);
            if (result.Status)
            {
                return NoContent();
            }
            return BadRequest(result);
        }

        /// <summary>
        /// Download Artefact
        /// </summary>
        /// <param name="ArtefactId"></param>
        /// <returns></returns>
        [Route("DownloadArtefact")]
        [HttpGet]
        public async Task<IActionResult> DownloadArtefact(int ArtefactId)
        {
            ArtefactDownload result = new ArtefactDownload();
            result = await _iAccountLogic.DownloadArtefact(ArtefactId);
            if (result.returnResponseModel.Status)
            {
                result.File = Convert.ToBase64String(System.IO.File.ReadAllBytes(result.FilePath));
                return Ok(result);
            }
            return BadRequest(result.returnResponseModel);
        }
        #endregion

        #region Sprint

        /// <summary>
        /// Insert Sprint Details  
        /// </summary>
        /// <param name="objsprintModel"></param>
        /// <returns></returns>
        [Route("InsertSprintDetails")]
        [HttpPost]
        public async Task<IActionResult> InsertSprintDetails([FromBody] SprintModel objsprintModel)
        {
            ReturnResponseModel result = new ReturnResponseModel();
            result = await _iAccountLogic.InsertSprintDetails(objsprintModel);
            if (result.Status)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        /// <summary>
        /// Insert Sprint Details  
        /// </summary>
        /// <param name="objsprintModel"></param>
        /// <returns></returns>
        [Route("UpdateSprintDetails")]
        [HttpPost]
        public async Task<IActionResult> UpdateSprintDetails([FromBody] SprintModel objsprintModel)
        {
            ReturnResponseModel result = new ReturnResponseModel();
            result = await _iAccountLogic.UpdateSprintDetails(objsprintModel);
            if (result.Status)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        /// <summary>
        /// Get Sprint By Id
        /// </summary>
        /// <param name="sprintId"></param>
        /// <returns></returns>
        [Route("GetSprintById")]
        [HttpGet]
        public async Task<IActionResult> GetSprintById(int sprintId)
        {
            return Ok(await _iAccountLogic.GetSprintById(sprintId));
        }

        /// <summary>
        /// Get Sprint Informations
        /// </summary>
        /// <param name="sowId"></param>
        /// <param name="projectId"></param>
        /// <returns></returns>
        [Route("GetSprintInformation")]
        [HttpGet]
        public async Task<IActionResult> GetSprintInformationAsync(int sowId, int projectId)
        {
            return Ok(await _iAccountLogic.GetSprintInformationAsync(sowId, projectId));
        }

        /// <summary>
        /// Get Sprint Informations
        /// </summary>
        /// <param name="sprintId"></param>
        /// <returns></returns>
        [Route("DeleteSprintInformation")]
        [HttpDelete]
        public async Task<IActionResult> DeleteSprintInformationAsync(int sprintId)
        {
            ReturnResponseModel result = new ReturnResponseModel();
            result = await _iAccountLogic.DeleteSprintAsync(sprintId);
            if (result.Status)
                return Ok(result);
            return BadRequest(result);
        }
        #endregion
    }
}
