using System;
using System.Collections.Generic;

#nullable disable

namespace CFS.Data.Models
{
    public partial class Sprint
    {
        public Sprint()
        {
            SprintDetails = new HashSet<SprintDetail>();
            SprintQuestionResponses = new HashSet<SprintQuestionResponse>();
            SprintScores = new HashSet<SprintScore>();
        }

        public int SprintId { get; set; }
        public string SprintName { get; set; }
        public int? ProjectId { get; set; }
        public int? SowId { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public int? IsActive { get; set; }
        public DateTime? LastModifiedOn { get; set; }
        public int? ModifiedById { get; set; }

        public virtual Employee ModifiedBy { get; set; }
        public virtual Project Project { get; set; }
        public virtual Sow Sow { get; set; }
        public virtual ICollection<SprintDetail> SprintDetails { get; set; }
        public virtual ICollection<SprintQuestionResponse> SprintQuestionResponses { get; set; }
        public virtual ICollection<SprintScore> SprintScores { get; set; }
    }
}
