using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
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
        public string ProjectType { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public int? AccountId { get; set; }
        public string AccountName { get; set; }
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
        public int? ProjectId { get; set; }
        public string ProjectName { get; set; }
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
}
