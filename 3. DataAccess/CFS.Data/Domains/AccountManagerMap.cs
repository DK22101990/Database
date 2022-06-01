using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CFS.Data.Domains
{
    public class AccountManagerMapList
    {
        [Key]
        public int? AccountManagerMapId { get; set; }
        public int? AccountManagerId { get; set; }
        public int SowId { get; set; }
        public string SowName { get; set; }
        public int? ProjectId { get; set; }
        public string ProjectName { get; set; }       
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int? AccountId { get; set; }
        public string AccountName { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public int IsActive { get; set; }
        public DateTime? LastModifiedOn { get; set; }
        public int? ModifiedById { get; set; }
    }

    public class ProjectAllocationList
    {
        [Key]
        public int EmployeeId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int? ProjectId { get; set; }
        public string ProjectName { get; set; }
        public int SowId { get; set; }
        public string SowName { get; set; }
        public int? AccountId { get; set; }
        public string AccountName { get; set; }
        public decimal Billability { get; set; }
        public string AllocationType { get; set; }
        public int IsActive { get; set; }
        public DateTime? LastModifiedOn { get; set; }
        public int? ModifiedById { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
    }

    public class EmployeeBillability
    {
        [Key]
        public int EmployeeId { get; set; }
        public decimal BalanceBillability { get; set; }
    }

    public class EmployeeDetails
    {
        [Key]
        public int EmployeeId { get; set; }
        public string EmployeeName { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public int? DirectReportingManagerId { get; set; }
        public string DirectReportingManagerName { get; set; }
        public int? IndirectReportingManagerId { get; set; }
        public string IndirectReportingManagerName { get; set; }
        public int? AgreedDailyWorkingHours { get; set; }
        public int?  EmployeeTypeId { get; set; }
        public string EmployeeType { get; set; }
        public string PrimarySkill { get; set; }
        public string SecondarySkill { get; set; }
        public int? DepartmentId { get; set; }
        public string DepartmentName { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
    }
}
