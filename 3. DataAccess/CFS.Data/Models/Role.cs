using System;
using System.Collections.Generic;

#nullable disable

namespace CFS.Data.Models
{
    public partial class Role
    {
        public Role()
        {
            EmployeeRoleAssignments = new HashSet<EmployeeRoleAssignment>();
            QuestionCategoryMaps = new HashSet<QuestionCategoryMap>();
            RoleComplianceTypes = new HashSet<RoleComplianceType>();
        }

        public int RoleId { get; set; }
        public string RoleName { get; set; }
        public string Description { get; set; }
        public int? IsActive { get; set; }
        public DateTime? LastModifiedOn { get; set; }
        public int? ModifiedById { get; set; }

        public virtual Employee ModifiedBy { get; set; }
        public virtual ICollection<EmployeeRoleAssignment> EmployeeRoleAssignments { get; set; }
        public virtual ICollection<QuestionCategoryMap> QuestionCategoryMaps { get; set; }
        public virtual ICollection<RoleComplianceType> RoleComplianceTypes { get; set; }
    }
}
