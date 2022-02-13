using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CFS.Data.Domains
{
    public class Artefact
    {
        [Key]
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
}
