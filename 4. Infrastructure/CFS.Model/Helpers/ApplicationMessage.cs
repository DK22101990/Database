using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CFS.Model.Helpers
{
    public static class ApplicationMessage
    {
        public const string InvalidArtifact = "Invalid file format. Only DOC, DOCX, PPT, xls, xlsx and PDF formats are allowed";
        public const string ArtifactUploadedSuccessfully = "Artifact uploaded successfully";
        public const string FileSizeValidation = "File with max {0} MB size allowed.";
        public const string JobPostCreated = "A new job post <a href='{0}'>{1}</a> is assigned to you.";
        public const string JobPostUpdated = "Job post <a href='{0}'>{1}</a> is updated.";
        public const string ArtefactNotFound = "Artefact not found.";
        public const string SaveSuccessfully = "{0} saved successfully";
        public const string UpdateSuccessfully = "{0} updated successfully";
        public const string BadRequst = "Please provide valid information";
        public const string DeleteSuccessfully = "{0} deleted successfully";
        public const string ProjectNotFound = "Project not found.";
        public const string NotFound = "{0} not found.";
        public const string AccountNotFound = "{0} not found.";
    }
}
