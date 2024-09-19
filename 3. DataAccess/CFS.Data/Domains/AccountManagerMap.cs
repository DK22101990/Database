using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CFS.Data.Domains
{
    public class ProjectAccountManagerList
    {
        [Key]
        public int? AccountId { get; set; }
        public int ManagerId { get; set; }
        public string ManagerName { get; set; }
        public string AccountName { get; set; }
        public int IsActive { get; set; }
    }
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
        public int ProjectAllocationsId { get; set; }
        public int EmployeeId { get; set; }
        public string EmployeeName { get; set; }
        public int? RoleId { get; set; }
        public string RoleName { get; set; }
        public int? EmployeeTypeId { get; set; }
        public string EmployeeType { get; set; }
        public int? SkillId { get; set; }
        public string SkillName { get; set; }
        public int? ProjectId { get; set; }
        public string ProjectName { get; set; }
        public int? SowId { get; set; }
        public string SowName { get; set; }
        public int? AccountId { get; set; }
        public string AccountName { get; set; }
        public int? Billability { get; set; }
        public string AllocationType { get; set; }
        public DateTime? ProjectOnBoardingDate { get; set; }
        public DateTime? ProjectOffBoardingDate { get; set; }
        public string SowHourlyRate { get; set; }
        public string UtilizationStatus { get; set; }
        public string AllocatedBillability { get; set; }
        public string AllocatedUtilization { get; set; }
        public int? AgreedDailyWorkingHours { get; set; }
        public string Designation { get; set; }
        public string isavailable { get; set; }
        public int IsActive { get; set; }
        public DateTime? LastModifiedOn { get; set; }
        public int? ModifiedById { get; set; }
        public int? ManagerId { get; set; }
        public string Comments { get; set; }

    }
    public class InsertProjectAllocationList
    {
        public int? EmployeeId { get; set; }
        public int? ManagerId { get; set; }
        public int? ProjectId { get; set; }
        public int? SowId { get; set; }
        public int? AccountId { get; set; }
        public DateTime? ProjectOnBoardingDate { get; set; }
        public DateTime? ProjectOffBoardingDate { get; set; }
        public string SowHourlyRate { get; set; }
        public string UtilizationStatus { get; set; }
        public int? Billability { get; set; }
        public string AllocationType { get; set; }
        public int? AllocatedUtilization { get; set; }
        public int? AllocatedBillability { get; set; }

        public string Comments { get; set; }
    }
    public class UpdateProjectAllocationList
    {
        public int? EmployeeId { get; set; }
        public int? ProjectId { get; set; }
        public int? SowId { get; set; }
        public int? AccountId { get; set; }
        public DateTime? ProjectOnBoardingDate { get; set; }
        public DateTime? ProjectOffBoardingDate { get; set; }
        public string SowHourlyRate { get; set; }
        public string UtilizationStatus { get; set; }
        public int? Billability { get; set; }
        public string AllocationType { get; set; }
        public int? AllocatedUtilization { get; set; }
        public int? AllocatedBillability { get; set; }
        public int isactive { get; set; }
        public string Comments { get; set; }
    }
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
    public string Firstname { get; set; }
    public string Lastname { get; set; }
    public string Email { get; set; }
    public int? ReportingManagerId { get; set; }
    public string DirectReportingManagerName { get; set; }
    public int? AgreedDailyWorkingHours { get; set; }
    public string PrimarySkill { get; set; }
    public string SecondarySkill { get; set; }
    public string PrimarySkillID { get; set; }
    public string SecondarySkillId { get; set; }
    public int? DepartmentId { get; set; }
    public string DepartmentName { get; set; }
    public DateTime? ExitDate { get; set; }
    public DateTime? DateOfJoining { get; set; }
    public string PositionHiredFor { get; set; }
    public int EmployeeTypeId { get; set; }
    public string EmployeeType { get; set; }
    public string Designation { get; set; }
}
//[Keyless]
public class BilllabilityandUtilizationList
{
    [Key]
    public int PrimaryId { get; set; }
    public string ProjectName { get; set; }
    public int EmployeeId { get; set; }
    public string AccountName { get; set; }   
    public string EmployeeName { get; set; }
    public string AvailableBillability { get; set; }
    public string AvailableUtilization { get; set; }
    public int? Invalid { get; set; }
    public int? AllocatedBillability { get; set; }
    public int? AllocatedUtilization { get; set; }

    public DateTime? ProjectOnBoardingDate { get; set; }
    public DateTime? ProjectOffBoardingDate { get; set; }

}
