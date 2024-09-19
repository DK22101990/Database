using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CFS.Data.Domains
{
    public class EmpMonthlyHoursList
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
    public class GetYearsList
    {
        [Key]
        public int YearId { get; set; }
        public int YearValue { get; set; }
    }
    public class GetMonthsList
    {
        [Key]
        public int MonthId { get; set; }
        public string MonthValue { get; set; }
    }
}
