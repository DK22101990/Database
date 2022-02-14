using System;
using System.Collections.Generic;

#nullable disable

namespace CFS.Data.Models
{
    public partial class StageDatum
    {
        public int StageId { get; set; }
        public int? ProjectId { get; set; }
        public int? SowId { get; set; }
        public int? _1ProjectKickStart { get; set; }
        public int? _2Design { get; set; }
        public int? _3Agile { get; set; }
        public int? _4Closure { get; set; }
        public int? IsActive { get; set; }
        public DateTime? LastModifiedOn { get; set; }
        public int? ModifiedById { get; set; }

        public virtual Employee ModifiedBy { get; set; }
        public virtual Project Project { get; set; }
        public virtual Sow Sow { get; set; }
    }
}
