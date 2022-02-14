using System;
using System.Collections.Generic;

#nullable disable

namespace CFS.Data.Models
{
    public partial class Account
    {
        public Account()
        {
            Projects = new HashSet<Project>();
            SowkickstartQuestionResponses = new HashSet<SowkickstartQuestionResponse>();
            SprintQuestionResponses = new HashSet<SprintQuestionResponse>();
        }

        public int AccountId { get; set; }
        public string AccountName { get; set; }
        public string DomainIndustry { get; set; }
        public string AccountDescription { get; set; }
        public int? RelationshipManagerId { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Country { get; set; }
        public string PhoneNumber { get; set; }
        public string Msa { get; set; }
        public string Geography { get; set; }
        public DateTime? LastModifiedOn { get; set; }
        public int? ModifiedById { get; set; }
        public int? IsActive { get; set; }

        public virtual Employee ModifiedBy { get; set; }
        public virtual Employee RelationshipManager { get; set; }
        public virtual ICollection<Project> Projects { get; set; }
        public virtual ICollection<SowkickstartQuestionResponse> SowkickstartQuestionResponses { get; set; }
        public virtual ICollection<SprintQuestionResponse> SprintQuestionResponses { get; set; }
    }
}
