using System;
using System.Collections.Generic;

#nullable disable

namespace CFS.Data.Models
{
    public partial class SprintDetail
    {
        public int SprintDetailId { get; set; }
        public int? SprintId { get; set; }
        public int? UsPlannedAtStart { get; set; }
        public int? UsPlannedAtCompletion { get; set; }
        public int? TaskPlannedAtStart { get; set; }
        public int? TaskPlannedAtCompletion { get; set; }
        public int? TotalEstimationSizeAtStart { get; set; }
        public int? TotalEstimationSizeAtCompletion { get; set; }
        public int? UsCompleted { get; set; }
        public int? IsActive { get; set; }
        public DateTime? LastModifiedOn { get; set; }
        public int? ModifiedById { get; set; }

        public virtual Employee ModifiedBy { get; set; }
        public virtual Sprint Sprint { get; set; }
    }
}
