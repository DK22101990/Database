using CFS.BusinessLogic.BusinessLogic;
using CFS.BusinessLogic.IBusinessLogic;
using CFS.Data.Domains;
using CFS.Data.Models;
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
            _logger = logger;
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
        /// 

        [Route("GetAllAccountResponse")]
        [HttpGet]
        public async Task<List<AccountResponseViewModel>> GetAccountResponseList()
        {
            string Message = $"GetAccountResponseList at {DateTime.UtcNow.ToLongTimeString()}";
            _logger.LogInformation(Message);
            return await _iAccountLogic.GetAccountResponseList();

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
        /// Get All Compliance Types
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
        /// Get All Project
        /// </summary>
        /// <param name="ProjectId"></param>
        /// <returns></returns>
        /// 

        [Route("GetAllProjectDomainList")]
        [HttpGet]
        public async Task<List<ProjectDomainViewModel>> ProjectDomainList()
        {
            return await _iAccountLogic.GetProjectDomainList();
        }

        /// <summary>
        /// Get All Project
        /// </summary>
        /// 
        /// <returns></returns>
        [Route("GetAllSOWList")]
        [HttpGet]
        public async Task<List<SOWViewModel>> GetSOWList(int ProjectId, int AccountId)
        {
            return await _iAccountLogic.GetSOWList(ProjectId, AccountId);
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

        #region Projects

        /// <summary>
        /// insert project response
        /// </summary>
        /// <param name="objprojectModel"></param>
        /// <returns></returns>
        [Route("InsertProjectResponse")]
        [HttpPost]
        public async Task<IActionResult> InsertProjectResponse([FromBody] InsertProjectResponseModel objprojectModel)
        {

            ReturnResponseModel result = new ReturnResponseModel();
            if (objprojectModel != null)
            {
                result = await _iAccountLogic.InsertProjectResponse(objprojectModel);
                if (result.Status)
                {
                    return Ok(result);
                }
            }
            return BadRequest(result);
        }

        /// <summary>
        /// Update project response
        /// </summary>
        /// <param name="objprojectModel"></param>
        /// <returns></returns>
        [Route("UpdateProjectResponse")]
        [HttpPost]
        public async Task<IActionResult> UpdateProjectResponse([FromBody] UpdateProjectResponseModel objprojectModel)
        {
            ReturnResponseModel result = new ReturnResponseModel();
            if (objprojectModel != null)
            {
                result = await _iAccountLogic.UpdateProjectResponse(objprojectModel);
                if (result.Status)
                {
                    return Ok(result);
                }
            }
            return BadRequest(result);
        }

        /// <summary>
        /// Get All Compliance Types
        /// </summary>
        /// <param name="AccountId"></param>
        /// <returns></returns>
        [Route("GetAllProjectList")]
        [HttpGet]
        public async Task<List<ProjectViewModel>> GetProjectList(int AccountId)
        {
            return await _iAccountLogic.GetProjectList(AccountId);
        }

        /// <summary>
        /// Get All Project Response
        /// </summary>
        /// <param name="AccountId"></param>
        /// <returns></returns>
        [Route("GetAllProjectResponse")]
        [HttpGet]
        public async Task<List<ProjectViewModel>> GetAllProjectResponse(int AccountId)
        {

            return await _iAccountLogic.GetAllProjectResponse(AccountId);
        }


        /// <summary>
        /// Delete Project Response
        /// </summary>
        /// <param name="projectId">project id</param>
        /// <returns></returns>
        [Route("DeleteProjectResponse")]
        [HttpDelete]
        public async Task<IActionResult> DeleteProjectResponse(int projectId)
        {
            ReturnResponseModel result = new ReturnResponseModel();
            result = await _iAccountLogic.DeleteProjectResponse(projectId);
            if (result.Status)
            {
                return NoContent();
            }
            return BadRequest(result);
        }

        #endregion

        #region SOWResponse

        /// <summary>
        /// Insert Sow Response
        /// </summary>
        /// <param name="objResponse"></param>
        /// <returns></returns>
        [Route("SowResponse")]
        [HttpPost]
        public async Task InsertSowResponse([FromBody] InsertUpdateSowResponseModel objResponse)
        {
            await _iAccountLogic.InsertSowResponse(objResponse);
        }

        /// <summary>
        /// Update Sow Response
        /// </summary>
        /// <param name="objResponse"></param>
        /// <returns></returns>
        [Route("SowResponse")]
        [HttpPut]
        public async Task UpdateSowResponse([FromBody] InsertUpdateSowResponseModel objResponse)
        {
            await _iAccountLogic.UpdateSowResponse(objResponse);
        }

        /// <summary>
        /// Get Sow Response
        /// </summary>
        /// <param name="AccountId"></param>
        /// <returns></returns>
        [Route("SowResponse")]
        [HttpGet]
        public async Task<List<SOWViewModel>> SowResponse(int AccountId, int ProjectId)
        {

            return await _iAccountLogic.GetAllSowResponse(AccountId,ProjectId);
        }

        /// <summary>
        /// Delete SOW Response
        /// </summary>
        /// <param name="sowId">sowId</param>
        /// <returns></returns>
        [Route("SowResponse")]
        [HttpDelete]
        public async Task<IActionResult> DeleteSowResponse(int sowId)
        {
            ReturnResponseModel result = new ReturnResponseModel();
            result = await _iAccountLogic.DeleteSowResponse(sowId);
            if (result.Status)
            {
                return NoContent();
            }
            return BadRequest(result);
        }

        /// <summary>
        /// Get Sow Response By Id
        /// </summary>
        /// <param name="sowId"></param>
        /// <returns></returns>
        [Route("GetSowById")]
        [HttpGet]
        public async Task<SowDataViewModel> GetSowById(int sowId)
        {
            return await _iAccountLogic.GetSowByIdAsync(sowId);
        }
        /// <summary>
        /// insert Account response
        /// </summary>
        /// <param name="ObjAccountModel"></param>
        /// <returns></returns>
        [Route("InsertAccountResponse")]
        [HttpPost]
        public async Task<IActionResult> InsertAccountResponse([FromBody] InsertAccountResponseModel objAccountModel)
        {

            ReturnResponseModel result = new ReturnResponseModel();
            if (objAccountModel != null)
            {
                result = await _iAccountLogic.InsertAccountResponse(objAccountModel);
                if (result.Status)
                {
                    return Ok(result);
                }
            }
            return BadRequest(result);
        }
        /// <summary>
        /// Update Account response
        /// </summary>
        /// <param name="objAccountModel"></param>
        /// <returns></returns>
        [Route("UpdateAccountResponse")]
        [HttpPost]
        public async Task<IActionResult> UpdateAccountResponse([FromBody] UpdateAccountResponseModel objAccountModel)
        {
            ReturnResponseModel result = new ReturnResponseModel();
            if (objAccountModel != null)
            {
                result = await _iAccountLogic.UpdateAccountResponse(objAccountModel);
                if (result.Status)
                {
                    return Ok(result);
                }
            }
            return BadRequest(result);
        }

        /// <summary>
        /// Delete Account Response
        /// </summary>
        /// <param name="AccountId">document id</param>
        /// <returns></returns>
        [Route("DeleteAccountResponse")]
        [HttpDelete]
        public async Task<IActionResult> DeleteAccountResponse(int AccountId)
        {
            ReturnResponseModel result = new ReturnResponseModel();
            result = await _iAccountLogic.DeleteAccountResponse(AccountId);
            if (result.Status)
            {
                return NoContent();
            }
            return BadRequest(result);
        }


        #endregion
    }
}
