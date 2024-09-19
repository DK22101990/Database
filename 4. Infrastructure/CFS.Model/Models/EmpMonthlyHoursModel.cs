using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace CFS.Model.Models
{
    #region
    public class EmpMonthlyHoursViewModel
    {
        public int HourId { get; set; }
        public int EmployeeId { get; set; }
        public string Month { get; set; }
        public int Year { get; set; }
        public decimal Hours { get; set; }
        public decimal TotalWorkingDays { get; set; }
        public decimal Leaves { get; set; }
    }

    public class InsertEmpMonthlyHoursResponseModel
    {
        [Key]
        public int HourId { get; set; }
        public int EmployeeId { get; set; }
        public string Month { get; set; }
        public int Year { get; set; }
        public decimal Hours { get; set; }
        public decimal TotalWorkingDays { get; set; }
        public decimal Leaves { get; set; }
    }

        public class InsertHolidayListModel
    {
        public DateTime holidaydate { get; set; }
        public string description { get; set; }
        public int year { get; set; }
    }
    
        public class InsertTimesheetExportModel
    {
        public string employeename { get; set; }
        public DateTime date { get; set; }
        public string client { get; set; }
        public string project { get; set; }
        public int timeentered { get; set; }
    }

    public class GetYearsModel
    {
        [Key]
        public int YearID { get; set; }
        public int YearValue { get; set; }
    }
    public class GetMonthsModel
    {
        [Key]
        public int MonthID { get; set; }
        public string MonthValue { get; set; }
    }

    #endregion
}
