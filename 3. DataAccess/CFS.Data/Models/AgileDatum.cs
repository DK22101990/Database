using System;
using System.Collections.Generic;

#nullable disable

namespace CFS.Data.Models
{
    public partial class AgileDatum
    {
        public int AgileId { get; set; }
        public int? ProjectId { get; set; }
        public int? SowId { get; set; }
        public int? BaCompliance { get; set; }
        public int? QaCompliance { get; set; }
        public int? ScrumMasterCompliance { get; set; }
        public int? LeadCompliance { get; set; }
        public int? IsActive { get; set; }
        public DateTime? LastModifiedOn { get; set; }
        public int? ModifiedById { get; set; }

        public virtual Employee ModifiedBy { get; set; }
        public virtual Project Project { get; set; }
        public virtual Sow Sow { get; set; }
    }
}
