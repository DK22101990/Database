using System;
using System.Collections.Generic;

#nullable disable

namespace CFS.Data.Models
{
    public partial class Skill
    {
        public Skill()
        {
            EmployeeSkillAssignments = new HashSet<EmployeeSkillAssignment>();
        }

        public int SkillId { get; set; }
        public string SkillName { get; set; }
        public int? IsActive { get; set; }
        public DateTime? LastModifiedOn { get; set; }
        public int? ModifiedById { get; set; }

        public virtual Employee ModifiedBy { get; set; }
        public virtual ICollection<EmployeeSkillAssignment> EmployeeSkillAssignments { get; set; }
    }
}
