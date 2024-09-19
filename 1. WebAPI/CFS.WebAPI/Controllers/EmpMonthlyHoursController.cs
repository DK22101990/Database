using CFS.BusinessLogic.BusinessLogic;
using CFS.BusinessLogic.IBusinessLogic;
using CFS.Data.Domains;
using CFS.Data.Models;
using CFS.Model.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CFS.WebAPI.Controllers
{
    [Route("api/v1/[controller]")]
    public class EmpMonthlyHoursController : Controller
    {
        #region Variables

        private readonly IEmpMonthlyHoursLogic _iEmpMonthlyHoursLogic;
        private readonly IConfiguration _configuration;
        private readonly ILogger _logger;
        #endregion Variables

        #region Constructor
        public EmpMonthlyHoursController(IEmpMonthlyHoursLogic iEmpMonthlyHoursLogic, ILoggerFactory factory,
            ILogger<EmpMonthlyHoursController> logger)
        {
            factory.CreateLogger<EmpMonthlyHoursController>();
            _iEmpMonthlyHoursLogic = iEmpMonthlyHoursLogic;
            _logger = logger;
        }
        #endregion

        #region Actions

        /// <summary>
        /// Get Employee Monthly Hours
        /// </summary>
        /// <returns></returns>
        [Route("GetEmployeeMonthlyHours")]
        [HttpGet]
        public async Task<List<EmpMonthlyHoursViewModel>> GetEmployeeMonthlyHours(int EmployeeId)
        {
            return await _iEmpMonthlyHoursLogic.GetEmployeeMonthlyHours(EmployeeId);
        }

        /// <summary>
        /// insert Account response
        /// </summary>
        /// <param name="objEmpMonthlyHoursModel"></param>
        /// <returns></returns>
        [Route("InsertEmpMonthlyHours")]
        [HttpPost]
        public async Task<IActionResult> InsertEmpMonthlyHours([FromBody] InsertEmpMonthlyHoursResponseModel objEmpMonthlyHoursModel)
        {

            ReturnResponseModel result = new ReturnResponseModel();
            if (objEmpMonthlyHoursModel != null)
            {
                result = await _iEmpMonthlyHoursLogic.InsertEmpMonthlyHours(objEmpMonthlyHoursModel);
                if (result.Status)
                {
                    return Ok(result);
                }
            }
            return BadRequest(result);
        }

        [Route("InsertHolidayList")]
        [HttpPost]
        public async Task<IActionResult> InsertHolidayList([FromBody] List<InsertHolidayListModel> objHolidayListModel)
        {

            ReturnResponseModel result = new ReturnResponseModel();
            if (objHolidayListModel != null)
            {
                result = await _iEmpMonthlyHoursLogic.InsertHolidayList(objHolidayListModel);
                if (result.Status)
                {
                    return Ok(result);
                }
            }
            return BadRequest(result);
        }

        [Route("InsertTimesheetExport")]
        [HttpPost]
        public async Task<IActionResult> InsertTimesheetExport([FromBody] List<InsertTimesheetExportModel> insertTimesheetExportObj, int Year, string Month)
        {

            ReturnResponseModel result = new ReturnResponseModel();
            if (insertTimesheetExportObj != null)
            {
                result = await _iEmpMonthlyHoursLogic.InsertTimesheetExport(insertTimesheetExportObj,Year,Month);
                if (result.Status)
                {
                    return Ok(result);
                }
            }
            return BadRequest(result);
        }

        [Route("GetYears")]
        [HttpGet]
        public async Task<List<GetYearsModel>> GetYears()
        {
            return await _iEmpMonthlyHoursLogic.GetYears();
        }

        [Route("GetMonths")]
        [HttpGet]
        public async Task<List<GetMonthsModel>> GetMonths()
        {
            return await _iEmpMonthlyHoursLogic.GetMonths();
        }

        #endregion Actions

    }
}
