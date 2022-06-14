using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CFS.Model.Models
{
    #region Account Manager

    public class InsertAccountManager
    {
        public int AccountId { get; set; }
        public int ProjectId { get; set; }
        public int SowId { get; set; }
        public int AccountManagerId { get; set; }
        public int AccountManagerMapId { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
    }

    public class InsertProjectAllocation
    { 
        public int AccountId { get; set; }
        public int ProjectId { get; set; }
        public int SowId { get; set; }
        public int EmployeeId { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public decimal Billability { get; set; }
        public string AllocationType { get; set; }
    }

    public class AccountManagerMapModel
    {
        public int? AccountManagerMapId { get; set; }
        public int SowId { get; set; }
        public string SowName { get; set; }
        public int? ProjectId { get; set; }
        public string ProjectName { get; set; }
        public int? AccountManagerId { get; set; }
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

    public class ProjectAllocationModel
    {
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

    public class EmployeeBillabilityModel
    {
        public int EmployeeId { get; set; }
        public decimal BalanceBillability { get; set; }
    }

    public class EmployeeDetailsModel
    {

        public int EmployeeId { get; set; }
        public string EmployeeName { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public int? DirectReportingManagerId { get; set; }
        public string DirectReportingManagerName { get; set; }
        public int? IndirectReportingManagerId { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public string IndirectReportingManagerName { get; set; }
        public int? AgreedDailyWorkingHours { get; set; }
        public int? EmployeeTypeId { get; set; }
        public string EmployeeType { get; set; }
        public string PrimarySkill { get; set; }
        public string SecondarySkill { get; set; }
        public string SkillName { get; set; }
        public string SkillTypeName { get; set; }
        public int? SkillId { get; set; }
        public int? SkillTypeId { get; set; }
        public int? DepartmentId { get; set; }
        public string DepartmentName { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public DateTime? HireDate { get; set; }
    }
    #endregion
}
