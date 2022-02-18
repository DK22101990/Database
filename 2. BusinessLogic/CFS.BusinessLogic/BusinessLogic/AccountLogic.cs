using AutoMapper;
using CFS.BusinessLogic.IBusinessLogic;
using CFS.Data.Domains;
using CFS.Data.IRepositories;
using CFS.Data.Models;
using CFS.Model.Helpers;
using CFS.Model.Models;
using component.helper;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static CFS.Model.Enums.Enumeration;

namespace CFS.BusinessLogic.BusinessLogic
{
    public class AccountLogic : IAccountLogic
    {
        #region Variables

        private readonly IAccountRepository _iAccountRepository;
        private readonly IConfiguration _configuration;
        private readonly IHostingEnvironment _hostingEnvironment;

        #endregion Variables

        #region Constructor
        public AccountLogic(IAccountRepository iAccountRepository, IConfiguration configuration, IHostingEnvironment hostingEnvironment)
        {
            _iAccountRepository = iAccountRepository;
            _configuration = configuration;
            _hostingEnvironment = hostingEnvironment;
        }

        #endregion Constructor

        #region Methods

        /// <summary>
        /// Get Account List
        /// </summary>
        /// <returns></returns>
        public async Task<List<AccountListViewModel>> GetAccountList()
        {
            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<AccountList, AccountListViewModel>();
            });

            IMapper mapper = config.CreateMapper();
            return mapper.Map<List<AccountListViewModel>>(await _iAccountRepository.GetAccountList());
        }


        /// <summary>
        /// Get All Sprints
        /// </summary>
        /// <param name="ProjectId"></param>
        /// <param name="SowId"></param>
        /// <returns></returns>
        public async Task<List<SprintViewModel>> GetSprintList(int ProjectId, int SowId)
        {
            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<SprintList, SprintViewModel>();
            });

            IMapper mapper = config.CreateMapper();
            return mapper.Map<List<SprintViewModel>>(await _iAccountRepository.GetSprintList(ProjectId, SowId));
        }


        /// <summary>
        /// Get ComplianceType List
        /// </summary>
        /// <returns></returns>
        public async Task<List<ComplianceTypeViewModel>> GetComplianceTypeList(int RoleId)
        {
            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<Data.Domains.ComplianceType, ComplianceTypeViewModel>();
            });

            IMapper mapper = config.CreateMapper();
            return mapper.Map<List<ComplianceTypeViewModel>>(await _iAccountRepository.GetComplianceTypeList(RoleId));
        }

        /// <summary>
        ///  Get Agile Questions
        /// </summary>
        /// <returns></returns>
        public async Task<List<AgileQuestionViewModel>> GetAgileQuestionList(int ComplianceTypeId,
            int ProjectId,
            int AccountId,
            int SowId,
            int StageId,
            int SprintId)
        {
            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<AgileQuestion, AgileQuestionViewModel>();
            });

            IMapper mapper = config.CreateMapper();
            return mapper.Map<List<AgileQuestionViewModel>>(await _iAccountRepository.GetAgileQuestionList(ComplianceTypeId,
                ProjectId,
                AccountId,
                SowId,
                StageId,
                SprintId));
        }

        /// <summary>
        ///  Get Agile Questions
        /// </summary>
        /// <returns></returns>
        public async Task<List<ProjectKickStartQuestionViewModel>> GetProjectKickStartQuestionList(int ComplianceTypeId,
            int ProjectId,
            int AccountId,
            int SowId,
            int StageId)
        {
            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<ProjectKickStartQuestions, ProjectKickStartQuestionViewModel>();
            });

            IMapper mapper = config.CreateMapper();
            return mapper.Map<List<ProjectKickStartQuestionViewModel>>(await _iAccountRepository.GetProjectKickStartQuestionList(ComplianceTypeId,
                ProjectId,
                AccountId,
                SowId,
                StageId));
        }

        /// <summary>
        /// Get Project List
        /// </summary>
        /// <returns></returns>
        public async Task<List<ProjectViewModel>> GetProjectList(int AccountId)
        {
            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<Projects, ProjectViewModel>();
            });

            IMapper mapper = config.CreateMapper();
            return mapper.Map<List<ProjectViewModel>>(await _iAccountRepository.GetProjectList(AccountId));
        }

        /// <summary>
        /// Get SOW List
        /// </summary>
        /// <returns></returns>
        public async Task<List<SOWViewModel>> GetSOWList(int ProjectId)
        {
            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<SOW, SOWViewModel>();
            });

            IMapper mapper = config.CreateMapper();
            return mapper.Map<List<SOWViewModel>>(await _iAccountRepository.GetSOWList(ProjectId));
        }

        /// <summary>
        /// Get Stage List
        /// </summary>
        /// <returns></returns>
        public async Task<List<StageViewModel>> GetStageList(int ProjectId, int ComplianceTypeId)
        {
            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<Data.Domains.Stage, StageViewModel>();
            });

            IMapper mapper = config.CreateMapper();
            return mapper.Map<List<StageViewModel>>(await _iAccountRepository.GetStageList(ProjectId, ComplianceTypeId));
        }

        /// <summary>
        ///  Post Kick Start Response
        /// </summary>
        /// <returns></returns>
        public async Task InsertProjectKickStartQuestion(InsertQuestion kickStartResponse)
        {
            await _iAccountRepository.InsertProjectKickStartQuestion(kickStartResponse);
        }

        /// <summary>
        ///  Post SOW Kick Start Question
        /// </summary>
        /// <returns></returns>
        public async Task InsertSOWKickStartQuestion(InsertQuestion kickStartResponse)
        {
            await _iAccountRepository.InsertSOWKickStartQuestion(kickStartResponse);
        }

        /// <summary>
        ///  Post Sprint Kick Start Question
        /// </summary>
        /// <returns></returns>
        public async Task InsertSprintKickStartQuestion(InsertQuestion kickStartResponse)
        {
            await _iAccountRepository.InsertSprintKickStartQuestion(kickStartResponse);
        }

        /// <summary>
        /// Get Master List
        /// </summary>
        /// <returns></returns>
        public async Task<List<SelectListViewModel>> GetMasterList(string Entity)
        {
            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<SelectList, SelectListViewModel>();
            });

            IMapper mapper = config.CreateMapper();
            return mapper.Map<List<SelectListViewModel>>(await _iAccountRepository.GetMasterList(Entity));
        }

        /// <summary>
        /// Upload Artificate Document
        /// </summary>        
        /// <returns></returns>
        public async Task<ReturnResponseModel> SaveSowQuestionResponse(SaveSowQuestionResponse request)
        {
            if (!request.IsUploaded)
            {
                await _iAccountRepository.SaveSowQuestionResponse(request);
                return new ReturnResponseModel
                {
                    Status = true,
                    Message = string.Format(ApplicationMessage.ArtifactUploadedSuccessfully)
                };
            }

            string uploadPath = _configuration["FilePath:DocUploadPath"];
            List<string> allowedExtensions = ((FileExtensions[])Enum.GetValues(typeof(FileExtensions))).Select(y => y.ToString().ToLower()).ToList();
            if (allowedExtensions.Contains(request.FileName.Substring(request.FileName.IndexOf(".") + 1).ToLower()))
            {
                Guid obj = Guid.NewGuid();
                string extension = System.IO.Path.GetExtension(request.FileName);
                string filepath = Path.Combine(_hostingEnvironment.ContentRootPath, uploadPath, request.QuestionId.ToString());
                //request.FileName = request.FileName.Replace(" ", "");
                string finalpath = FileHelper.GetFinalFilePath(filepath, obj.ToString() + extension);

                Byte[] fileDataByteArray = Convert.FromBase64String(request.File);
                if (FileHelper.FileSizeInMb(fileDataByteArray) <= 5)
                {
                    System.IO.File.WriteAllBytes(finalpath, fileDataByteArray);

                    request.FilePath = finalpath;
                    request.FileSize = fileDataByteArray.Length.ToString();
                    request.FileName = obj.ToString() + extension;

                    await _iAccountRepository.SaveSowQuestionResponse(request);

                    return new ReturnResponseModel
                    {
                        Status = true,
                        Message = string.Format(ApplicationMessage.ArtifactUploadedSuccessfully)
                    };
                }
                else
                    return new ReturnResponseModel { Message = string.Format(ApplicationMessage.FileSizeValidation, "5") };
            }
            else
                return new ReturnResponseModel { Message = string.Format(ApplicationMessage.InvalidArtifact) };
        }

        public async Task<ReturnResponseModel> SaveAgileQuestionResponse(SaveAgileQuestionResponse request)
        {
            if (!request.IsUploaded)
            {
                await _iAccountRepository.SaveAgileQuestionResponse(request);
                return new ReturnResponseModel
                {
                    Status = true,
                    Message = string.Format(ApplicationMessage.ArtifactUploadedSuccessfully)
                };
            }

            string uploadPath = _configuration["FilePath:DocUploadPath"];
            List<string> allowedExtensions = ((FileExtensions[])Enum.GetValues(typeof(FileExtensions))).Select(y => y.ToString().ToLower()).ToList();
            if (allowedExtensions.Contains(request.FileName.Substring(request.FileName.IndexOf(".") + 1).ToLower()))
            {
                Guid obj = Guid.NewGuid();
                string extension = System.IO.Path.GetExtension(request.FileName);
                string filepath = Path.Combine(_hostingEnvironment.ContentRootPath, uploadPath, request.QuestionId.ToString());
                //request.FileName = request.FileName.Replace(" ", "");
                string finalpath = FileHelper.GetFinalFilePath(filepath, obj.ToString() + extension);

                Byte[] fileDataByteArray = Convert.FromBase64String(request.File);
                if (FileHelper.FileSizeInMb(fileDataByteArray) <= 5)
                {
                    System.IO.File.WriteAllBytes(finalpath, fileDataByteArray);

                    request.FilePath = finalpath;
                    request.FileSize = fileDataByteArray.Length.ToString();
                    request.FileName = obj.ToString() + extension;

                    await _iAccountRepository.SaveAgileQuestionResponse(request);

                    return new ReturnResponseModel
                    {
                        Status = true,
                        Message = string.Format(ApplicationMessage.ArtifactUploadedSuccessfully)
                    };
                }
                else
                    return new ReturnResponseModel { Message = string.Format(ApplicationMessage.FileSizeValidation, "5") };
            }
            else
                return new ReturnResponseModel { Message = string.Format(ApplicationMessage.InvalidArtifact) };
        }
        #endregion
    }
}
