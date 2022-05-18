using CFS.Data.Domains;
using CFS.Model.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CFS.Data.IRepositories
{
    public interface IProjectAllocationRepository
    {
        /// <summary>
        /// Insert Account Manager Map
        /// </summary>
        /// <param name="accountManager"></param>
        /// <returns></returns>
        Task InsertAccountManagerMap(InsertAccountManager accountManager);

        /// <summary>
        /// Insert Project Allocation
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
        /// Update Project Allocation
        /// </summary>
        /// <param name="projectAllocation"></param>
        /// <returns></returns>
        Task UpdateProjectAllocation(InsertProjectAllocation projectAllocation);

        /// <summary>
        /// Delete Account Manager
        /// </summary>
        /// <param name="AccountId"></param>
        /// <returns></returns>
        Task DeleteAccountManagerMap(int accountManagerMapId);

        /// <summary>
        /// Delete Project Allocation
        /// </summary>
        /// <param name="AccountId"></param>
        /// <returns></returns>
        Task DeleteProjectAllocation(int AccountId);

        /// <summary>
        /// Get Account Manager Map
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="sowId"></param>
        /// <param name="accountId"></param>
        /// <returns></returns>
        Task<List<AccountManagerMapList>> GetAccountManagerMapAsync(int projectId, int sowId, int accountId);

        /// <summary>
        /// Get Project Allocation
        /// </summary>
        /// <param name="employeeId"></param>
        /// <param name="projectId"></param>
        /// <param name="sowId"></param>
        /// <param name="accountId"></param>
        /// <returns></returns>
        Task<List<ProjectAllocationList>> GetProjectAllocationAsync(int employeeId, int projectId, int sowId, int accountId);

        /// <summary>
        /// Get Employee Billability
        /// </summary>
        /// <param name="employeeId"></param>
        /// <returns></returns>
        Task<List<EmployeeBillability>> GetEmployeeBillabilityAsync(int employeeId);
    }
}
