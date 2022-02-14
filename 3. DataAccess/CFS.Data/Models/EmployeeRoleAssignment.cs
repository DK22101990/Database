using System;
using System.Collections.Generic;

#nullable disable

namespace CFS.Data.Models
{
    public partial class EmployeeRoleAssignment
    {
        public int EmployeeRoleMapId { get; set; }
        public int? EmployeeId { get; set; }
        public int? RoleId { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public int? IsActive { get; set; }
        public DateTime? LastModifiedOn { get; set; }
        public int? ModifiedById { get; set; }

        public virtual Employee Employee { get; set; }
        public virtual Employee ModifiedBy { get; set; }
        public virtual Role Role { get; set; }
    }
}
