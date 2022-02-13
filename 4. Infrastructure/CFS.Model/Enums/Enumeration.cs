using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CFS.Model.Enums
{
    public static class Enumeration
    {
        /// <summary>
        /// Supported Upload File Formats
        /// </summary>
        public enum FileExtensions
        {
            [Description("jpg")] jpg,
            [Description("jpeg")] jpeg,
            [Description("png")] png,
            [Description("pdf")] pdf,
            [Description("doc")] doc,
            [Description("docx")] docx,
            [Description("ppt")] ppt,
            [Description("xls")] xls,
            [Description("xlsx")] xlsx,
            [Description("csv")] csv,
            [Description("webm")] webm
        }
        //Enum list for entity description for messages
        public enum EntityDescription
        {
            [Description("Artifact")] Artifact,
        }
    }
}
