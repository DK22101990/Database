using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CFS.Model.Models
{
    public class AccountListViewModel
    {
        public string AccountName { get; set; }
        public string Domain { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Country { get; set; }
        public string PhoneNumber { get; set; }
    }

    public class ComplianceTypeViewModel
    {
        public string RoleName { get; set; }
        public string Description { get; set; }
        public int ComplianceTypeId { get; set; }
        public string ComplianceTypeName { get; set; }
        public string TypeDescription { get; set; }
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
    }

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
        public string ProjectType { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public string AccountName { get; set; }
    }
    #endregion

    #region SOW
    public class SOWViewModel
    {
        public int SowId { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public string SowName { get; set; }
        public string EngagementWeeks { get; set; }
        public string SowAmount { get; set; }       
    }
    #endregion

    #region Stage
    public class StageViewModel
    {
        public int StageId { get; set; }
        public string ProjectName { get; set; }
        public string StageName { get; set; }
        public string ComplianceTypeName { get; set; }
    }
    #endregion

    //#region SOWKickStartQuestion
    //public class SOWKickStartQuestion
    //{
    //    public int AccountId { get; set; }
    //    public int ProjectId { get; set; }
    //    public int SowId { get; set; }
    //    public int StageId { get; set; }
    //    public int ComplianceTypeId { get; set; }
    //    public int QuestionId { get; set; }
    //    public int ComplianceStatusId { get; set; }
    //    public string Comments { get; set; }
    //    public int CommentsTypeId { get; set; }
    //    public int ArtefactId { get; set; }        
    //}
    //#endregion

    //#region SprintKickStartQuestion
    //public class SprintKickStartQuestion
    //{
    //    public int AccountId { get; set; }
    //    public int ProjectId { get; set; }
    //    public int SowId { get; set; }
    //    public int StageId { get; set; }
    //    public int ComplianceTypeId { get; set; }
    //    public int QuestionId { get; set; }
    //    public int ComplianceStatusId { get; set; }
    //    public string Comments { get; set; }
    //    public int CommentsTypeId { get; set; }
    //    public int ArtefactId { get; set; }
    //}
    //#endregion

    #region FileUpload
    public class FileUploadModel
    {
        public int QuestionId { get; set; }
        public string File { get; set; }
        public string FileName { get; set; }
        public string FileLength { get; set; }
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
}
