using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CFS.Model.Constants
{
    public static class AppConstants
    {
    }

    public static class StoreProcedure
    {
        public const string AccountList = "sp_getAccountList";
        public const string ComplianceTypeList = "sp_getComplianceTypes {0}";
        public const string AgileQuestionList = "sp_getListofAgileQuestions {0},{1},{2},{3},{4},{5}";
        public const string ProjectKickstartQuestionList = "sp_getListofProjectKickStartQuestions {0},{1},{2},{3},{4}";
        public const string ProjectList = "sp_getProjectList {0}";
        public const string SOWList = "sp_getSowList {0}";
        public const string StageList = "sp_getStageList";
        public const string SprintList = "sp_getSprintList {0}";
        public const string QuestionList = "sp_getQuestionList {0},{1}";
        public const string InsertKickStartResponse = "sp_insProjectKickStartQuestionResponse {0},{1},{2},{3},{4},{5},{6},'{7}',{8},{9},{10}";
        public const string InsertSOWKickStartQuestion = "sp_insSOWKickstartQuestionResponse  {0},{1},{2},{3},{4},{5},{6},'{7}',{8},{9}";
        public const string InsertSprintKickStartQuestion = "sp_insSprintKickStartQuestionResponse  {0},{1},{2},{3},{4},{5},{6},'{7}',{8},{9},{10}";
        public const string MasterList = "sp_getMasterList '{0}'";
        public const string SaveSowQuestionResponse = "sp_SaveSowQuestionResponse  {0},{1},{2},{3},{4},{5},{6},'{7}',{8},'{9}','{10}','{11}','{12}',{13},{14}";
        public const string SaveAgileQuestionResponse = "sp_SaveAgileQuestionResponse  {0},{1},{2},{3},{4},{5},{6},{7},'{8}',{9},'{10}','{11}','{12}','{13}',{14},{15}";
        public const string ArtefactsList = "sp_getArtefacts {0}";
        public const string DeleteSowQuestionResponse = "sp_deleteSowQuestionResponse {0}";
        public const string DeleteSprintQuestionResponse = "sp_deleteSprintQuestionResponse {0}";
        public const string InsertSprintDetails = "sp_insSprintDetails {0},{1},'{2}','{3}','{4}',{5},{6},{7},{8},{9},{10}";
        public const string UpdateSprintDetails = "sp_UpdateSprintDetails {0},{1},{2},'{3}','{4}','{5}',{6},{7},{8},{9},{10},{11}";
        public const string SprintDetails = "sp_getSprintDetails {0}";
        public const string SprintInformationList = "sp_getSprintInformation {0},{1}";
        public const string DeleteSprintInformation = "sp_DeleteSprintDetails {0}";

        public const string InsertAccountManagerMap = "sp_insAccountManagerMap {0},{1},{2},{3},'{4}','{5}'";
        public const string InsertProjectAllocation = "sp_insProjectAllocation {0},{1},{2},{3},'{4}','{5}',{6},'{7}'";
        public const string UpdateProjectAllocation = "sp_UpdateProjectAllocation {0},{1},{2},{3},'{4}','{5}',{6},'{7}'";
        public const string UpdateAccountManagerMap = "sp_UpdateAccountManagerMap {0},{1},{2},{3},'{4}','{5}'";
        public const string DeleteProjectAllocation = "sp_DeleteProjectAllocation {0}";
        public const string DeleteAccountManagerMap = "sp_DeleteAccountManagerMap {0}";
        public const string GetAccountManagerMap = "sp_getAccountManagerMap {0},{1},{2}";
        public const string GetProjectAllocation = "sp_getProjectAllocation {0},{1},{2},{3}";
        public const string GetEmployeeBillability = "Sp_GetEmployeeBillability {0}";
    }
}
