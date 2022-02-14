using System;
using System.Collections.Generic;

#nullable disable

namespace CFS.Data.Models
{
    public partial class Variance
    {
        public Variance()
        {
            SprintScores = new HashSet<SprintScore>();
        }

        public int VarianceId { get; set; }
        public string Description { get; set; }
        public int? IsActive { get; set; }
        public DateTime? LastModifiedOn { get; set; }
        public int? ModifiedById { get; set; }

        public virtual Employee ModifiedBy { get; set; }
        public virtual ICollection<SprintScore> SprintScores { get; set; }
    }
}
