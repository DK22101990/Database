using System;
using System.Collections.Generic;

#nullable disable

namespace CFS.Data.Models
{
    public partial class QuestionsCompliance
    {
        public int QuestionsComplianceId { get; set; }
        public int? QuestionId { get; set; }
        public int? ComplianceTypeId { get; set; }
        public int? IsActive { get; set; }
        public DateTime? LastModifiedOn { get; set; }
        public string ModifiedBy { get; set; }

        public virtual ComplianceType ComplianceType { get; set; }
        public virtual Question Question { get; set; }
    }
}
