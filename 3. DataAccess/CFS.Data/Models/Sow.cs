using CFS.Data.Domains;
using System;
using System.Collections.Generic;

#nullable disable

namespace CFS.Data.Models
{
    public partial class Sow
    {
        public Sow()
        {
            AgileData = new HashSet<AgileDatum>();
            ComplianceProjects = new HashSet<ComplianceProject>();
            EmployeeProjectAllocations = new HashSet<EmployeeProjectAllocation>();
            ProjectManagerMaps = new HashSet<ProjectManagerMap>();
            SowkickstartQuestionResponses = new HashSet<SowkickstartQuestionResponse>();
            SprintQuestionResponses = new HashSet<SprintQuestionResponse>();
            Sprints = new HashSet<Sprint>();
            StageData = new HashSet<StageDatum>();
        }

        public int SowId { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public string SowName { get; set; }
        public string EngagementWeeks { get; set; }
        public string SowAmount { get; set; }
        public int? OpportunityId { get; set; }
        public int? CurrencyId { get; set; }
        public int? ProjectId { get; set; }
        public int IsActive { get; set; }
        public DateTime? LastModifiedOn { get; set; }
        public int? ModifiedById { get; set; }
        public int ContractTypeId { get; set; }
        public string SowPath { get; set; }

       // public int AccountId {get; set;}

         public string ProjectDuration { get; set; }
        


        public virtual Currency Currency { get; set; }
        public virtual Employee ModifiedBy { get; set; }

        public virtual Opportunity Opportunity { get; set; }
        public virtual Project Project { get; set; }
        public virtual ICollection<AgileDatum> AgileData { get; set; }
        public virtual ICollection<ComplianceProject> ComplianceProjects { get; set; }
        public virtual ICollection<EmployeeProjectAllocation> EmployeeProjectAllocations { get; set; }
        public virtual ICollection<ProjectManagerMap> ProjectManagerMaps { get; set; }
        public virtual ICollection<ContractType> ContractTypes { get; set; }
        public virtual ICollection<SowkickstartQuestionResponse> SowkickstartQuestionResponses { get; set; }
        public virtual ICollection<SprintQuestionResponse> SprintQuestionResponses { get; set; }
        public virtual ICollection<Sprint> Sprints { get; set; }
        public virtual ICollection<StageDatum> StageData { get; set; }
    }
}
