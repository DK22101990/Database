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
        private readonly IMapper _mapper;

        #endregion Variables

        #region Constructor
        public AccountLogic(IAccountRepository iAccountRepository, IConfiguration configuration, IHostingEnvironment hostingEnvironment,
            IMapper mapper)
        {
            _iAccountRepository = iAccountRepository;
            _configuration = configuration;
            _hostingEnvironment = hostingEnvironment;
            _mapper = mapper;
        }

        #endregion Constructor

        #region Methods

        /// <summary>
        /// Get Account List
        /// </summary>
        /// <returns></returns>
        public async Task<List<AccountListViewModel>> GetAccountList()
        {
            return _mapper.Map<List<AccountListViewModel>>(await _iAccountRepository.GetAccountList());
        }
        /// <summary>
        /// Get Account response
        /// </summary>
        /// <returns></returns>
        /// <summary>
        /// Get Account List2
        /// </summary>
        /// <returns></returns>
        public async Task<List<AccountResponseViewModel>> GetAccountResponseList()
        {
            return _mapper.Map<List<AccountResponseViewModel>>(await _iAccountRepository.GetAccountResponseList());
        }




        /// <summary>
        /// Get All Sprints
        /// </summary>
        /// <param name="ProjectId"></param>
        /// <param name="SowId"></param>
        /// <returns></returns>
        public async Task<List<SprintViewModel>> GetSprintList(int SowId)
        {
            return _mapper.Map<List<SprintViewModel>>(await _iAccountRepository.GetSprintList(SowId));
        }


        /// <summary>
        /// Get ComplianceType List
        /// </summary>
        /// <returns></returns>
        public async Task<List<ComplianceTypeViewModel>> GetComplianceTypeList(int StageId)
        {
            return _mapper.Map<List<ComplianceTypeViewModel>>(await _iAccountRepository.GetComplianceTypeList(StageId));
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
            return _mapper.Map<List<AgileQuestionViewModel>>(await _iAccountRepository.GetAgileQuestionList(ComplianceTypeId,
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
            return _mapper.Map<List<ProjectKickStartQuestionViewModel>>(await _iAccountRepository.GetProjectKickStartQuestionList(ComplianceTypeId,
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
            return _mapper.Map<List<ProjectViewModel>>(await _iAccountRepository.GetProjectList(AccountId));
        }

        /// <summary>
        /// Get SOW List
        /// </summary>
        /// <returns></returns>

        public async Task<List<ProjectDomainViewModel>> GetProjectDomainList( )
        {
            return _mapper.Map<List<ProjectDomainViewModel>>(await _iAccountRepository.GetProjectDomainList());
        }

        /// <summary>
        /// Get SOW List
        /// </summary>
        /// <returns></returns>

        public async Task<List<SOWViewModel>> GetSOWList(int ProjectId, int AccountId)
        {
            return _mapper.Map<List<SOWViewModel>>(await _iAccountRepository.GetSOWList(ProjectId, AccountId));
        }

        /// <summary>
        /// Get Stage List
        /// </summary>
        /// <returns></returns>
        public async Task<List<StageViewModel>> GetStageList()
        {
            return _mapper.Map<List<StageViewModel>>(await _iAccountRepository.GetStageList());
        }

        /// <summary>
        /// Get Question List
        /// </summary>
        /// <param name="StageId"></param>
        /// <param name="ComplianceTypeId"></param>
        /// <returns></returns>
        /// 

        public async Task<List<QuestionListViewModel>> GetQuestionList(int StageId, int ComplianceTypeId)
        {
            return _mapper.Map<List<QuestionListViewModel>>(await _iAccountRepository.GetQuestionList(StageId, ComplianceTypeId));
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
            return _mapper.Map<List<SelectListViewModel>>(await _iAccountRepository.GetMasterList(Entity));
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
                    Message = string.Format(ApplicationMessage.SaveSuccessfully, "Sow Question")
                };
            }

            string uploadPath = _configuration["FilePath:DocUploadPath"];
            List<string> allowedExtensions = ((FileExtensions[])Enum.GetValues(typeof(FileExtensions))).Select(y => y.ToString().ToLower()).ToList();
            if (allowedExtensions.Contains(request.FileName.Substring(request.FileName.IndexOf(".") + 1).ToLower()))
            {
                Guid obj = Guid.NewGuid();
                string extension = System.IO.Path.GetExtension(request.FileName);
                string filepath = Path.Combine("C:\\Projects", uploadPath, request.QuestionId.ToString());
                //request.FileName = request.FileName.Replace(" ", "");
                string finalpath = FileHelper.GetFinalFilePath(filepath, obj.ToString() + extension);

                Byte[] fileDataByteArray = Convert.FromBase64String(request.File);
                if (FileHelper.FileSizeInMb(fileDataByteArray) <= 5)
                {
                    System.IO.File.WriteAllBytes(finalpath, fileDataByteArray);

                    request.FilePath = filepath;
                    request.FileSize = fileDataByteArray.Length.ToString();
                    request.FileName = obj.ToString() + extension;

                    await _iAccountRepository.SaveSowQuestionResponse(request);

                    return new ReturnResponseModel
                    {
                        Status = true,
                        Message = string.Format(ApplicationMessage.SaveSuccessfully, "Sow Question")
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
                    Message = string.Format(ApplicationMessage.SaveSuccessfully, "Agile Question")
                };
            }

            string uploadPath = _configuration["FilePath:DocUploadPath"];
            List<string> allowedExtensions = ((FileExtensions[])Enum.GetValues(typeof(FileExtensions))).Select(y => y.ToString().ToLower()).ToList();
            if (allowedExtensions.Contains(request.FileName.Substring(request.FileName.IndexOf(".") + 1).ToLower()))
            {
                Guid obj = Guid.NewGuid();
                string extension = System.IO.Path.GetExtension(request.FileName);
                string filepath = Path.Combine("C:\\Projects", uploadPath, request.QuestionId.ToString());
                //string fnma = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot");
                //request.FileName = request.FileName.Replace(" ", "");
                string finalpath = FileHelper.GetFinalFilePath(filepath, obj.ToString() + extension);

                Byte[] fileDataByteArray = Convert.FromBase64String(request.File);
                if (FileHelper.FileSizeInMb(fileDataByteArray) <= 5)
                {
                    System.IO.File.WriteAllBytes(finalpath, fileDataByteArray);

                    request.FilePath = filepath;
                    request.FileSize = fileDataByteArray.Length.ToString();
                    request.FileName = obj.ToString() + extension;

                    await _iAccountRepository.SaveAgileQuestionResponse(request);

                    return new ReturnResponseModel
                    {
                        Status = true,
                        Message = string.Format(ApplicationMessage.SaveSuccessfully, "Agile Question")
                    };
                }
                else
                    return new ReturnResponseModel { Message = string.Format(ApplicationMessage.FileSizeValidation, "5") };
            }
            else
                return new ReturnResponseModel { Message = string.Format(ApplicationMessage.InvalidArtifact) };
        }


        /// <summary>
        /// Delete carrier document
        /// </summary>
        /// <param name="ArtefactId"></param>
        /// <returns>Response Model</returns>
        public async Task<ReturnResponseModel> DeleteSowQuestionResponse(int ArtefactId)
        {
            ReturnResponseModel result = new ReturnResponseModel();
            var objArtefact = await _iAccountRepository.GetArtefactById(ArtefactId);
            if (objArtefact != null)
            {
                if (Directory.Exists(objArtefact.FilePath) && File.Exists(Path.Combine(objArtefact.FilePath, objArtefact.FileName)))
                    File.Delete(Path.Combine(objArtefact.FilePath, objArtefact.FileName));
                await _iAccountRepository.DeleteSowQuestionResponse(ArtefactId);
                return new ReturnResponseModel { Status = true };
            }
            return new ReturnResponseModel { Status = false, Message = ApplicationMessage.ArtefactNotFound };
        }

        /// <summary>
        /// Delete carrier document
        /// </summary>
        /// <param name="ArtefactId"></param>
        /// <returns>Response Model</returns>
        public async Task<ReturnResponseModel> DeleteSprintQuestionResponse(int ArtefactId)
        {
            ReturnResponseModel result = new ReturnResponseModel();
            var objArtefact = await _iAccountRepository.GetArtefactById(ArtefactId);
            if (objArtefact != null)
            {
                if (Directory.Exists(objArtefact.FilePath) && File.Exists(Path.Combine(objArtefact.FilePath, objArtefact.FileName)))
                    File.Delete(Path.Combine(objArtefact.FilePath, objArtefact.FileName));
                await _iAccountRepository.DeleteSprintQuestionResponse(ArtefactId);
                return new ReturnResponseModel { Status = true };
            }
            return new ReturnResponseModel { Status = false, Message = ApplicationMessage.ArtefactNotFound };
        }

        /// <summary>
        /// Download Artefact document
        /// </summary>
        /// <param name="ArtefactId"></param>
        /// <returns>Response Model</returns>
        public async Task<ArtefactDownload> DownloadArtefact(int ArtefactId)
        {
            var objArtefact = await _iAccountRepository.GetArtefactById(ArtefactId);
            if (objArtefact == null)
            {
                return new ArtefactDownload
                {
                    returnResponseModel = new ReturnResponseModel { Status = false, Message = ApplicationMessage.ArtefactNotFound }
                };
            }
            else
            {
                if (Directory.Exists(objArtefact.FilePath) && File.Exists(Path.Combine(objArtefact.FilePath, objArtefact.FileName)))
                {
                    return new ArtefactDownload
                    {
                        returnResponseModel = new ReturnResponseModel { Status = true },
                        FilePath = Path.Combine(objArtefact.FilePath, objArtefact.FileName),
                        DisplayName = objArtefact.DisplayName
                    };
                }
                return new ArtefactDownload
                {
                    returnResponseModel = new ReturnResponseModel { Status = false, Message = ApplicationMessage.ArtefactNotFound }
                };
            }
        }
        #endregion

        #region Sprint Detils
        /// <summary>
        /// Insert Sprint Details  
        /// </summary>
        /// <param name="objsprintModel"></param>
        /// <returns></returns>
        public async Task<ReturnResponseModel> InsertSprintDetails(SprintModel objsprintModel)
        {
            var objResult = await _iAccountRepository.InsertSprintDetails(objsprintModel);
            if (objResult.Status)
            {
                return new ReturnResponseModel
                {
                    Status = true,
                    Message = string.Format(ApplicationMessage.SaveSuccessfully, "Sprint Details")
                };
            }
            return new ReturnResponseModel
            {
                Status = false,
                Message = string.Format(ApplicationMessage.BadRequst)
            };
        }

        /// <summary>
        /// Update Sprint Details  
        /// </summary>
        /// <param name="objsprintModel"></param>
        /// <returns></returns>
        public async Task<ReturnResponseModel> UpdateSprintDetails(SprintModel objsprintModel)
        {
            var objResult = await _iAccountRepository.UpdateSprintDetails(objsprintModel);
            if (objResult.Status)
            {
                return new ReturnResponseModel
                {
                    Status = true,
                    Message = string.Format(ApplicationMessage.UpdateSuccessfully, "Sprint Details")
                };
            }
            return new ReturnResponseModel
            {
                Status = false,
                Message = string.Format(ApplicationMessage.BadRequst)
            };
        }
        /// <summary>
        /// Get Sprint By Id
        /// </summary>
        /// <param name="sprintId"></param>
        /// <returns></returns>
        public async Task<SprintModel> GetSprintById(int sprintId)
        {
            return _mapper.Map<SprintModel>(await _iAccountRepository.GetSprintById(sprintId));
        }


        /// <summary>
        /// Get Sprint Informations
        /// </summary>
        /// <param name="sowId"></param>
        /// <param name="projectId"></param>
        /// <returns></returns>
        public async Task<List<SprintModel>> GetSprintInformationAsync(int sowId, int projectId)
        {
            return _mapper.Map<List<SprintModel>>(await _iAccountRepository.GetSprintInformationAsync(sowId, projectId));
        }

        /// <summary>
        /// Delete Sprint information
        /// </summary>
        /// <param name="sprintId"></param>
        /// <returns></returns>
        public async Task<ReturnResponseModel> DeleteSprintAsync(int sprintId)
        {
            var objResult = await _iAccountRepository.DeleteSprintAsync(sprintId);
            if (objResult.Status)
            {
                return new ReturnResponseModel
                {
                    Status = true,
                    Message = string.Format(ApplicationMessage.DeleteSuccessfully, "Sprint Details")
                };
            }
            return new ReturnResponseModel
            {
                Status = false,
                Message = string.Format(ApplicationMessage.BadRequst)
            };
        }


        #endregion


        #region Projects

        /// <summary>
        /// Insert project response
        /// </summary>
        /// <param name="objprojectModel"></param>
        /// <returns></returns>
        public async Task<ReturnResponseModel> InsertProjectResponse(InsertProjectResponseModel objprojectModel)
        {
            var objResult = await _iAccountRepository.InsertProjectResponse(objprojectModel);
            if (objResult.Status)
            {
                return new ReturnResponseModel
                {
                    Status = true,
                    Message = string.Format(ApplicationMessage.SaveSuccessfully, "Project Response")
                };
            }
            return new ReturnResponseModel
            {
                Status = false,
                Message = string.Format(ApplicationMessage.BadRequst)
            };
        }





        /// <summary>
        /// Insert project response
        /// </summary>
        /// <param name="objprojectModel"></param>
        /// <returns></returns>
        public async Task<ReturnResponseModel> UpdateProjectResponse(UpdateProjectResponseModel objprojectModel)
        {
            var objResult = await _iAccountRepository.UpdateProjectResponse(objprojectModel);
            if (objResult.Status)
            {
                return new ReturnResponseModel
                {
                    Status = true,
                    Message = string.Format(ApplicationMessage.UpdateSuccessfully, "Project Response")
                };
            }
            return new ReturnResponseModel
            {
                Status = false,
                Message = string.Format(ApplicationMessage.BadRequst)
            };
        }

        /// <summary>
        /// Get All Project Response
        /// </summary>
        /// <returns></returns>
        public async Task<List<ProjectViewModel>> GetAllProjectResponse(int AccountId)
        {
            return _mapper.Map<List<ProjectViewModel>>(await _iAccountRepository.GetAllProjectResponse(AccountId));
        }

        /// <summary>
        /// Delete Project Response
        /// </summary>
        /// <param name="projectId"></param>
        /// <returns>Response Model</returns>
        public async Task<ReturnResponseModel> DeleteProjectResponse(int projectId)
        {
            ReturnResponseModel result = new ReturnResponseModel();
            //var objProjectResponse = await _iAccountRepository.GetArtefactById(projectId);
            if (1 == 1)
            {
                await _iAccountRepository.DeleteProjectResponse(projectId);
                return new ReturnResponseModel { Status = true };
            }
            return new ReturnResponseModel { Status = false, Message = ApplicationMessage.ProjectNotFound };
        }

        #endregion

        #region SowResponse
        /// <summary>
        /// Insert SOW Response
        /// </summary>
        /// <param name="objSowResponse"></param>
        /// <returns></returns>
        public async Task<ReturnResponseModel> InsertSowResponse(InsertUpdateSowResponseModel objSowResponse)
        {
            var objResult = await _iAccountRepository.InsertSowResponseAsync(objSowResponse);
            if (objResult.Status)
            {
                return new ReturnResponseModel
                {
                    Status = true,
                    Message = string.Format(ApplicationMessage.SaveSuccessfully, "SOW Response")
                };
            }
            return new ReturnResponseModel
            {
                Status = false,
                Message = string.Format(ApplicationMessage.BadRequst)
            };
          
        }

        /// <summary>
        /// Update SOW Response
        /// </summary>
        /// <param name="objSowResponse"></param>
        /// <returns></returns>
        public async Task<ReturnResponseModel> UpdateSowResponse(InsertUpdateSowResponseModel objSowResponse)
        {
            var objResult = await _iAccountRepository.UpdateSowResponseAsync(objSowResponse);
            if (objResult.Status)
            {
                return new ReturnResponseModel
                {
                    Status = true,
                    Message = string.Format(ApplicationMessage.UpdateSuccessfully, "SOW Response")
                };
            }
            return new ReturnResponseModel
            {
                Status = false,
                Message = string.Format(ApplicationMessage.BadRequst)
            };
            
        }

        /// <summary>
        /// Get All Project Response
        /// </summary>
        /// <returns></returns>
        public async Task<List<SOWViewModel>> GetAllSowResponse(int AccountId, int ProjectId)
        {
            return _mapper.Map<List<SOWViewModel>>(await _iAccountRepository.GetAllSowResponseAsync(AccountId,ProjectId));
        }

        /// <summary>
        /// Delete SOW Response
        /// </summary>
        /// <param name="sowId">sowId</param>
        /// <returns></returns>
        public async Task<ReturnResponseModel> DeleteSowResponse(int sowId)
        {
            ReturnResponseModel result = new ReturnResponseModel();
            var objResponse = await _iAccountRepository.GetSowByIdAsync(sowId);
            if (objResponse != null && objResponse.SowId > 0)
            {
                await _iAccountRepository.DeleteSowResponseAsync(sowId);
                return new ReturnResponseModel { Status = true };
            }
            return new ReturnResponseModel { Status = false, Message = string.Format(ApplicationMessage.NotFound, "SOW") };
        }

        /// <summary>
        /// Get Sow Response By Id
        /// </summary>
        /// <param name="sowId"></param>
        /// <returns></returns>
        public async Task<SowDataViewModel> GetSowByIdAsync(int sowId)
        {
            //return new SowDataViewModel();
            return _mapper.Map<SowDataViewModel>(await _iAccountRepository.GetSowDataByIdAsync(sowId));
        }
        /// <summary>
        /// Insert Account response
        /// </summary>
        /// <param name="objAccountModel"></param>
        /// <returns></returns>
        public async Task<ReturnResponseModel> InsertAccountResponse(InsertAccountResponseModel objAccountModel)
        {
            var objResult = await _iAccountRepository.InsertAccountResponse(objAccountModel);
            if (objResult.Status)
            {
                return new ReturnResponseModel
                {
                    Status = true,
                    Message = string.Format(ApplicationMessage.SaveSuccessfully, "Account Response")
                };
            }
            return new ReturnResponseModel
            {
                Status = false,
                Message = string.Format(ApplicationMessage.BadRequst)
            };
        }
        /// <summary>
        /// Insert Account response
        /// </summary>
        /// <param name="objAccountModel"></param>
        /// <returns></returns>
        public async Task<ReturnResponseModel> UpdateAccountResponse(UpdateAccountResponseModel objAccountModel)
        {
            var objResult = await _iAccountRepository.UpdateAccountResponse(objAccountModel);
            if (objResult.Status)
            {
                return new ReturnResponseModel
                {
                    Status = true,
                    Message = string.Format(ApplicationMessage.UpdateSuccessfully, "Account Response")
                };
            }
            return new ReturnResponseModel
            {
                Status = false,
                Message = string.Format(ApplicationMessage.BadRequst)
            };
        }
        /// <summary>
        /// Delete Accoount Response
        /// </summary>
        /// <param name="AccountId"></param>
        /// <returns>Response Model</returns>
        public async Task<ReturnResponseModel> DeleteAccountResponse(int AccountId)
        {
            ReturnResponseModel result = new ReturnResponseModel();

            if (1 == 1)
            {
                await _iAccountRepository.DeleteAccountResponse(AccountId);
                return new ReturnResponseModel { Status = true };
            }
            return new ReturnResponseModel { Status = false, Message = ApplicationMessage.AccountNotFound };
        }

        #endregion

    }
}
