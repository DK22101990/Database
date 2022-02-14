using System;
using System.Collections.Generic;

#nullable disable

namespace CFS.Data.Models
{
    public partial class Opportunity
    {
        public Opportunity()
        {
            Sows = new HashSet<Sow>();
        }

        public int OpportunityId { get; set; }
        public int? IsActive { get; set; }
        public DateTime? LastModifiedOn { get; set; }
        public int? ModifiedById { get; set; }

        public virtual Employee ModifiedBy { get; set; }
        public virtual ICollection<Sow> Sows { get; set; }
    }
}
