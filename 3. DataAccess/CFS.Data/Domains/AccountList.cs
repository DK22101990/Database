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
        public string Domain { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Country { get; set; }
        public string PhoneNumber { get; set; }
    }
    public class SprintList
    {
        [Key]
        public int SprintId { get; set; }
        public string SprintName { get; set; }
        public string ProjectName { get; set; }
        public string SowName { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
    }
    public class ComplianceType
    {
        [Key]
        public int ComplianceTypeId { get; set; }
        public string RoleName { get; set; }
        public string Description { get; set; }
        public string ComplianceTypeName { get; set; }
        public string TypeDescription { get; set; }
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
    }
    public class Stage
    {
        [Key]
        public int StageId { get; set; }
        public string ProjectName { get; set; }
        public string StageName { get; set; }
        public string ComplianceTypeName { get; set; }        
    }

}
