using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CFS.Data.Models
{
    public partial class ProjectDomain
    {
        public int ProjectDomainId { get; set; }
        public string Projectdomain { get; set; }
        public int IsActive { get; set; }
        public DateTime LastModifiedOn { get; set; }  

        public int ModifiedById { get; set;}

        public virtual Employee ModifiedBy { get; set; }
        public virtual ICollection<Project> Projects { get; set; }


    }
}
