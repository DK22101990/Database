using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System;
using System.Collections.Generic;

#nullable disable

namespace CFS.Data.Models
{
    public partial class TimeSheetExport
    {
        [Key]
        public int id { get; set; }
        public int projectid { get; set; }
        public int employeecode { get; set; }
        public string employeename { get; set; }
        public DateTime date { get; set; }
        public string client { get; set; }
        public string project { get; set; }
        public int timeentered { get; set; }
    }
}
