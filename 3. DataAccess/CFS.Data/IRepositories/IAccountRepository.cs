﻿using CFS.Data.Domains;
using CFS.Model.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CFS.Data.IRepositories
{
    public interface IAccountRepository
    {
        /// <summary>
        /// Get Account List
        /// </summary>
        /// <returns></returns>
        Task<List<AccountList>> GetAccountList();

        // <summary>
        /// Get ComplianceType List
        /// </summary>
        /// <returns></returns>
        Task<List<ComplianceType>> GetComplianceTypeList(int RoleId);

        /// <summary>
        /// Get Agile Questions
        /// </summary>
        /// <param name="RoleId"></param>
        /// <returns></returns>
        Task<List<AgileQuestion>> GetAgileQuestionList(int ComplianceTypeId,
            int ProjectId,
            int AccountId,
            int SowId,
            int StageId,
            int SprintId);

        /// <summary>
        /// Post Kick Start Response
        /// </summary>
        /// <returns></returns>
        Task InsertProjectKickStartQuestion(InsertQuestion kickStartResponse);

        /// <summary>
        /// Post SOW Start Question
        /// </summary>
        /// <returns></returns>
        Task InsertSOWKickStartQuestion(InsertQuestion kickStartResponse);

        /// <summary>
        /// Post Sprint Start Question
        /// </summary>
        /// <returns></returns>
        Task InsertSprintKickStartQuestion(InsertQuestion kickStartResponse);

        /// <summary>
        /// Get Master List
        /// </summary>
        /// <returns></returns>
        Task<List<SelectList>> GetMasterList(string Entity);

        /// <summary>
        /// Add Artifact
        /// </summary>
        /// <param name="artefact"></param>
        /// <returns></returns>
        Task<Artefact> AddArtifactAsync(Artefact artefact);

        /// <summary>
        /// Get Project KickStart Questions
        /// </summary>
        /// <param name="ComplianceTypeId"></param>
        /// <param name="ProjectId"></param>
        /// <param name="AccountId"></param>
        /// <param name="SowId"></param>
        /// <param name="StageId"></param>
        /// <returns></returns>
        Task<List<ProjectKickStartQuestions>> GetProjectKickStartQuestionList(int ComplianceTypeId,
            int ProjectId,
            int AccountId,
            int SowId,
            int StageId);

        /// <summary>
        /// Get Projects
        /// </summary>
        /// <param name="AccountId"></param>
        /// <returns></returns>
        Task<List<Projects>> GetProjectList(int AccountId);

        /// <summary>
        /// Get SOW
        /// </summary>
        /// <param name="ProjectId"></param>
        /// <returns></returns>
        Task<List<SOW>> GetSOWList(int ProjectId);

        /// <summary>
        /// Get Stage
        /// </summary>
        /// <param name="ProjectId"></param>
        /// <param name="ComplianceTypeId"></param>
        /// <returns></returns>
        Task<List<Stage>> GetStageList(int ProjectId, int ComplianceTypeId);
    }
}
