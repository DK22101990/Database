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
    }
    #endregion
}
