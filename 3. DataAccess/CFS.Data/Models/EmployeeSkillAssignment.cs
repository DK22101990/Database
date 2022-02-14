using System;
using System.Collections.Generic;

#nullable disable

namespace CFS.Data.Models
{
    public partial class EmployeeSkillAssignment
    {
        public int EmployeeSkillAssignmentMapId { get; set; }
        public int? SkillId { get; set; }
        public int? SkillTypeId { get; set; }
        public int? EmployeeId { get; set; }
        public int? IsActive { get; set; }
        public DateTime? LastModifiedOn { get; set; }
        public int? ModifiedById { get; set; }

        public virtual Employee Employee { get; set; }
        public virtual Employee ModifiedBy { get; set; }
        public virtual Skill Skill { get; set; }
        public virtual SkillType SkillType { get; set; }
    }
}
