using System;
using System.Collections.Generic;

#nullable disable

namespace CFS.Data.Models
{
    public partial class QuestionCategoryMap
    {
        public int QuestionCategoryMapId { get; set; }
        public int? QuestionId { get; set; }
        public int? ComplianceTypeId { get; set; }
        public int? RoleId { get; set; }
        public int? IsActive { get; set; }
        public DateTime? LastModifiedOn { get; set; }
        public int? ModifiedById { get; set; }

        public virtual ComplianceType ComplianceType { get; set; }
        public virtual Employee ModifiedBy { get; set; }
        public virtual Question Question { get; set; }
        public virtual Role Role { get; set; }
    }
}
