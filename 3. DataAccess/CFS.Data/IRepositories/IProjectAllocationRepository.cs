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
        Task DeleteAccountManagerMap(int AccountId);

        /// <summary>
        /// Delete Project Allocation
        /// </summary>
        /// <param name="AccountId"></param>
        /// <returns></returns>
        Task DeleteProjectAllocation(int AccountId);
    }
}
