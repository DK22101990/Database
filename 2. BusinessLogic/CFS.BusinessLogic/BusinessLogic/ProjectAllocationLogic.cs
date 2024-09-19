using AutoMapper;
using CFS.BusinessLogic.IBusinessLogic;
using CFS.Data.IRepositories;
using CFS.Data.Models;
using CFS.Data.Repositories;
using CFS.Model.Helpers;
using CFS.Model.Models;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore.ChangeTracking.Internal;
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
        public async Task<ReturnResponseModel> InsertProjectAllocation(InsertProjectAllocation projectAllocation)
        {
            var objResult = await _iProjectAllocationRepository.InsertProjectAllocation(projectAllocation);
            if (objResult.Status)
            {
                return new ReturnResponseModel
                {
                    Status = true,
                    Message = string.Format(ApplicationMessage.SaveSuccessfully, "Insert Project Allocation ")
                };
            }
            return new ReturnResponseModel
            {
                Status = false,
                Message = string.Format(ApplicationMessage.BadRequst)
            };
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
        public async Task<ReturnResponseModel> UpdateProjectAllocation(UpdateProjectAllocation projectAllocation)
        {
            var objResult = await _iProjectAllocationRepository.UpdateProjectAllocation(projectAllocation);
            if (objResult.Status)
            {
                return new ReturnResponseModel
                {
                    Status = true,
                    Message = string.Format(ApplicationMessage.UpdateSuccessfully, "Project Allocation")
                };
            }
            return new ReturnResponseModel
            {
                Status = false,
                Message = string.Format(ApplicationMessage.BadRequst)
            };
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
        /// <param name="ProjectAllocationsId"></param>
        /// <returns></returns>
        public async Task<ReturnResponseModel> DeleteProjectAllocation(int ProjectAllocationsId)
        {
            await _iProjectAllocationRepository.DeleteProjectAllocation(ProjectAllocationsId);
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
            return _mapper.Map<List<AccountManagerMapModel>>(await _iProjectAllocationRepository.GetAccountManagerMapAsync(projectId, sowId, accountId));
        }

        /// <summary>
        /// Get Project Allocation
        /// </summary>
        /// <param name="managerId"></param>
        /// <param name="projectId"></param>
        /// <param name="sowId"></param>
        /// <param name="accountId"></param>
        /// <returns></returns>
        public async Task<List<ProjectAllocationModel>> GetProjectAllocationAsync(int managerId, int projectId, int sowId, int accountId)
        {
            return _mapper.Map<List<ProjectAllocationModel>>(await _iProjectAllocationRepository.GetProjectAllocationAsync(managerId, projectId, sowId, accountId));
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
        /// Get Bilability and Utilization
        /// </summary>
        /// <param name="employeeId"></param>
        /// <returns></returns>
        /// 
        public async Task<List<BillabilityandUtilizationModel>> GetBillabilityandUtilizationAsync(BillabilityandUtilizationRequest utilizationRequest)
        {
            return _mapper.Map<List<BillabilityandUtilizationModel>>(await _iProjectAllocationRepository.GetBillabilityandUtilizationAsync(utilizationRequest));
        }


        /// <summary>
        /// Get Employee Details
        /// </summary>
        /// <param name="employeeId"></param>
        /// <returns></returns>
        public async Task<List<EmployeeDetailsModel>> GetEmployeeDetailAsync(int employeeId)
        {
            try
            {
                return _mapper.Map<List<EmployeeDetailsModel>>(await _iProjectAllocationRepository.GetEmployeeDetailAsync(employeeId));
            }
            catch (Exception ex)
            {

                throw;
            }
        }

        /// <summary>
        /// Insert Employee Details
        /// </summary>
        /// <param name="employee"></param>
        /// <returns></returns>
        public async Task InsertEmployeeDetailAsync(InsertEmployeeDetailsModel employee)
        {
            await _iProjectAllocationRepository.InsertEmployeeDetailAsync(employee);
        }


        /// <summary>
        /// Update Employee Details
        /// </summary>
        /// <param name="employee"></param>
        /// <returns></returns>
        public async Task UpdateEmployeeDetailAsync(UpdateEmployeeDetailsModel employee)
        {
            await _iProjectAllocationRepository.UpdateEmployeeDetailAsync(employee);
        }

        /// <summary>
        /// Delete Project Allocation
        /// </summary>
        /// <param name="employeeId"></param>
        /// <returns></returns>
        public async Task<ReturnResponseModel> DeleteEmployeeDetail(int employeeId)
        {
            await _iProjectAllocationRepository.DeleteEmployeeDetail(employeeId);
            return new ReturnResponseModel
            {
                Status = true,
                Message = string.Format(ApplicationMessage.DeleteSuccessfully, "Employee Details")
            };
        }

        /// <summary>
        /// Get Accounts Project Manager List
        /// </summary>
        /// <param name="managerId"></param>
        /// <returns></returns>
        public async Task<List<ProjectAccountManagerViewModel>> GetAccountListOnProjectManagerAsync(int managerId)
        {
            return _mapper.Map<List<ProjectAccountManagerViewModel>>(await _iProjectAllocationRepository.GetAccountListOnProjectManagerAsync(managerId));
        }
        #endregion
    }
}
