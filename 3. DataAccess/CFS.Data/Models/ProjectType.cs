using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CFS.Data.Models
{
    public  class ProjectType
    {

        public int ProjectTypeId { get; set; }
        public string Projecttype { get; set; }
        public int IsActive { get; set; }
        public DateTime LasModifiedOn { get; set; }
        public int ModifiedById { get; set; }


        public virtual Employee ModifiedBy { get; set; }
        public virtual ICollection<Project> Projects { get; set; }
    }
}
