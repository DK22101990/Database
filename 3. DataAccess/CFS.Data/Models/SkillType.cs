using System;
using System.Collections.Generic;

#nullable disable

namespace CFS.Data.Models
{
    public partial class SkillType
    {
        public SkillType()
        {
            EmployeeSkillAssignments = new HashSet<EmployeeSkillAssignment>();
        }

        public int SkillTypeId { get; set; }
        public string SkillTypeName { get; set; }
        public int? IsActive { get; set; }
        public DateTime? LastModifiedOn { get; set; }
        public int? ModifiedById { get; set; }

        public virtual Employee ModifiedBy { get; set; }
        public virtual ICollection<EmployeeSkillAssignment> EmployeeSkillAssignments { get; set; }
    }
}
