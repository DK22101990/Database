using CFS.Data.Models;
using CFS.Model.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CFS.BusinessLogic.IBusinessLogic
{
    public interface IEmpMonthlyHoursLogic
    {
        #region EmpMonthlyHoursLogic
        /// <summary>
        /// Get Employee Monthly Hours
        /// </summary>
        /// <param name="EmployeeId"></param>
        /// <returns></returns>
        Task<List<EmpMonthlyHoursViewModel>> GetEmployeeMonthlyHours(int EmployeeId);

        /// <summary>
        /// Insert Emp Monthly Hours
        /// </summary>
        /// <param name="objEmpMonthlyHoursModel"></param>
        /// <returns></returns>
        Task<ReturnResponseModel> InsertEmpMonthlyHours(InsertEmpMonthlyHoursResponseModel objEmpMonthlyHoursModel);
        Task<ReturnResponseModel> InsertHolidayList(List<InsertHolidayListModel> objHolidayListModel);
        Task<ReturnResponseModel> InsertTimesheetExport(List<InsertTimesheetExportModel> insertTimesheetExportObj, int Year, string Month);
        Task<List<GetYearsModel>> GetYears();
        Task<List<GetMonthsModel>> GetMonths();

        #endregion
    }
}
