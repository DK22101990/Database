using CFS.Data.Context;
using CFS.Data.Domains;
using CFS.Data.IRepositories;
using CFS.Data.Models;
using CFS.Model.Constants;
using CFS.Model.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace CFS.Data.Repositories
{
    public class ProjectAllocationRepository : Repository, IProjectAllocationRepository
    {
        #region Constructor

        public ProjectAllocationRepository(CFSContext applicationDbContext) : base(applicationDbContext)
        {
        }

        #endregion Constructor

        #region Methods

        /// <summary>
        /// Insert Account Manager Map
        /// </summary>
        /// <param name="accountManager"></param>
        /// <returns></returns>
        public async Task InsertAccountManagerMap(InsertAccountManager accountManager)
        {
            var commandText = string.Format(StoreProcedure.InsertAccountManagerMap,
                accountManager.SowId,
                accountManager.ProjectId,
                accountManager.AccountManagerId,
                accountManager.AccountId,
                accountManager.StartDate,
                accountManager.EndDate);
            await Context.Database.ExecuteSqlRawAsync(commandText);
        }

        /// <summary>
        /// Insert Project Allocation
        /// </summary>
        /// <param name="projectAllocation"></param>
        /// <returns></returns>
        public async Task<ReturnResponseModel> InsertProjectAllocation(InsertProjectAllocation projectAllocation)
        {
            try
            {
                var commandText = string.Format(StoreProcedure.InsertProjectAllocation,
                projectAllocation.EmployeeId,
                projectAllocation.ManagerId,
                projectAllocation.ProjectId,
                projectAllocation.SowId,
                projectAllocation.AccountId,
                projectAllocation.ProjectOnBoardingDate,
                projectAllocation.ProjectOffBoardingDate,
                projectAllocation.SowHourlyRate,
                projectAllocation.UtilizationStatus,
                projectAllocation.Billability,
                projectAllocation.AllocationType,
                projectAllocation.AllocatedUtilization,
                projectAllocation.AllocatedBillability,
                projectAllocation.Comments);
                await Context.Database.ExecuteSqlRawAsync(commandText);
                return new ReturnResponseModel { Status = true };
            }
            catch (Exception)
            {
                return new ReturnResponseModel { Status = false };
            }
        }


        /// <summary>
        /// Update Account Manager Map
        /// </summary>
        /// <param name="accountManager"></param>
        /// <returns></returns>
        public async Task UpdateAccountManagerMap(InsertAccountManager accountManager)
        {
            var commandText = string.Format(StoreProcedure.UpdateAccountManagerMap,
                accountManager.AccountManagerId,
                accountManager.AccountManagerMapId,
                accountManager.StartDate,
                accountManager.EndDate);
            await Context.Database.ExecuteSqlRawAsync(commandText);
        }

        /// <summary>
        /// Update Project Allocation
        /// </summary>
        /// <param name="projectAllocation"></param>
        /// <returns></returns>
        public async Task<ReturnResponseModel> UpdateProjectAllocation(UpdateProjectAllocation projectAllocation)
        {
            try
            {
                var commandText = string.Format(StoreProcedure.UpdateProjectAllocation,

                projectAllocation.EmployeeId,
                projectAllocation.ProjectAllocationId,
                projectAllocation.ProjectId,
                projectAllocation.SowId,
                projectAllocation.AccountId,
                projectAllocation.ProjectOnBoardingDate,
                projectAllocation.ProjectOffBoardingDate,
                projectAllocation.SowHourlyRate,
                projectAllocation.UtilizationStatus,
                projectAllocation.Billability,
                projectAllocation.AllocationType,
                projectAllocation.AllocatedUtilization,
                projectAllocation.AllocatedBillability,
                projectAllocation.isactive,
                projectAllocation.Comments);
                await Context.Database.ExecuteSqlRawAsync(commandText);

                return new ReturnResponseModel { Status = true };
            }
            catch (Exception)
            {
                return new ReturnResponseModel { Status = false };
            }
        }


        /// <summary>
        /// Delete Account Manager
        /// </summary>
        /// <param name="AccountId"></param>
        /// <returns></returns>
        public async Task DeleteAccountManagerMap(int accountManagerMapId)
        {
            var commandText = string.Format(StoreProcedure.DeleteAccountManagerMap, accountManagerMapId);
            await Context.Database.ExecuteSqlRawAsync(commandText);
        }

        /// <summary>
        /// Delete Project Allocation
        /// </summary>
        /// <param name="ProjectAllocationsId"></param>
        /// <returns></returns>
        public async Task DeleteProjectAllocation(int ProjectAllocationsId)
        {
            var commandText = string.Format(StoreProcedure.DeleteProjectAllocation, ProjectAllocationsId);
            await Context.Database.ExecuteSqlRawAsync(commandText);
        }

        /// <summary>
        /// Get Account Manager Map
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="sowId"></param>
        /// <param name="accountId"></param>
        /// <returns></returns>
        public async Task<List<AccountManagerMapList>> GetAccountManagerMapAsync(int projectId, int sowId, int accountId)
        {
            var commandText = string.Format(StoreProcedure.GetAccountManagerMap, projectId, sowId, accountId);
            return await Context.GetAccountManagerMapList.FromSqlRaw<AccountManagerMapList>(commandText).ToListAsync();
        }

        /// <summary>
        /// Get Project Allocation
        /// </summary>
        /// <param name="managerId"></param>
        /// <param name="projectId"></param>
        /// <param name="sowId"></param>
        /// <param name="accountId"></param>
        /// <returns></returns>
        public async Task<List<ProjectAllocationList>> GetProjectAllocationAsync(int managerId, int projectId, int sowId, int accountId)
        {
            var commandText = string.Format(StoreProcedure.GetProjectAllocation, managerId, projectId, sowId, accountId);
            return await Context.GetProjectAllocationList.FromSqlRaw<ProjectAllocationList>(commandText).ToListAsync();
        }


       
        /// <summary>
        /// Get Employee Billability
        /// </summary>
        /// <param name="employeeId"></param>
        /// <returns></returns>
        public async Task<List<EmployeeBillability>> GetEmployeeBillabilityAsync(int employeeId)
        {
            var commandText = string.Format(StoreProcedure.GetEmployeeBillability, employeeId);
            return await Context.GetEmployeeBillability.FromSqlRaw<EmployeeBillability>(commandText).ToListAsync();
        }

        /// <summary>
        /// Get Employee Details
        /// <param name="employeeId"></param>
        /// <returns></returns>
        public async Task<List<EmployeeDetails>> GetEmployeeDetailAsync(int employeeId)
        {
            var commandText = string.Format(StoreProcedure.GetEmployeeDetail, employeeId);
            return await Context.GetEmployeeDetail.FromSqlRaw<EmployeeDetails>(commandText).ToListAsync();
        }

        // <summary>
        /// Insert Employee Details
        /// </summary>
        /// <param name="employee"></param>
        /// <returns></returns>
        public async Task InsertEmployeeDetailAsync(InsertEmployeeDetailsModel employee)
        {
            var commandText = string.Format(StoreProcedure.InsertEmployeeDetail,
                employee.Firstname,
                employee.Lastname,
                employee.DirectReportingManagerId,
                employee.IndirectReportingManagerId,
                employee.AgreedDailyWorkingHours,
                employee.EmployeeTypeId,
                employee.DepartmentId,
                employee.Email,
                employee.PhoneNumber,
                employee.DateOfJoining,
                employee.PositionHiredFor,
                employee.Title,
                employee.ExitDate,
                employee.PrimarySkill,
                employee.SecondarySkill);
            await Context.Database.ExecuteSqlRawAsync(commandText);
        }

        // <summary>
        /// Update Employee Details
        /// </summary>
        /// <param name="employee"></param>
        /// <returns></returns>
        public async Task UpdateEmployeeDetailAsync(UpdateEmployeeDetailsModel employee)
        {
            var commandText = string.Format(StoreProcedure.UpdateEmployeeDetail,
                employee.EmployeeId,
                employee.Firstname,
                employee.Lastname,
                employee.DirectReportingManagerId,
                employee.IndirectReportingManagerId,
                employee.AgreedDailyWorkingHours,
                employee.EmployeeTypeId,
                employee.DepartmentId,
                employee.Email,
                employee.PhoneNumber,
                employee.DateOfJoining,
                employee.PositionHiredFor,
                employee.Title,
                employee.ExitDate,
                employee.PrimarySkill,
                employee.SecondarySkill);
            await Context.Database.ExecuteSqlRawAsync(commandText);
        }

        /// <summary>
        /// Delete Project Allocation
        /// </summary>
        /// <param name="employeeId"></param>
        /// <returns></returns>
        public async Task DeleteEmployeeDetail(int employeeId)
        {
            var commandText = string.Format(StoreProcedure.DeleteEmployeeDetail, employeeId);
            await Context.Database.ExecuteSqlRawAsync(commandText);
        }

        /// <summary>
        /// Get Accounts Project Manager List
        /// </summary>
        /// <param name="managerId"></param>
        /// <returns></returns>
        public async Task<List<ProjectAccountManagerList>> GetAccountListOnProjectManagerAsync(int managerId)
        {
            var commandText = string.Format(StoreProcedure.GetAccountListOnProjectManager, managerId);
            return await Context.GetAccountListOnProjectManager.FromSqlRaw<ProjectAccountManagerList>(commandText).ToListAsync();
        }

        /// <summary>
        /// Get Billability and Utilization
        /// </summary>
        /// <param name="employeeId"></param>
        /// <returns></returns>
        public async Task<List<BilllabilityandUtilizationList>> GetBillabilityandUtilizationAsync(BillabilityandUtilizationRequest request)
        {
            var commandText = string.Format(StoreProcedure.GetBillabilityandUtilization, request.EmployeeId, request.IsEditable, request.ProjectId,
                        request.SowId, request.ProjectAllocationsId,request.AllocatedBillability, request.AllocatedUtilization, request.StartDate, request.EndDate);
            return await Context.GetBillabilityandUtilization.FromSqlRaw<BilllabilityandUtilizationList>(commandText).ToListAsync();
        }

        #endregion

    }

}
