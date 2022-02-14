using System;
using System.Collections.Generic;

#nullable disable

namespace CFS.Data.Models
{
    public partial class StageComplianceType
    {
        public int StageComplianceTypeId { get; set; }
        public int? ComplianceTypeId { get; set; }
        public int? StageId { get; set; }
        public int? IsActive { get; set; }
        public DateTime? LastModifiedOn { get; set; }
        public int? ModifiedById { get; set; }

        public virtual ComplianceType ComplianceType { get; set; }
        public virtual Employee ModifiedBy { get; set; }
        public virtual Stage Stage { get; set; }
    }
}
