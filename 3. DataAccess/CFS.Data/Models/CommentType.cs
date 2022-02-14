using System;
using System.Collections.Generic;

#nullable disable

namespace CFS.Data.Models
{
    public partial class CommentType
    {
        public CommentType()
        {
            SowkickstartQuestionResponses = new HashSet<SowkickstartQuestionResponse>();
            SprintQuestionResponses = new HashSet<SprintQuestionResponse>();
        }

        public int CommentTypeId { get; set; }
        public string CommentType1 { get; set; }
        public int? IsActive { get; set; }
        public DateTime? LastModifiedOn { get; set; }
        public int? ModifiedById { get; set; }

        public virtual Employee ModifiedBy { get; set; }
        public virtual ICollection<SowkickstartQuestionResponse> SowkickstartQuestionResponses { get; set; }
        public virtual ICollection<SprintQuestionResponse> SprintQuestionResponses { get; set; }
    }
}
