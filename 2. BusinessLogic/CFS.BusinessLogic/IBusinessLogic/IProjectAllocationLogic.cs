using CFS.Data.Models;
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
        Task<ReturnResponseModel> InsertProjectAllocation(InsertProjectAllocation projectAllocation);

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
        Task<ReturnResponseModel> UpdateProjectAllocation(UpdateProjectAllocation projectAllocation);
        /// <summary>
        /// Delete Account Manager
        /// </summary>
        /// <param name="AccountId"></param>
        /// <returns></returns>
        Task<ReturnResponseModel> DeleteAccountManagerMap(int accountManagerMapId);

        /// <summary>
        /// Delete Project Allocation
        /// </summary>
        /// <param name="ProjectAllocationsId"></param>
        /// <returns></returns>
        Task<ReturnResponseModel> DeleteProjectAllocation(int ProjectAllocationsId);

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
        /// <param name="managerId"></param>
        /// <param name="projectId"></param>
        /// <param name="sowId"></param>
        /// <param name="accountId"></param>
        /// <returns></returns>
        Task<List<ProjectAllocationModel>> GetProjectAllocationAsync(int managerId, int projectId, int sowId, int accountId);

        /// <summary>
        /// Get billabilty and Utilization
        /// </summary>
        /// <param name="employeeId"></param>
        /// <returns></returns>  
        /// 
        Task<List<BillabilityandUtilizationModel>> GetBillabilityandUtilizationAsync(BillabilityandUtilizationRequest utilizationRequest);
        /// <summary>
        /// Get Employee Details
        /// </summary>
        /// <param name=""></param>
        /// <returns></returns>  
        Task<List<EmployeeBillabilityModel>> GetEmployeeBillabilityAsync(int employeeId);

        /// <summary>
        /// Get Employee Details
        /// </summary>
        /// <param name="employeeId"></param>
        /// <returns></returns>
        Task<List<EmployeeDetailsModel>> GetEmployeeDetailAsync(int employeeId);

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
        Task<ReturnResponseModel> DeleteEmployeeDetail(int employeeId);

        /// <summary>
        /// Get Accounts Project Manager List
        /// </summary>
        /// <param name="managerId"></param>
        /// <returns></returns>
        Task<List<ProjectAccountManagerViewModel>> GetAccountListOnProjectManagerAsync(int managerId);
    }
}
