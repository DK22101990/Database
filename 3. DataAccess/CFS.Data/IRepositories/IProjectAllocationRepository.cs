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
        Task<ReturnResponseModel> InsertProjectAllocation(InsertProjectAllocation projectAllocation);

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
        Task<ReturnResponseModel> UpdateProjectAllocation(UpdateProjectAllocation projectAllocation);

        /// <summary>
        /// Delete Account Manager
        /// </summary>
        /// <param name="AccountId"></param>
        /// <returns></returns>
        Task DeleteAccountManagerMap(int accountManagerMapId);

        /// <summary>
        /// Delete Project Allocation
        /// </summary>
        /// <param name="ProjectAllocationsId"></param>
        /// <returns></returns>
        Task DeleteProjectAllocation(int ProjectAllocationsId);

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
        /// <param name="managerId"></param>
        /// <param name="projectId"></param>
        /// <param name="sowId"></param>
        /// <param name="accountId"></param>
        /// <returns></returns>
        Task<List<ProjectAllocationList>> GetProjectAllocationAsync(int managerId, int projectId, int sowId, int accountId);

       
        /// <summary>
        /// Get Employee Billability
        /// </summary>
        /// <param name="employeeId"></param>
        /// <returns></returns>
        Task<List<EmployeeBillability>> GetEmployeeBillabilityAsync(int employeeId);


        /// <summary>
        /// Get Billability and Utilization
        /// </summary>
        /// <param name="employeeId"></param>
        /// <returns></returns>
        /// 
        Task<List<BilllabilityandUtilizationList>> GetBillabilityandUtilizationAsync(BillabilityandUtilizationRequest utilizationRequest);

        /// <summary>
        /// Get Employee Details
        /// </summary>
        /// <param name="employeeId"></param>
        /// <returns></returns>
        Task<List<EmployeeDetails>> GetEmployeeDetailAsync(int employeeId);

        // <summary>
        /// Insert Employee Details
        /// </summary>
        /// <param name="employee"></param>
        /// <returns></returns>
        Task InsertEmployeeDetailAsync(InsertEmployeeDetailsModel employee);

        // <summary>
        /// Update Employee Details
        /// </summary>
        /// <param name="employee"></param>
        /// <returns></returns>
        Task UpdateEmployeeDetailAsync(UpdateEmployeeDetailsModel employee);

        /// <summary>
        /// Delete Project Allocation
        /// </summary>
        /// <param name="employeeId"></param>
        /// <returns></returns>
        Task DeleteEmployeeDetail(int employeeId);

        /// <summary>
        /// Get Accounts Project Manager List
        /// </summary>
        /// <param name="managerId"></param>
        /// <returns></returns>
        Task<List<ProjectAccountManagerList>> GetAccountListOnProjectManagerAsync(int managerId);
    }
}
