using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System;
using System.Collections.Generic;

#nullable disable

namespace CFS.Data.Models
{
    public partial class EmployeesMonthlyHours
    {
        [Key]
        public int HourID { get; set; }
        public int EmployeeID { get; set; }
        public string Month { get; set; }
        public int Year { get; set; }
        public decimal Hours { get; set; }
        public decimal TotalWorkingDays { get; set; }
        public decimal Leaves { get; set; }
    }
}
