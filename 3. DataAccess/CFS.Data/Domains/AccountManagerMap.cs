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
}
