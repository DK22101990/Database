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
        public async Task<IActionResult> InsertProjectAllocation([FromBody] InsertProjectAllocation projectAllocation)
        {

            ReturnResponseModel result = new ReturnResponseModel();
            if (projectAllocation != null)
            {
                result = await _iProjectAllocationLogic.InsertProjectAllocation(projectAllocation);
                if (result.Status)
                {
                    return Ok(result);
                }
            }
            return BadRequest(result);
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
        public async Task<IActionResult> UpdateProjectAllocation([FromBody] UpdateProjectAllocation projectAllocation)
        {
            ReturnResponseModel result = new ReturnResponseModel();
            if (projectAllocation != null)
            {
                result = await _iProjectAllocationLogic.UpdateProjectAllocation(projectAllocation);
                if (result.Status)
                {
                    return Ok(result);
                }
            }
            return BadRequest(result);
        }




        /// <summary>
        /// Delete Account Manager
        /// </summary>
        /// <param name="AccountId">document id</param>
        /// <returns></returns>
        [Route("DeleteAccountManagerMap")]
        [HttpDelete]
        public async Task<IActionResult> DeleteAccountManagerMap(int accountManagerMapId)
        {
            ReturnResponseModel result = new ReturnResponseModel();
            result = await _iProjectAllocationLogic.DeleteAccountManagerMap(accountManagerMapId);
            if (result.Status)
            {
                return NoContent();
            }
            return BadRequest(result);
        }


        /// <summary>
        /// Delete Project Allocation
        /// </summary>
        /// <param name="ProjectAllocationsId">document id</param>
        /// <returns></returns>
        [Route("DeleteProjectAllocation")]
        [HttpDelete]
        public async Task<IActionResult> DeleteProjectAllocation(int ProjectAllocationsId)
        {
            ReturnResponseModel result = new ReturnResponseModel();
            result = await _iProjectAllocationLogic.DeleteProjectAllocation(ProjectAllocationsId);
            if (result.Status)
            {
                return NoContent();
            }
            return BadRequest(result);
        }

        /// <summary>
        /// Get Account Manager Map
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="sowId"></param>
        /// <param name="accountId"></param>
        /// <returns></returns>
        [Route("GetAccountManagerMap")]
        [HttpGet]
        public async Task<IActionResult> GetAccountManagerMapAsync(int projectId, int sowId, int accountId)
        {
            return Ok(await _iProjectAllocationLogic.GetAccountManagerMapAsync(projectId, sowId, accountId));
        }

        /// <summary>
        /// Get Project Allocation
        /// </summary>
        /// <param name="managerId"></param>
        /// <param name="projectId"></param>
        /// <param name="sowId"></param>
        /// <param name="accountId"></param>
        /// <returns></returns>
        [Route("GetProjectAllocation")]
        [HttpGet]
        public async Task<IActionResult> GetProjectAllocationAsync(int managerId, int projectId, int sowId, int accountId)
        {
            return Ok(await _iProjectAllocationLogic.GetProjectAllocationAsync(managerId, projectId, sowId, accountId));
        }


       

        /// <summary>
        /// Get Employee Billability
        /// </summary>
        /// <param name="employeeId"></param>
        /// <returns></returns>
        [Route("GetEmployeeBillability")]
        [HttpGet]
        public async Task<IActionResult> GetEmployeeBillabilityAsync(int employeeId)
        {
            return Ok(await _iProjectAllocationLogic.GetEmployeeBillabilityAsync(employeeId));
        }

        /// <summary>
        /// Get Accounts Project Manager List
        /// </summary>
        /// <param name="managerId"></param>
        /// <returns></returns>
        [Route("GetAccountListOnProjectManager")]
        [HttpGet]
        public async Task<List<ProjectAccountManagerViewModel>> GetAccountListOnProjectManagerAsync(int managerId)
        {
            return await _iProjectAllocationLogic.GetAccountListOnProjectManagerAsync(managerId);
        }


        #region Employee Module
        /// <summary>
        /// Get Employee Details
        /// </summary>
        /// <param name="employeeId"></param>
        /// <returns></returns>
        /// 


        [Route("GetEmployeeDetail/{employeeId}")]
        [HttpGet]
        public async Task<IActionResult> GetEmployeeDetailAsync(int employeeId)
        {
            return Ok(await _iProjectAllocationLogic.GetEmployeeDetailAsync(employeeId));
        }

        /// <summary>
        /// Insert Employee Details
        /// </summary>
        /// <param name="employee"></param>
        /// <returns></returns>
        [Route("InsertEmployeeDetail")]
        [HttpPost]
        public async Task InsertEmployeeDetail([FromBody] InsertEmployeeDetailsModel employee)
        {
            await _iProjectAllocationLogic.InsertEmployeeDetailAsync(employee);
        }

        /// <summary>
        /// Update employee details
        /// </summary>
        /// <param name="employee"></param>
        /// <returns></returns>
        [Route("UpdateEmployeeDetail")]
        [HttpPost]
        public async Task UpdateEmployeeDetail([FromBody] UpdateEmployeeDetailsModel employee)
        {
            await _iProjectAllocationLogic.UpdateEmployeeDetailAsync(employee);
        }
        /// <summary>
        /// Delete Employee Details
        /// </summary>
        /// <param name="employeeId">employeeId</param>
        /// <returns></returns>
        [Route("DeleteEmployeeDetail")]
        [HttpDelete]
        public async Task<IActionResult> DeleteEmployeeDetail(int employeeId)
        {
            ReturnResponseModel result = new ReturnResponseModel();
            result = await _iProjectAllocationLogic.DeleteEmployeeDetail(employeeId);
            if (result.Status)
            {
                return NoContent();
            }
            return BadRequest(result);
        }


        /// <summary>
        /// GetBillabilityandUtilizationAsync 
        /// </summary>
        /// <param name="utilizationRequest"></param>
        /// <returns></returns>
        [Route("GetBillabilityandUtilization")]
        [HttpPost]
        public async Task<IActionResult> GetBillabilityandUtilizationAsync([FromBody] BillabilityandUtilizationRequest utilizationRequest)
        {
            return Ok(await _iProjectAllocationLogic.GetBillabilityandUtilizationAsync(utilizationRequest));
        }

        /// <summary>
        /// GetBillabilityandUtilizationAsync 
        /// </summary>
        /// <param name="utilizationRequest"></param>
        /// <returns></returns>
        [Route("GetBillabilityandUtilizationTest")]
        [HttpPost]
        public async Task<IActionResult> GetBillabilityandUtilizationTest([FromBody] BillabilityandUtilizationRequest utilizationRequest)
        {
            return Ok(await _iProjectAllocationLogic.GetBillabilityandUtilizationAsync(utilizationRequest));
        }
        #endregion

        #endregion
    }
   
}
