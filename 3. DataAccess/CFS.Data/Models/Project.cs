using System;
using System.Collections.Generic;

#nullable disable

namespace CFS.Data.Models
{
    public partial class Project
    {
        public Project()
        {
            AgileData = new HashSet<AgileDatum>();
            ComplianceProjects = new HashSet<ComplianceProject>();
            EmployeeProjectAllocations = new HashSet<EmployeeProjectAllocation>();
            ProjectManagerMaps = new HashSet<ProjectManagerMap>();
            SowkickstartQuestionResponses = new HashSet<SowkickstartQuestionResponse>();
            Sows = new HashSet<Sow>();
            SprintQuestionResponses = new HashSet<SprintQuestionResponse>();
            SprintScores = new HashSet<SprintScore>();
            Sprints = new HashSet<Sprint>();
            StageData = new HashSet<StageDatum>();
        }

        public int ProjectId { get; set; }
        public string ProjectName { get; set; }
        public string ProjectDescription { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public string ProjectType { get; set; }
        public int? AccountId { get; set; }
        public int? IsActive { get; set; }
        public DateTime? LastModifiedOn { get; set; }
        public int? ModifiedById { get; set; }

        public virtual Account Account { get; set; }
        public virtual Employee ModifiedBy { get; set; }
        public virtual ICollection<AgileDatum> AgileData { get; set; }
        public virtual ICollection<ComplianceProject> ComplianceProjects { get; set; }
        public virtual ICollection<EmployeeProjectAllocation> EmployeeProjectAllocations { get; set; }
        public virtual ICollection<ProjectManagerMap> ProjectManagerMaps { get; set; }
        public virtual ICollection<SowkickstartQuestionResponse> SowkickstartQuestionResponses { get; set; }
        public virtual ICollection<Sow> Sows { get; set; }
        public virtual ICollection<SprintQuestionResponse> SprintQuestionResponses { get; set; }
        public virtual ICollection<SprintScore> SprintScores { get; set; }
        public virtual ICollection<Sprint> Sprints { get; set; }
        public virtual ICollection<StageDatum> StageData { get; set; }
    }
}
