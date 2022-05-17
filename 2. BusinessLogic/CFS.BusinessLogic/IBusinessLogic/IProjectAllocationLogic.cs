using CFS.Model.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CFS.BusinessLogic.IBusinessLogic
{
    public interface IProjectAllocationLogic
    {
        // <summary>
        /// Insert Account Manager Map
        /// </summary>
        /// <param name="accountManager"></param>
        /// <returns></returns>
        Task InsertAccountManagerMap(InsertAccountManager accountManager);

        /// <summary>
        ///  Insert Project Allocation
        /// </summary>
        /// <param name="projectAllocation"></param>
        /// <returns></returns>
        Task InsertProjectAllocation(InsertProjectAllocation projectAllocation);

        /// <summary>
        /// Update Account Manager Map
        /// </summary>
        /// <param name="accountManager"></param>
        /// <returns></returns>
        Task UpdateAccountManagerMap(InsertAccountManager accountManager);

        /// <summary>
        ///  Update Project Allocation
        /// </summary>
        /// <param name="projectAllocation"></param>
        /// <returns></returns>
        Task UpdateProjectAllocation(InsertProjectAllocation projectAllocation);

        /// <summary>
        /// Delete Account Manager
        /// </summary>
        /// <param name="AccountId"></param>
        /// <returns></returns>
        Task<ReturnResponseModel> DeleteAccountManagerMap(int AccountManagerId);

        /// <summary>
        /// Delete Project Allocation
        /// </summary>
        /// <param name="AccountId"></param>
        /// <returns></returns>
        Task<ReturnResponseModel> DeleteProjectAllocation(int AccountId);

        /// <summary>
        /// Get Account Manager Map
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="sowId"></param>
        /// <param name="accountId"></param>
        /// <returns></returns>
        Task<List<AccountManagerMapModel>> GetAccountManagerMapAsync(int projectId, int sowId, int accountId);

        /// <summary>
        /// Get Project Allocation
        /// </summary>
        /// <param name="employeeId"></param>
        /// <param name="projectId"></param>
        /// <param name="sowId"></param>
        /// <param name="accountId"></param>
        /// <returns></returns>
        Task<List<ProjectAllocationModel>> GetProjectAllocationAsync(int employeeId, int projectId, int sowId, int accountId);

        /// <summary>
        /// Get Employee Billability
        /// </summary>
        /// <param name="employeeId"></param>
        /// <returns></returns>
        Task<List<EmployeeBillabilityModel>> GetEmployeeBillabilityAsync(int employeeId);
    }
}
