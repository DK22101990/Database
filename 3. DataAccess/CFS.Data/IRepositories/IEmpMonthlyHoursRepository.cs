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
    public interface IEmpMonthlyHoursRepository
    {
        /// <summary>
        /// Get Account List
        /// </summary>
        /// <returns></returns>
        Task<List<EmpMonthlyHoursList>> GetEmployeeMonthlyHours(int EmployeeId);

        /// <summary>
        /// Insert Account Response
        /// </summary>
        /// <returns></returns>
        Task<ReturnResponseModel> InsertEmpMonthlyHours(InsertEmpMonthlyHoursResponseModel objEmpMonthlyHoursModel);
        Task<ReturnResponseModel> InsertHolidayList(List<InsertHolidayListModel> objHolidayListModel);
        Task<ReturnResponseModel> InsertTimesheetExport(List<InsertTimesheetExportModel> insertTimesheetExportObj, int Year, string Month);
        Task<List<GetYearsList>> GetYears();
        Task<List<GetMonthsList>> GetMonths();

    }
}
