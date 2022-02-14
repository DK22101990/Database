using System;
using System.Collections.Generic;

#nullable disable

namespace CFS.Data.Models
{
    public partial class Question
    {
        public Question()
        {
            Artefacts = new HashSet<Artefact>();
            QuestionCategoryMaps = new HashSet<QuestionCategoryMap>();
            QuestionsCompliances = new HashSet<QuestionsCompliance>();
            SowkickstartQuestionResponses = new HashSet<SowkickstartQuestionResponse>();
            SprintQuestionResponses = new HashSet<SprintQuestionResponse>();
        }

        public int QuestionId { get; set; }
        public string Questions { get; set; }
        public string QuestionWeightage { get; set; }
        public int? IsActive { get; set; }
        public DateTime? LastModifiedOn { get; set; }
        public int? ModifiedById { get; set; }

        public virtual Employee ModifiedBy { get; set; }
        public virtual ICollection<Artefact> Artefacts { get; set; }
        public virtual ICollection<QuestionCategoryMap> QuestionCategoryMaps { get; set; }
        public virtual ICollection<QuestionsCompliance> QuestionsCompliances { get; set; }
        public virtual ICollection<SowkickstartQuestionResponse> SowkickstartQuestionResponses { get; set; }
        public virtual ICollection<SprintQuestionResponse> SprintQuestionResponses { get; set; }
    }
}
