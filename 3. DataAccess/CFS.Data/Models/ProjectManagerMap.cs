using System;
using System.Collections.Generic;

#nullable disable

namespace CFS.Data.Models
{
    public partial class ProjectManagerMap
    {
        public int ProjectManagerId { get; set; }
        public int? SowId { get; set; }
        public int? ManagerId { get; set; }
        public int? AccountManagerId { get; set; }
        public int? ProjectId { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public int? IsActive { get; set; }
        public DateTime? LastModifiedDate { get; set; }
        public int? ModifiedById { get; set; }

        public virtual Employee AccountManager { get; set; }
        public virtual Employee Manager { get; set; }
        public virtual Employee ModifiedBy { get; set; }
        public virtual Project Project { get; set; }
        public virtual Sow Sow { get; set; }
    }
}
