using AutoMapper;
using CFS.BusinessLogic.IBusinessLogic;
using CFS.Data.IRepositories;
using CFS.Model.Helpers;
using CFS.Model.Models;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CFS.BusinessLogic.BusinessLogic
{
    public class ProjectAllocationLogic : IProjectAllocationLogic
    {
        #region Variables

        private readonly IProjectAllocationRepository _iProjectAllocationRepository;
        private readonly IConfiguration _configuration;
        private readonly IHostingEnvironment _hostingEnvironment;
        private readonly IMapper _mapper;

        #endregion Variables

        #region Constructor
        public ProjectAllocationLogic(IProjectAllocationRepository iProjectAllocationRepository, IConfiguration configuration, IHostingEnvironment hostingEnvironment,
            IMapper mapper)
        {
            _iProjectAllocationRepository = iProjectAllocationRepository;
            _configuration = configuration;
            _hostingEnvironment = hostingEnvironment;
            _mapper = mapper;
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
            await _iProjectAllocationRepository.InsertAccountManagerMap(accountManager);
        }

        /// <summary>
        ///  Insert Project Allocation
        /// </summary>
        /// <param name="projectAllocation"></param>
        /// <returns></returns>
        public async Task InsertProjectAllocation(InsertProjectAllocation projectAllocation)
        {
            await _iProjectAllocationRepository.InsertProjectAllocation(projectAllocation);
        }

        /// <summary>
        /// Update Account Manager Map
        /// </summary>
        /// <param name="accountManager"></param>
        /// <returns></returns>
        public async Task UpdateAccountManagerMap(InsertAccountManager accountManager)
        {
            await _iProjectAllocationRepository.UpdateAccountManagerMap(accountManager);
        }

        /// <summary>
        ///  Update Project Allocation
        /// </summary>
        /// <param name="projectAllocation"></param>
        /// <returns></returns>
        public async Task UpdateProjectAllocation(InsertProjectAllocation projectAllocation)
        {
            await _iProjectAllocationRepository.UpdateProjectAllocation(projectAllocation);
        }

        /// <summary>
        /// Delete Account Manager
        /// </summary>
        /// <param name="AccountId"></param>
        /// <returns></returns>
        public async Task<ReturnResponseModel> DeleteAccountManagerMap(int accountManagerMapId)
        {
            await _iProjectAllocationRepository.DeleteAccountManagerMap(accountManagerMapId);
            return new ReturnResponseModel
            {
                Status = true,
                Message = string.Format(ApplicationMessage.DeleteSuccessfully, "Account Manager")
            };
        }

        /// <summary>
        /// Delete Project Allocation
        /// </summary>
        /// <param name="AccountId"></param>
        /// <returns></returns>
        public async Task<ReturnResponseModel> DeleteProjectAllocation(int AccountId)
        {
            await _iProjectAllocationRepository.DeleteProjectAllocation(AccountId);
            return new ReturnResponseModel
            {
                Status = true,
                Message = string.Format(ApplicationMessage.DeleteSuccessfully, "Project Allocation")
            };
        }

        /// <summary>
        /// Get Account Manager Map
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="sowId"></param>
        /// <param name="accountId"></param>
        /// <returns></returns>
        public async Task<List<AccountManagerMapModel>> GetAccountManagerMapAsync(int projectId, int sowId, int accountId)
        {
            return _mapper.Map<List<AccountManagerMapModel>>(await _iProjectAllocationRepository.GetAccountManagerMapAsync(projectId,sowId,accountId));
        }

        /// <summary>
        /// Get Project Allocation
        /// </summary>
        /// <param name="employeeId"></param>
        /// <param name="projectId"></param>
        /// <param name="sowId"></param>
        /// <param name="accountId"></param>
        /// <returns></returns>
        public async Task<List<ProjectAllocationModel>> GetProjectAllocationAsync(int employeeId, int projectId, int sowId, int accountId)
        {
            return _mapper.Map<List<ProjectAllocationModel>>(await _iProjectAllocationRepository.GetProjectAllocationAsync(employeeId,projectId, sowId, accountId));
        }

        /// <summary>
        /// Get Employee Billability
        /// </summary>
        /// <param name="employeeId"></param>
        /// <returns></returns>
        public async Task<List<EmployeeBillabilityModel>> GetEmployeeBillabilityAsync(int employeeId)
        {
            return _mapper.Map<List<EmployeeBillabilityModel>>(await _iProjectAllocationRepository.GetEmployeeBillabilityAsync(employeeId));
        }

        /// <summary>
        /// Get Employee Details
        /// </summary>
        /// <param name="employeeId"></param>
        /// <returns></returns>
        public async Task<List<EmployeeDetailsModel>> GetEmployeeDetailAsync(int employeeId)
        {            
            return _mapper.Map<List<EmployeeDetailsModel>>(await _iProjectAllocationRepository.GetEmployeeDetailAsync(employeeId));
        }

        /// <summary>
        /// Insert Employee Details
        /// </summary>
        /// <param name="employee"></param>
        /// <returns></returns>
        public async Task InsertEmployeeDetailAsync(EmployeeDetailsModel employee)
        {
            await _iProjectAllocationRepository.InsertEmployeeDetailAsync(employee);
        }

        /// <summary>
        /// Delete Project Allocation
        /// </summary>
        /// <param name="employeeId"></param>
        /// <returns></returns>
        public async  Task<ReturnResponseModel> DeleteEmployeeDetail(int employeeId)
        {
            await _iProjectAllocationRepository.DeleteEmployeeDetail(employeeId);
            return new ReturnResponseModel
            {
                Status = true,
                Message = string.Format(ApplicationMessage.DeleteSuccessfully, "Employee Details")
            };
        }
        #endregion
    }
}
