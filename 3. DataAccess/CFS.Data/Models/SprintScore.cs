using System;
using System.Collections.Generic;

#nullable disable

namespace CFS.Data.Models
{
    public partial class SprintScore
    {
        public int SprintScoreId { get; set; }
        public int? SprintId { get; set; }
        public int? VarianceId { get; set; }
        public int? ProjectId { get; set; }
        public int? Score { get; set; }
        public int? IsActive { get; set; }
        public DateTime? LastModifiedOn { get; set; }
        public int? ModifiedById { get; set; }

        public virtual Employee ModifiedBy { get; set; }
        public virtual Project Project { get; set; }
        public virtual Sprint Sprint { get; set; }
        public virtual Variance Variance { get; set; }
    }
}
