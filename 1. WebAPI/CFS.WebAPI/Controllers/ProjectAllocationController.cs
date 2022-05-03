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
    public class ProjectAllocationController : Controller
    {
        #region Variables

        private readonly IProjectAllocationLogic _iProjectAllocationLogic;
        private readonly IConfiguration _configuration;
        #endregion Variables

        #region Constructor
        public ProjectAllocationController(IProjectAllocationLogic iProjectAllocationLogic, ILoggerFactory factory)
        {
            factory.CreateLogger<AccountController>();
            _iProjectAllocationLogic = iProjectAllocationLogic;
        }
        #endregion

        #region Actions 

        /// <summary>
        /// Insert Account Manager Map
        /// </summary>
        /// <param name="accountManager"></param>
        /// <returns></returns>
        [Route("InsertAccountManagerMap")]
        [HttpPost]
        public async Task InsertAccountManagerMap([FromBody] InsertAccountManager accountManager)
        {
            await _iProjectAllocationLogic.InsertAccountManagerMap(accountManager);
        }

        /// <summary>
        /// Insert Project Allocation
        /// </summary>
        /// <param name="accountManager"></param>
        /// <returns></returns>
        [Route("InsertProjectAllocation")]
        [HttpPost]
        public async Task InsertProjectAllocation([FromBody] InsertProjectAllocation projectAllocation)
        {
            await _iProjectAllocationLogic.InsertProjectAllocation(projectAllocation);
        }

        /// <summary>
        /// Update Account Manager Map
        /// </summary>
        /// <param name="accountManager"></param>
        /// <returns></returns>
        [Route("UpdateAccountManagerMap")]
        [HttpPost]
        public async Task UpdateAccountManagerMap([FromBody] InsertAccountManager accountManager)
        {
            await _iProjectAllocationLogic.UpdateAccountManagerMap(accountManager);
        }

        /// <summary>
        /// Insert Project Allocation
        /// </summary>
        /// <param name="accountManager"></param>
        /// <returns></returns>
        [Route("UpdateProjectAllocation")]
        [HttpPost]
        public async Task UpdateProjectAllocation([FromBody] InsertProjectAllocation projectAllocation)
        {
            await _iProjectAllocationLogic.UpdateProjectAllocation(projectAllocation);
        }

        /// <summary>
        /// Delete Account Manager
        /// </summary>
        /// <param name="AccountId">document id</param>
        /// <returns></returns>
        [Route("DeleteAccountManagerMap")]
        [HttpDelete]
        public async Task<IActionResult> DeleteAccountManagerMap(int AccountId)
        {
            ReturnResponseModel result = new ReturnResponseModel();
            result = await _iProjectAllocationLogic.DeleteAccountManagerMap(AccountId);
            if (result.Status)
            {
                return NoContent();
            }
            return BadRequest(result);
        }


        /// <summary>
        /// Delete Project Allocation
        /// </summary>
        /// <param name="AccountId">document id</param>
        /// <returns></returns>
        [Route("DeleteProjectAllocation")]
        [HttpDelete]
        public async Task<IActionResult> DeleteProjectAllocation(int AccountId)
        {
            ReturnResponseModel result = new ReturnResponseModel();
            result = await _iProjectAllocationLogic.DeleteProjectAllocation(AccountId);
            if (result.Status)
            {
                return NoContent();
            }
            return BadRequest(result);
        }

        #endregion
    }
}
