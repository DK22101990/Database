using System;
using System.Collections.Generic;

#nullable disable

namespace CFS.Data.Models
{
    public partial class ComplianceType
    {
        public ComplianceType()
        {
            ComplianceProjects = new HashSet<ComplianceProject>();
            QuestionCategoryMaps = new HashSet<QuestionCategoryMap>();
            QuestionsCompliances = new HashSet<QuestionsCompliance>();
            RoleComplianceTypes = new HashSet<RoleComplianceType>();
            SowkickstartQuestionResponses = new HashSet<SowkickstartQuestionResponse>();
            SprintQuestionResponses = new HashSet<SprintQuestionResponse>();
            StageComplianceTypes = new HashSet<StageComplianceType>();
        }

        public int ComplianceTypeId { get; set; }
        public string ComplianceTypeName { get; set; }
        public string TypeDescription { get; set; }
        public int? IsActive { get; set; }
        public DateTime? LastModifiedOn { get; set; }
        public int? ModifiedById { get; set; }

        public virtual Employee ModifiedBy { get; set; }
        public virtual ICollection<ComplianceProject> ComplianceProjects { get; set; }
        public virtual ICollection<QuestionCategoryMap> QuestionCategoryMaps { get; set; }
        public virtual ICollection<QuestionsCompliance> QuestionsCompliances { get; set; }
        public virtual ICollection<RoleComplianceType> RoleComplianceTypes { get; set; }
        public virtual ICollection<SowkickstartQuestionResponse> SowkickstartQuestionResponses { get; set; }
        public virtual ICollection<SprintQuestionResponse> SprintQuestionResponses { get; set; }
        public virtual ICollection<StageComplianceType> StageComplianceTypes { get; set; }
    }
}
