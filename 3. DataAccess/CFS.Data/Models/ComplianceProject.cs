using System;
using System.Collections.Generic;

#nullable disable

namespace CFS.Data.Models
{
    public partial class ComplianceProject
    {
        public int ComplianceProjectId { get; set; }
        public int? SowId { get; set; }
        public int? ProjectId { get; set; }
        public int? StageId { get; set; }
        public int? ComplianceTypeId { get; set; }
        public int? IsComplete { get; set; }
        public int? IsActive { get; set; }
        public DateTime? LastModifiedOn { get; set; }
        public int? ModifiedById { get; set; }

        public virtual ComplianceType ComplianceType { get; set; }
        public virtual Employee ModifiedBy { get; set; }
        public virtual Project Project { get; set; }
        public virtual Sow Sow { get; set; }
        public virtual Stage Stage { get; set; }
    }
}
