using System;
using System.Collections.Generic;

#nullable disable

namespace CFS.Data.Models
{
    public partial class Stage
    {
        public Stage()
        {
            ComplianceProjects = new HashSet<ComplianceProject>();
            SowkickstartQuestionResponses = new HashSet<SowkickstartQuestionResponse>();
            SprintQuestionResponses = new HashSet<SprintQuestionResponse>();
            StageComplianceTypes = new HashSet<StageComplianceType>();
        }

        public int StageId { get; set; }
        public string StageName { get; set; }
        public string Description { get; set; }
        public int? IsActive { get; set; }
        public DateTime? LastModifiedOn { get; set; }
        public int? ModifiedById { get; set; }

        public virtual Employee ModifiedBy { get; set; }
        public virtual ICollection<ComplianceProject> ComplianceProjects { get; set; }
        public virtual ICollection<SowkickstartQuestionResponse> SowkickstartQuestionResponses { get; set; }
        public virtual ICollection<SprintQuestionResponse> SprintQuestionResponses { get; set; }
        public virtual ICollection<StageComplianceType> StageComplianceTypes { get; set; }
    }
}
