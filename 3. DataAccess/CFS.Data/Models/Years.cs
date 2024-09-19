using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

#nullable disable

namespace CFS.Data.Models
{
    public partial class Years
    {
        [Key]
        public int YearID { get; set; }
        public int YearValue { get; set; }
    }
}
