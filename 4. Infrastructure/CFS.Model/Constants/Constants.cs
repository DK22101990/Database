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
    }
}
