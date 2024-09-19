using AutoMapper;
using CFS.BusinessLogic.IBusinessLogic;
using CFS.Data.Domains;
using CFS.Data.IRepositories;
using CFS.Data.Models;
using CFS.Data.Repositories;
using CFS.Model.Helpers;
using CFS.Model.Models;
using component.helper;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static CFS.Model.Enums.Enumeration;

namespace CFS.BusinessLogic.BusinessLogic
{
    public class EmpMonthlyHoursLogic : IEmpMonthlyHoursLogic
    {
        #region Variables

        private readonly IEmpMonthlyHoursRepository _iEmpHoursRepository;
        private readonly IConfiguration _configuration;
        private readonly IHostingEnvironment _hostingEnvironment;
        private readonly IMapper _mapper;

        #endregion Variables


        #region Constructor
        public EmpMonthlyHoursLogic(IEmpMonthlyHoursRepository iEmpHoursRepository, IConfiguration configuration, IHostingEnvironment hostingEnvironment,
            IMapper mapper)
        {
            _iEmpHoursRepository = iEmpHoursRepository;
            _configuration = configuration;
            _hostingEnvironment = hostingEnvironment;
            _mapper = mapper;
        }

        #endregion Constructor

        #region Methods

        /// <summary>
        /// Get Account List
        /// </summary>
        /// <param name="EmployeeId"></param>
        /// <returns></returns>
        public async Task<List<EmpMonthlyHoursViewModel>> GetEmployeeMonthlyHours(int EmployeeId)
        {
            return _mapper.Map<List<EmpMonthlyHoursViewModel>>(await _iEmpHoursRepository.GetEmployeeMonthlyHours(EmployeeId));
        }

        /// <summary>
        /// Insert EmpMonthly Hours
        /// </summary>
        /// <param name="objEmpMonthlyHoursModel"></param>
        /// <returns></returns>
        public async Task<ReturnResponseModel> InsertEmpMonthlyHours(InsertEmpMonthlyHoursResponseModel objEmpMonthlyHoursModel)
        {
            var objResult = await _iEmpHoursRepository.InsertEmpMonthlyHours(objEmpMonthlyHoursModel);
            if (objResult.Status)
            {
                return new ReturnResponseModel
                {
                    Status = true,
                    Message = string.Format(ApplicationMessage.SaveSuccessfully, "Employee Month Response")
                };
            }
            return new ReturnResponseModel
            {
                Status = false,
                Message = string.Format(ApplicationMessage.BadRequst)
            };
        }


        public async Task<ReturnResponseModel> InsertHolidayList(List<InsertHolidayListModel> objHolidayListModel)
        {
            var objResult = await _iEmpHoursRepository.InsertHolidayList(objHolidayListModel);
            if (objResult.Status)
            {
                return new ReturnResponseModel
                {
                    Status = true,
                    Message = string.Format(ApplicationMessage.SaveSuccessfully, "Holiday List Save Response")
                };
            }
            return new ReturnResponseModel
            {
                Status = false,
                Message = string.Format(ApplicationMessage.BadRequst)
            };
        }
        public async Task<ReturnResponseModel> InsertTimesheetExport(List<InsertTimesheetExportModel> insertTimesheetExportObj, int Year, string Month)
        {
            var objResult = await _iEmpHoursRepository.InsertTimesheetExport(insertTimesheetExportObj, Year, Month);
            if (objResult.Status)
            {
                return new ReturnResponseModel
                {
                    Status = true,
                    Message = string.Format(ApplicationMessage.SaveSuccessfully, "Holiday List Save Response")
                };
            }
            return new ReturnResponseModel
            {
                Status = false,
                Message = string.Format(ApplicationMessage.BadRequst)
            };
        }

        public async Task<List<GetYearsModel>> GetYears()
        {
            return _mapper.Map<List<GetYearsModel>>(await _iEmpHoursRepository.GetYears());
        }
        public async Task<List<GetMonthsModel>> GetMonths()
        {
            return _mapper.Map<List<GetMonthsModel>>(await _iEmpHoursRepository.GetMonths());
        }


        #endregion

    }
}
