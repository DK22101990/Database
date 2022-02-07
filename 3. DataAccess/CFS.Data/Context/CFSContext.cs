using CFS.Data.Domains;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CFS.Data.Context
{
   public class CFSContext : DbContext
    {
        public CFSContext()
        {
        }

        public CFSContext(DbContextOptions<CFSContext> options)
            : base(options)
        {
        }

        [NotMapped]
        public DbSet<AccountList> GetAccountList { get; set; }
        [NotMapped]
        public DbSet<ComplianceType> GetComplianceTypeList { get; set; }
        [NotMapped]
        public DbSet<AgileQuestion> GetAgileQuestionList { get; set; }
        [NotMapped]
        public DbSet<ProjectKickStartQuestions> GetProjectKickStartQuestionList { get; set; }

        [NotMapped]
        public DbSet<Projects> GetProjectList { get; set; }

        [NotMapped]
        public DbSet<SOW> GetSowList { get; set; }

        [NotMapped]
        public DbSet<Stage> GetStageList { get; set; }

        [NotMapped]
        public DbSet<SelectList> GetMasterList { get; set; }
    }
}
