using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace CFS.Model.Models
{
    public class AccountListViewModel
    {
        public int AccountId { get; set; }
        public string AccountName { get; set; }

        public int ModifiedById { get; set; }

        public int? IsActive { get; set; }

        public int? EmployeeSize { get; set; }

        public string CeoName { get; set; }


        public int? YearlyRevenue { get; set; }


    }
    public class SprintViewModel
    {
        public int SprintId { get; set; }
        public int? SowId { get; set; }
        public string Sprints { get; set; }
        public string SowName { get; set; }
    }

    public class ComplianceTypeViewModel
    {
        public int? StageId { get; set; }
        public string StageName { get; set; }
        public int ComplianceTypeId { get; set; }
        public string ComplianceTypeName { get; set; }
    }

    public class SelectListViewModel
    {
        public int Value { get; set; }
        public string Label { get; set; }
    }

    public class AgileQuestionViewModel
    {
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
        public DateTime? LastModifiedOn { get; set; }
        public int? ModifiedByID { get; set; }
        public string FileName { get; set; }
        public string FilePath { get; set; }
        public string FileSize { get; set; }
        public string DisplayName { get; set; }
    }

    public class ProjectKickStartQuestionViewModel
    {
        public string Questions { get; set; }
        public string StageName { get; set; }
        public string ComplianceTypeName { get; set; }
        public int SOWKickstartQuestionResponseId { get; set; }
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
        public DateTime? LastModifiedOn { get; set; }
        public int? ModifiedByID { get; set; }
        public string FileName { get; set; }
        public string FilePath { get; set; }
        public string FileSize { get; set; }
        public string DisplayName { get; set; }
    }
    #region QuestionList
    public class QuestionListViewModel
    {

        public int QuestionId { get; set; }
        public string Questions { get; set; }
        public int? ComplianceTypeId { get; set; }
        public string ComplianceTypeName { get; set; }
        public int? StageId { get; set; }
        public string StageName { get; set; }
    }
    #endregion

    #region KickStart

    public class InsertQuestion
    {
        public int AccountId { get; set; }
        public int ProjectId { get; set; }
        public int SowId { get; set; }
        public int StageId { get; set; }
        public int ComplianceTypeId { get; set; }
        public int QuestionId { get; set; }
        public int SprintId { get; set; }
        public int ComplianceStatusId { get; set; }
        public string Comments { get; set; }
        public int CommentsTypeId { get; set; }
        public int ArtefactId { get; set; }
        public int Isactive { get; set; }
    }

    #endregion

    #region Project
    public class ProjectViewModel
    {
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
        public int? ModifiedById { get; set; }

        public string ClientContactPerson { get; set; }
        public string ClientEmailId { get; set; }
        public string ClientContactNumber { get; set; }
        public int ProjectManagerId { get; set; }
        public int ProjectAccountManagerId { get; set; }
        public int SowId { get; set; }
        public int IsActive { get; set; }
        public DateTime? LastModifiedOn { get; set; }
    }
    #endregion



    #region ProjectDomain

    public class ProjectDomainViewModel
    {
        public int ProjectDomainId { get; set; }
        public string Projectdomain { get; set; }
        public int IsActive { get; set; }
        public DateTime LastModifiedOn { get; set; }

        public int ModifiedById { get; set; }
    }
    #endregion
    #region
    public class UpdateProjectResponseModel
    {
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
    public class InsertProjectResponseModel
    {
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

    #endregion


    #region Stage
    public class StageViewModel
    {
        public int StageId { get; set; }
        public string StageName { get; set; }
    }
    #endregion


    public class ArtefactDownload
    {
        public string DisplayName { get; set; }
        public string FilePath { get; set; }
        public string File { get; set; }
        public ReturnResponseModel returnResponseModel { get; set; }
    }

    #region FileUpload
    public class SaveSowQuestionResponse
    {
        public int AccountId { get; set; }
        public int ProjectId { get; set; }
        public int SowId { get; set; }
        public int StageId { get; set; }
        public int ComplianceTypeId { get; set; }
        public int QuestionId { get; set; }
        public int ComplianceStatusId { get; set; }
        public string Comments { get; set; }
        public int CommentsTypeId { get; set; }
        public string File { get; set; }
        public string FileName { get; set; }
        public string FilePath { get; set; }
        public string FileSize { get; set; }
        public string DisplayName { get; set; }
        public bool IsUploaded { get; set; }
        public int? ArtefactId { get; set; }
    }
    public class ArtifactViewModel
    {
        public int ArtefactId { get; set; }
        public string FileName { get; set; }
        public int IsActive { get; set; }
        public DateTime LastModifiedOn { get; set; }
        public int ModifiedById { get; set; }
        public int QuestionId { get; set; }
        public string FilePath { get; set; }
        public string FileSize { get; set; }
        public string DisplayName { get; set; }
    }
    #endregion

    #region SaveAgileQuestionResponse
    public class SaveAgileQuestionResponse
    {
        public int AccountId { get; set; }
        public int ProjectId { get; set; }
        public int SowId { get; set; }
        public int StageId { get; set; }
        public int ComplianceTypeId { get; set; }
        public int SprintId { get; set; }
        public int QuestionId { get; set; }
        public int ComplianceStatusId { get; set; }
        public string Comments { get; set; }
        public int CommentsTypeId { get; set; }
        public string File { get; set; }
        public string FileName { get; set; }
        public string FilePath { get; set; }
        public string FileSize { get; set; }
        public string DisplayName { get; set; }
        public bool IsUploaded { get; set; }
        public int? ArtefactId { get; set; }
    }
    #endregion

    #region Sprint Planning
    public class SprintModel
    {
        public int? SprintId { get; set; }
        public int? ProjectId { get; set; }
        public string ProjectName { get; set; }
        public int? SowId { get; set; }
        public string SowName { get; set; }
        public int? AccountId { get; set; }
        public string AccountName { get; set; }
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

    #endregion

    #region SOWResponse
    public class InsertUpdateSowResponseModel
    {
        public int? AccountId { get; set; }
        public int? ProjectId { get; set; }
        public int? SowId { get; set; }
        public DateTime? SowStartDate { get; set; }
        public DateTime? SowEndDate { get; set; }
        public string SowName { get; set; }
        public string EngagementWeeks { get; set; }
        public string SowValue { get; set; }
        public int? OpportunityId { get; set; }
        public int? CurrencyId { get; set; }
        public int? ContractTypeId { get; set; }
        public string SowPath { get; set; }
        public string ProjectDuration { get; set; }
        public int IsActive { get; set; }
    }

    public class SOWViewModel
    {
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

    public class SowDataViewModel
    {
        public int SowId { get; set; }
        public DateTime? SOWStartDate { get; set; }
        public DateTime? SOWEndDate { get; set; }
        public string SOWValue { get; set; }
        public int? ContractTypeId { get; set; }
        public string ContractType { get; set; }
        public int? ProjectTypeId { get; set; }
        public string ProjectType { get; set;}
        public string SowPath { get; set; }
        public string ProjectDuration { get; set; }
        public int IsActive { get; set; }
        public string ClientContactPerson { get; set; }
        public string ClientEmailId { get; set; }
    }
    public class AccountResponseViewModel
    {
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
    public class InsertAccountResponseModel
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
    public class UpdateAccountResponseModel
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
        public int IsActive { get; set; }

    }
    #endregion
}
