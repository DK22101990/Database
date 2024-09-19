using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CFS.Data.Domains
{
    public class AccountList
    {
        [Key]
        public int AccountId { get; set; }
        public string AccountName { get; set; }
        public int? IsActive { get; set; }

        public int? EmployeeSize { get; set; }

        public string CeoName { get; set; }

        public int? YearlyRevenue { get; set; }



    }
    public class SprintList
    {
        [Key]
        public int SprintId { get; set; }
        public int? SowId { get; set; }
        public string Sprints { get; set; }
        public string SowName { get; set; }
    }
    public class ComplianceType
    {
        [Key]
        public int ComplianceTypeId { get; set; }
        public int? StageId { get; set; }
        public string StageName { get; set; }
        public string ComplianceTypeName { get; set; }
    }

    public class SelectList
    {
        [Key]
        public int Value { get; set; }
        public string Label { get; set; }
    }

    public class AgileQuestion
    {
        [Key]
        public int SprintQuestionResponseId { get; set; }
        public string Questions { get; set; }
        public string StageName { get; set; }
        public string ComplianceTypeName { get; set; }
        public int? AccountId { get; set; }
        public int? ProjectId { get; set; }
        public int? SowId { get; set; }
        public int? StageId { get; set; }
        public int? ComplianceTypeID { get; set; }
        public int? SprintID { get; set; }
        public int? QuestionId { get; set; }
        public int? ComplianceStatusId { get; set; }
        public string Comments { get; set; }
        public int? CommentsTypeId { get; set; }
        public int? ArtefactId { get; set; }
        public int? IsActive { get; set; }
        public string FileName { get; set; }
        public string FilePath { get; set; }
        public string FileSize { get; set; }
        public string DisplayName { get; set; }
        public DateTime? LastModifiedOn { get; set; }
        public int? ModifiedByID { get; set; }

    }

    public class ProjectKickStartQuestions
    {
        [Key]
        public int SOWKickstartQuestionResponseId { get; set; }
        public string Questions { get; set; }
        public string StageName { get; set; }
        public string ComplianceTypeName { get; set; }
        public int? AccountId { get; set; }
        public int? ProjectId { get; set; }
        public int? SowId { get; set; }
        public int? StageId { get; set; }
        public int? ComplianceTypeID { get; set; }
        public int? QuestionId { get; set; }
        public int? ComplianceStatusId { get; set; }
        public string Comments { get; set; }
        public int? CommentsTypeId { get; set; }
        public int? ArtefactId { get; set; }
        public int? IsActive { get; set; }
        public string FileName { get; set; }
        public string FilePath { get; set; }
        public string FileSize { get; set; }
        public string DisplayName { get; set; }
        public DateTime? LastModifiedOn { get; set; }
        public int? ModifiedByID { get; set; }
    }

    public class Projects
    {
        [Key]
        public int ProjectId { get; set; }
        public string ProjectName { get; set; }
        public string ProjectDescription { get; set; }
        public int ProjectTypeId { get; set; }
        public string ProjectType { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public int? AccountId { get; set; }

        public string ManagerName { get; set; }
      //  public string AccountName { get; set; }
        public int? ManagerId { get; set; }
        public int IsActive { get; set; }
        public string ContactPersonName { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }

        public int ProjectDomainId { get; set; }
        public string ProjectDomain { get; set; }
        public DateTime? LastModifiedOn { get; set; }

        public int? ModifiedById { get; set; }

    }
    public class ProjectDomainList
    {
        public int ProjectDomainId { get; set; }
        public string Projectdomain { get; set; }
        public int IsActive { get; set; }
        public DateTime LastModifiedOn { get; set; }

        public int ModifiedById { get; set; }
    }
    public class InsertProjectResponse
    {
        [Key]
        public int ProjectId { get; set; }
        public string ProjectName { get; set; }
        public string ProjectDescription { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public int AccountId { get; set; }
        public string ClientContactPerson { get; set; }
        public string ClientEmailId { get; set; }
        public string ClientContactNumber { get; set; }
        public int ProjectTypeId { get; set; }
        public int ProjectDomainId { get; set; }
        public int ProjectManagerId { get; set; }
        public int? ProjectAccountManagerId { get; set; }
        public int SowId { get; set; }
        public int IsActive { get; set; }
        public DateTime? LastModifiedOn { get; set; }
        public int? ModifiedById { get; set; }

    }

    public class UpdateProjectResponse
    {
        [Key]
        public int AccountId { get; set; }
        public string ProjectName { get; set; }
        public string ProjectDescription { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public string ClientContactPerson { get; set; }
        public string ClientEmailId { get; set; }
        public string ClientContactNumber { get; set; }
        public int ProjectTypeId { get; set; }
        public int ProjectDomainId { get; set; }
        public int ProjectManagerId { get; set; }
        public int ProjectAccountManagerId { get; set; }

        public int IsActive { get; set; }
        public DateTime? LastModifiedOn { get; set; }
        public int? ModifiedById { get; set; }

        public int ProjectId { get; set; }

        public int SowId { get; set; }

    }

    public class ProjectResponse
    {
        [Key]
        public int ProjectId { get; set; }
        public string ProjectName { get; set; }
        public string ProjectDescription { get; set; }
        public int ProjectTypeId { get; set; }
        public string ProjectType { get; set; }
        public string ContactPersonName { get; set; }
        public int ProjectDomainId { get; set; }
        public string ProjectDomain { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public int? AccountId { get; set; }
        public int? ManagerId { get; set; }
        public string ManagerName { get; set; }
        public int IsActive { get; set; }
        public DateTime? LastModifiedOn { get; set; }
        public int? ModifiedById { get; set; }
    }

    public class SOW
    {
        [Key]
        public int SowId { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public string SowName { get; set; }
        public string EngagementWeeks { get; set; }
        public string SowAmount { get; set; }
        public int ProjectId { get; set; }
        public string ProjectName { get; set; }

        public int ContractTypeId { get; set; }
        public string SowPath { get; set; }
        public string ProjectDuration { get; set; }
        // public int AccountId { get; set; }

    }
    public class Stage
    {
        [Key]
        public int StageId { get; set; }
        public string StageName { get; set; }

    }
    public class QuestionList
    {
        [Key]
        public int QuestionId { get; set; }
        public string Questions { get; set; }
        public int? ComplianceTypeId { get; set; }
        public string ComplianceTypeName { get; set; }
        public int? StageId { get; set; }
        public string StageName { get; set; }
    }

    public class ArtefactList
    {
        [Key]
        public int ArtefactId { get; set; }
        public string FileName { get; set; }
        public int IsActive { get; set; }
        public DateTime? LastModifiedOn { get; set; }
        public int? ModifiedByID { get; set; }
        public int? QuestionId { get; set; }
        public string FilePath { get; set; }
        public string FileSize { get; set; }
        public string DisplayName { get; set; }
    }

    public class SprintDetailList
    {
        [Key]
        public int? SprintId { get; set; }
        public string SprintName { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public int? ProjectId { get; set; }
        public string ProjectName { get; set; }
        public int? SowId { get; set; }
        public string SowName { get; set; }
        public int? AccountId { get; set; }
        public string AccountName { get; set; }
        public int? US_PlannedAtStart { get; set; }
        public int? US_PlannedAtCompletion { get; set; }
        public int? TaskPlannedAtStart { get; set; }
        public int? TaskPlannedAtCompletion { get; set; }
        public int? TotalEstimationSizeAtStart { get; set; }
        public int? TotalEstimationSizeAtCompletion { get; set; }
        public int IsActive { get; set; }
        public DateTime? LastModifiedOn { get; set; }
        public int? ModifiedById { get; set; }
    }

    public class SprintInformation
    {
        [Key]
        public int? SprintId { get; set; }
        public string SprintName { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public int? US_PlannedAtStart { get; set; }
        public int? US_PlannedAtCompletion { get; set; }
        public int? TaskPlannedAtStart { get; set; }
        public int? TaskPlannedAtCompletion { get; set; }
        public int? TotalEstimationSizeAtStart { get; set; }
        public int? TotalEstimationSizeAtCompletion { get; set; }
        public int IsActive { get; set; }
        public DateTime? LastModifiedOn { get; set; }
        public int? ModifiedById { get; set; }
    }

    public class SowResponse
    {
        [Key]
        public int SowId { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public string SowName { get; set; }
        public string SowAmount { get; set; }
        public int? OpportunityId { get; set; }
        public int? CurrencyId { get; set; }
        public int? ContractTypeId { get; set; }
        public string SowPath { get; set; }
        public string ProjectDuration { get; set; }
        public string EngagementWeeks { get; set; }
        public int ProjectId { get; set; }
        public int AccountId { get; set; }
        public int IsActive { get; set; }
        public DateTime? LastModifiedOn { get; set; }
        public int? ModifiedById { get; set; }
    }

    public class SowDataResponse
    {
        [Key]
        public int SowId { get; set; }
        public DateTime? SOWStartDate { get; set; }
        public DateTime? SOWEndDate { get; set; }
        public string SOWValue { get; set; }
        public int? ContractTypeId { get; set; }
        public string ContractType { get; set; }
        public int? ProjectTypeId { get; set; }
        public string ProjectType { get; set; }
        public string SowPath { get; set; }
        public string ProjectDuration { get; set; }
        public int IsActive { get; set; }
        public string ClientContactPerson { get; set; }
        public string ClientEmailId { get; set; }
    }
    public class AccountResponseList
    {
        [Key]
        public int AccountId { get; set; }
        public string AccountName { get; set; }
        public string AccountDescription { get; set; }
        public int AccountManagerId { get; set; }
        public string AccountManager { get; set; }
        public string HeadQuater { get; set; }
        public string State { get; set; }
        public string Country { get; set; }
        public string PhoneNumber { get; set; }
        public string MSA { get; set; }
        public string Geography { get; set; }
        public int EmployeeStrength { get; set; }
        public string CeoName { get; set; }
        public int YearlyRevenue { get; set; }
        public int LeadChannelTypeId { get; set; }
        public string LeadChannel { get; set; }
        public int IsActive { get; set; }
        public DateTime LastModifiedOn { get; set; }
        public int ModifiedById { get; set; }


    }

    public class InsertAccountResponse
    {
        [Key]

        public string AccountName { get; set; }
        public string AccountDescription { get; set; }
        public int AccountManagerId { get; set; }
        public string HeadQuater { get; set; }
        public string State { get; set; }
        public string Country { get; set; }
        public string PhoneNumber { get; set; }
        public string MSA { get; set; }
        public string Geography { get; set; }
        public string CeoName { get; set; }
        public int LeadChannelTypeId { get; set; }
        public int EmployeeStrength { get; set; }
        public int YearlyRevenue { get; set; }
        public int ModifiedById { get; set; }

    }
    public class UpdateAccountResponse
    {
        [Key]
        public int AccountId { get; set; }
        public string AccountName { get; set; }
        public string AccountDescription { get; set; }
        public int AccountManagerId { get; set; }
        public string HeadQuater { get; set; }
        public string State { get; set; }
        public string Country { get; set; }
        public string PhoneNumber { get; set; }
        public string MSA { get; set; }
        public string Geography { get; set; }
        public string CeoName { get; set; }
        public int LeadChannelTypeId { get; set; }
        public int EmployeeStrength { get; set; }
        public int YearlyRevenue { get; set; }
        public int ModifiedById { get; set; }

    }
}
