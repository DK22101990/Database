using System;
using System.Collections.Generic;

#nullable disable

namespace CFS.Data.Models
{
    public partial class Employee
    {
        public Employee()
        {
            AccountModifiedBies = new HashSet<Account>();
            AccountRelationshipManagers = new HashSet<Account>();
            AgileData = new HashSet<AgileDatum>();
            Artefacts = new HashSet<Artefact>();
            CommentTypes = new HashSet<CommentType>();
            ComplianceProjects = new HashSet<ComplianceProject>();
            ComplianceStatuses = new HashSet<ComplianceStatus>();
            ComplianceTypes = new HashSet<ComplianceType>();
            Currencies = new HashSet<Currency>();
            Departments = new HashSet<Department>();
            EmployeeProjectAllocationEmployees = new HashSet<EmployeeProjectAllocation>();
            EmployeeProjectAllocationModifiedBies = new HashSet<EmployeeProjectAllocation>();
            EmployeeRoleAssignmentEmployees = new HashSet<EmployeeRoleAssignment>();
            EmployeeRoleAssignmentModifiedBies = new HashSet<EmployeeRoleAssignment>();
            EmployeeSkillAssignmentEmployees = new HashSet<EmployeeSkillAssignment>();
            EmployeeSkillAssignmentModifiedBies = new HashSet<EmployeeSkillAssignment>();
            InverseModifiedBy = new HashSet<Employee>();
            Opportunities = new HashSet<Opportunity>();
            ProjectManagerMapAccountManagers = new HashSet<ProjectManagerMap>();
            ProjectManagerMapManagers = new HashSet<ProjectManagerMap>();
            ProjectManagerMapModifiedBies = new HashSet<ProjectManagerMap>();
            Projects = new HashSet<Project>();
            ContractTypes = new HashSet<ContractType>();
            QuestionCategoryMaps = new HashSet<QuestionCategoryMap>();
            Questions = new HashSet<Question>();
            RoleComplianceTypes = new HashSet<RoleComplianceType>();
            Roles = new HashSet<Role>();
            SkillTypes = new HashSet<SkillType>();
            Skills = new HashSet<Skill>();
            SowkickstartQuestionResponses = new HashSet<SowkickstartQuestionResponse>();
            Sows = new HashSet<Sow>();
            SprintDetails = new HashSet<SprintDetail>();
            SprintQuestionResponses = new HashSet<SprintQuestionResponse>();
            SprintScores = new HashSet<SprintScore>();
            Sprints = new HashSet<Sprint>();
            StageComplianceTypes = new HashSet<StageComplianceType>();
            StageData = new HashSet<StageDatum>();
            Stages = new HashSet<Stage>();
            Variances = new HashSet<Variance>();
        }

        public int EmployeeId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string PhoneNumber { get; set; }
        public DateTime? DateOfJoining { get; set; }
        public int? DepartmentId { get; set; }
        public int? IsActive { get; set; }
        public DateTime? LastModifiedOn { get; set; }
        public int? ModifiedById { get; set; }
        public DateTime? ExitDate { get; set; }
        public string PositionHiredFor { get;set; }
        public string Tittle { get; set; }
        public int? DirectReportingManagerId { get; set; }
        public int? IndirectReportingManagerId { get; set; }


        // public int ContractTypeId { get; set; }



        public virtual Department Department { get; set; }
        public virtual Employee ModifiedBy { get; set; }
        public virtual ICollection<Account> AccountModifiedBies { get; set; }
        public virtual ICollection<Account> AccountRelationshipManagers { get; set; }
        public virtual ICollection<AgileDatum> AgileData { get; set; }
        public virtual ICollection<Artefact> Artefacts { get; set; }
        public virtual ICollection<CommentType> CommentTypes { get; set; }
        public virtual ICollection<ComplianceProject> ComplianceProjects { get; set; }
        public virtual ICollection<ComplianceStatus> ComplianceStatuses { get; set; }
        public virtual ICollection<ComplianceType> ComplianceTypes { get; set; }

        public virtual ICollection<ContractType> ContractTypes { get; set; }    
        public virtual ICollection<Currency> Currencies { get; set; }
        public virtual ICollection<Department> Departments { get; set; }
        public virtual ICollection<EmployeeProjectAllocation> EmployeeProjectAllocationEmployees { get; set; }
        public virtual ICollection<EmployeeProjectAllocation> EmployeeProjectAllocationModifiedBies { get; set; }
        public virtual ICollection<EmployeeRoleAssignment> EmployeeRoleAssignmentEmployees { get; set; }
        public virtual ICollection<EmployeeRoleAssignment> EmployeeRoleAssignmentModifiedBies { get; set; }
        public virtual ICollection<EmployeeSkillAssignment> EmployeeSkillAssignmentEmployees { get; set; }
        public virtual ICollection<EmployeeSkillAssignment> EmployeeSkillAssignmentModifiedBies { get; set; }
        public virtual ICollection<Employee> InverseModifiedBy { get; set; }
        public virtual ICollection<Opportunity> Opportunities { get; set; }
        public virtual ICollection<ProjectManagerMap> ProjectManagerMapAccountManagers { get; set; }
        public virtual ICollection<ProjectManagerMap> ProjectManagerMapManagers { get; set; }
        public virtual ICollection<ProjectManagerMap> ProjectManagerMapModifiedBies { get; set; }
        public virtual ICollection<Project> Projects { get; set; }
        public virtual ICollection<ProjectDomain> ProjectDomains { get; set; }
        public virtual ICollection<QuestionCategoryMap> QuestionCategoryMaps { get; set; }
        public virtual ICollection<Question> Questions { get; set; }
        public virtual ICollection<RoleComplianceType> RoleComplianceTypes { get; set; }
        public virtual ICollection<Role> Roles { get; set; }
        public virtual ICollection<SkillType> SkillTypes { get; set; }
        public virtual ICollection<Skill> Skills { get; set; }
        public virtual ICollection<SowkickstartQuestionResponse> SowkickstartQuestionResponses { get; set; }
        public virtual ICollection<Sow> Sows { get; set; }
        public virtual ICollection<SprintDetail> SprintDetails { get; set; }
        public virtual ICollection<SprintQuestionResponse> SprintQuestionResponses { get; set; }
        public virtual ICollection<SprintScore> SprintScores { get; set; }
        public virtual ICollection<Sprint> Sprints { get; set; }
        public virtual ICollection<StageComplianceType> StageComplianceTypes { get; set; }
        public virtual ICollection<StageDatum> StageData { get; set; }
        public virtual ICollection<Stage> Stages { get; set; }
        public virtual ICollection<Variance> Variances { get; set; }
    }
}
