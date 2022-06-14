using CFS.Data.Context;
using CFS.Data.Domains;
using CFS.Data.IRepositories;
using CFS.Model.Constants;
using CFS.Model.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
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
        public async Task InsertProjectAllocation(InsertProjectAllocation projectAllocation)
        {
            var commandText = string.Format(StoreProcedure.InsertProjectAllocation,
                projectAllocation.EmployeeId,
                projectAllocation.ProjectId,
                projectAllocation.SowId,
                projectAllocation.AccountId,
                projectAllocation.StartDate,
                projectAllocation.EndDate,
                projectAllocation.Billability,
                projectAllocation.AllocationType);
            await Context.Database.ExecuteSqlRawAsync(commandText);
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
        public async Task UpdateProjectAllocation(InsertProjectAllocation projectAllocation)
        {
            var commandText = string.Format(StoreProcedure.UpdateProjectAllocation,
                projectAllocation.EmployeeId,
                projectAllocation.ProjectId,
                projectAllocation.SowId,
                projectAllocation.AccountId,
                projectAllocation.StartDate,
                projectAllocation.EndDate,
                projectAllocation.Billability,
                projectAllocation.AllocationType);
            await Context.Database.ExecuteSqlRawAsync(commandText);
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
        /// <param name="AccountId"></param>
        /// <returns></returns>
        public async Task DeleteProjectAllocation(int AccountId)
        {
            var commandText = string.Format(StoreProcedure.DeleteProjectAllocation, AccountId);
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
        /// <param name="employeeId"></param>
        /// <param name="projectId"></param>
        /// <param name="sowId"></param>
        /// <param name="accountId"></param>
        /// <returns></returns>
        public async Task<List<ProjectAllocationList>> GetProjectAllocationAsync(int employeeId, int projectId, int sowId, int accountId)
        {
            var commandText = string.Format(StoreProcedure.GetProjectAllocation, employeeId, projectId, sowId, accountId);
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
        public async Task InsertEmployeeDetailAsync(EmployeeDetailsModel employee)
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
                employee.HireDate,
                employee.StartDate,
                employee.EndDate,
                employee.PrimarySkill,
                employee.SecondarySkill);
            await Context.Database.ExecuteSqlRawAsync(commandText);
        }

        // <summary>
        /// Update Employee Details
        /// </summary>
        /// <param name="employee"></param>
        /// <returns></returns>
        public async Task UpdateEmployeeDetailAsync(EmployeeDetailsModel employee)
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
                employee.HireDate,
                employee.StartDate,
                employee.EndDate,
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
        #endregion
    }
}
