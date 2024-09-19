using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System;
using System.Collections.Generic;

#nullable disable

namespace CFS.Data.Models
{
    public partial class HolidayList
    {
        [Key]
        public int id { get; set; }
        public DateTime? holidaydate { get; set; }
        public string description { get; set; }
        public int year { get; set; }
    }
}
