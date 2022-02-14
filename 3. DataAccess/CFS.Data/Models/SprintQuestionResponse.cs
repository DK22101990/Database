using System;
using System.Collections.Generic;

#nullable disable

namespace CFS.Data.Models
{
    public partial class SprintQuestionResponse
    {
        public int SprintQuestionResponseId { get; set; }
        public int? AccountId { get; set; }
        public int? ProjectId { get; set; }
        public int? SowId { get; set; }
        public int? StageId { get; set; }
        public int? ComplianceTypeId { get; set; }
        public int? SprintId { get; set; }
        public int? QuestionId { get; set; }
        public int? ComplianceStatusId { get; set; }
        public string Comments { get; set; }
        public int? CommentsTypeId { get; set; }
        public int? ArtefactId { get; set; }
        public int? IsActive { get; set; }
        public DateTime? LastModifiedOn { get; set; }
        public int? ModifiedById { get; set; }

        public virtual Account Account { get; set; }
        public virtual Artefact Artefact { get; set; }
        public virtual CommentType CommentsType { get; set; }
        public virtual ComplianceStatus ComplianceStatus { get; set; }
        public virtual ComplianceType ComplianceType { get; set; }
        public virtual Employee ModifiedBy { get; set; }
        public virtual Project Project { get; set; }
        public virtual Question Question { get; set; }
        public virtual Sow Sow { get; set; }
        public virtual Sprint Sprint { get; set; }
        public virtual Stage Stage { get; set; }
    }
}
