using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CFS.Data.Models
{
    public class ContractType
    {
        public int ContractTypeId { get; set; }

        public string Contracttype { get; set; }
        public int IsActive { get; set; } 

        public DateTime? LastModifiedOn { get; set; }
        public int ModifiedById { get; set; }
    }
}
