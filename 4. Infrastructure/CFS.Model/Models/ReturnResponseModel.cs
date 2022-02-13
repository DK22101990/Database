using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CFS.Model.Models
{
    public class ReturnResponseModel
    {
        public string Message { get; set; }
        public bool Status { get; set; }
        public string Type { get; set; }
        public int? PrimaryKey { get; set; }
    }
    public class ReturnResponseModel<T>
    {
        public string Message { get; set; }
        public bool Status { get; set; }
        public T ResponseObject { get; set; }
        public int? PrimaryKey { get; set; }
    }
}
