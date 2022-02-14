using System;
using System.Collections.Generic;

#nullable disable

namespace CFS.Data.Models
{
    public partial class Artefact
    {
        public Artefact()
        {
            SowkickstartQuestionResponses = new HashSet<SowkickstartQuestionResponse>();
            SprintQuestionResponses = new HashSet<SprintQuestionResponse>();
        }

        public int ArtefactId { get; set; }
        public string FileName { get; set; }
        public int? IsActive { get; set; }
        public DateTime? LastModifiedOn { get; set; }
        public int? ModifiedById { get; set; }
        public int? QuestionId { get; set; }
        public string FilePath { get; set; }
        public string FileSize { get; set; }
        public string DisplayName { get; set; }

        public virtual Employee ModifiedBy { get; set; }
        public virtual Question Question { get; set; }
        public virtual ICollection<SowkickstartQuestionResponse> SowkickstartQuestionResponses { get; set; }
        public virtual ICollection<SprintQuestionResponse> SprintQuestionResponses { get; set; }
    }
}
