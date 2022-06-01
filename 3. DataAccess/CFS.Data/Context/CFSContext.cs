using CFS.Data.Domains;
using CFS.Data.Models;
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

        public virtual DbSet<Account> Accounts { get; set; }
        public virtual DbSet<AgileDatum> AgileData { get; set; }
        public virtual DbSet<Models.Artefact> Artefacts { get; set; }
        public virtual DbSet<CommentType> CommentTypes { get; set; }
        public virtual DbSet<ComplianceProject> ComplianceProjects { get; set; }
        public virtual DbSet<ComplianceStatus> ComplianceStatuses { get; set; }
        public virtual DbSet<Models.ComplianceType> ComplianceTypes { get; set; }
        public virtual DbSet<Currency> Currencies { get; set; }
        public virtual DbSet<Department> Departments { get; set; }
        public virtual DbSet<Employee> Employees { get; set; }
        public virtual DbSet<EmployeeProjectAllocation> EmployeeProjectAllocations { get; set; }
        public virtual DbSet<EmployeeRoleAssignment> EmployeeRoleAssignments { get; set; }
        public virtual DbSet<EmployeeSkillAssignment> EmployeeSkillAssignments { get; set; }
        public virtual DbSet<Opportunity> Opportunities { get; set; }
        public virtual DbSet<Project> Projects { get; set; }
        public virtual DbSet<ProjectManagerMap> ProjectManagerMaps { get; set; }
        public virtual DbSet<Question> Questions { get; set; }
        public virtual DbSet<QuestionCategoryMap> QuestionCategoryMaps { get; set; }
        public virtual DbSet<QuestionsCompliance> QuestionsCompliances { get; set; }
        public virtual DbSet<Role> Roles { get; set; }
        public virtual DbSet<RoleComplianceType> RoleComplianceTypes { get; set; }
        public virtual DbSet<Skill> Skills { get; set; }
        public virtual DbSet<SkillType> SkillTypes { get; set; }
        public virtual DbSet<Sow> Sows { get; set; }
        public virtual DbSet<SowkickstartQuestionResponse> SowkickstartQuestionResponses { get; set; }
        public virtual DbSet<Sprint> Sprints { get; set; }
        public virtual DbSet<SprintDetail> SprintDetails { get; set; }
        public virtual DbSet<SprintQuestionResponse> SprintQuestionResponses { get; set; }
        public virtual DbSet<SprintScore> SprintScores { get; set; }
        public virtual DbSet<Models.Stage> Stages { get; set; }
        public virtual DbSet<StageComplianceType> StageComplianceTypes { get; set; }
        public virtual DbSet<StageDatum> StageData { get; set; }
        public virtual DbSet<Variance> Variances { get; set; }

        [NotMapped]
        public DbSet<AccountList> GetAccountList { get; set; }
        [NotMapped]
        public DbSet<QuestionList> GetQuestionList { get; set; }
        [NotMapped]
        public DbSet<SprintList> GetSprintList { get; set; }
        [NotMapped]
        public DbSet<ArtefactList> GetArtefact { get; set; }

        [NotMapped]
        public DbSet<SprintInformation> GetSprintDetail { get; set; }

        [NotMapped]
        public DbSet<SprintDetailList> GetSprintInformationList { get; set; }

        [NotMapped]
        public DbSet<AccountManagerMapList> GetAccountManagerMapList { get; set; }

        [NotMapped]
        public DbSet<ProjectAllocationList> GetProjectAllocationList { get; set; }

        [NotMapped]
        public DbSet<EmployeeBillability> GetEmployeeBillability { get; set; }

        [NotMapped]
        public DbSet<EmployeeDetails> GetEmployeeDetail { get; set; }

        [NotMapped]
        public DbSet<Domains.ComplianceType> GetComplianceTypeList { get; set; }
        [NotMapped]
        public DbSet<AgileQuestion> GetAgileQuestionList { get; set; }
        [NotMapped]
        public DbSet<ProjectKickStartQuestions> GetProjectKickStartQuestionList { get; set; }

        [NotMapped]
        public DbSet<Projects> GetProjectList { get; set; }

        [NotMapped]
        public DbSet<SOW> GetSowList { get; set; }

        [NotMapped]
        public DbSet<Domains.Stage> GetStageList { get; set; }

        [NotMapped]
        public DbSet<SelectList> GetMasterList { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=(LocalDB)\\MSSQLLocalDB;Database=ComplianceProjectFinal;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");

            modelBuilder.Entity<Account>(entity =>
            {
                entity.Property(e => e.AccountDescription)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.AccountName)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.City)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Country)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DomainIndustry)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("Domain/Industry");

                entity.Property(e => e.Geography)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.LastModifiedOn).HasColumnType("datetime");

                entity.Property(e => e.Msa)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("MSA");

                entity.Property(e => e.PhoneNumber)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.State)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.ModifiedBy)
                    .WithMany(p => p.AccountModifiedBies)
                    .HasForeignKey(d => d.ModifiedById)
                    .HasConstraintName("Fk_AccountModified");

                entity.HasOne(d => d.RelationshipManager)
                    .WithMany(p => p.AccountRelationshipManagers)
                    .HasForeignKey(d => d.RelationshipManagerId)
                    .HasConstraintName("FK__Accounts__Relati__60A75C0F");
            });

            modelBuilder.Entity<AgileDatum>(entity =>
            {
                entity.HasKey(e => e.AgileId)
                    .HasName("PK__AgileDat__EE6482C50551BF39");

                entity.Property(e => e.BaCompliance).HasColumnName("BA_Compliance");

                entity.Property(e => e.LastModifiedOn).HasColumnType("datetime");

                entity.Property(e => e.LeadCompliance).HasColumnName("Lead_Compliance");

                entity.Property(e => e.QaCompliance).HasColumnName("QA_Compliance");

                entity.Property(e => e.ScrumMasterCompliance).HasColumnName("ScrumMaster_Compliance");

                entity.HasOne(d => d.ModifiedBy)
                    .WithMany(p => p.AgileData)
                    .HasForeignKey(d => d.ModifiedById)
                    .HasConstraintName("Fk_AgileDataModified");

                entity.HasOne(d => d.Project)
                    .WithMany(p => p.AgileData)
                    .HasForeignKey(d => d.ProjectId)
                    .HasConstraintName("FK__AgileData__Proje__628FA481");

                entity.HasOne(d => d.Sow)
                    .WithMany(p => p.AgileData)
                    .HasForeignKey(d => d.SowId)
                    .HasConstraintName("FK__AgileData__SowId__6383C8BA");
            });

            modelBuilder.Entity<Artefact>(entity =>
            {
                entity.Property(e => e.DisplayName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.FileName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.FilePath)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.FileSize)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.LastModifiedOn).HasColumnType("datetime");

                entity.HasOne(d => d.ModifiedBy)
                    .WithMany(p => p.Artefacts)
                    .HasForeignKey(d => d.ModifiedById)
                    .HasConstraintName("Fk_ArtefactsModified");

                entity.HasOne(d => d.Question)
                    .WithMany(p => p.Artefacts)
                    .HasForeignKey(d => d.QuestionId)
                    .HasConstraintName("Fk_ArtefactsModified1");
            });

            modelBuilder.Entity<CommentType>(entity =>
            {
                entity.ToTable("CommentType");

                entity.Property(e => e.CommentType1)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("CommentType");

                entity.Property(e => e.LastModifiedOn).HasColumnType("datetime");

                entity.HasOne(d => d.ModifiedBy)
                    .WithMany(p => p.CommentTypes)
                    .HasForeignKey(d => d.ModifiedById)
                    .HasConstraintName("Fk_CommentTypeModified");
            });

            modelBuilder.Entity<ComplianceProject>(entity =>
            {
                entity.ToTable("ComplianceProject");

                entity.Property(e => e.LastModifiedOn).HasColumnType("datetime");

                entity.HasOne(d => d.ComplianceType)
                    .WithMany(p => p.ComplianceProjects)
                    .HasForeignKey(d => d.ComplianceTypeId)
                    .HasConstraintName("FK__Complianc__Compl__68487DD7");

                entity.HasOne(d => d.ModifiedBy)
                    .WithMany(p => p.ComplianceProjects)
                    .HasForeignKey(d => d.ModifiedById)
                    .HasConstraintName("Fk_ComplianceProjectModified");

                entity.HasOne(d => d.Project)
                    .WithMany(p => p.ComplianceProjects)
                    .HasForeignKey(d => d.ProjectId)
                    .HasConstraintName("FK__Complianc__Proje__693CA210");

                entity.HasOne(d => d.Sow)
                    .WithMany(p => p.ComplianceProjects)
                    .HasForeignKey(d => d.SowId)
                    .HasConstraintName("FK__Complianc__SowId__6A30C649");

                entity.HasOne(d => d.Stage)
                    .WithMany(p => p.ComplianceProjects)
                    .HasForeignKey(d => d.StageId)
                    .HasConstraintName("FK__Complianc__Stage__6B24EA82");
            });

            modelBuilder.Entity<ComplianceStatus>(entity =>
            {
                entity.ToTable("ComplianceStatus");

                entity.Property(e => e.ComplianceStatus1)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ComplianceStatus");

                entity.Property(e => e.LastModifiedOn).HasColumnType("datetime");

                entity.HasOne(d => d.ModifiedBy)
                    .WithMany(p => p.ComplianceStatuses)
                    .HasForeignKey(d => d.ModifiedById)
                    .HasConstraintName("Fk_ComplianceStatusModified");
            });

            modelBuilder.Entity<Models.ComplianceType>(entity =>
            {
                entity.Property(e => e.ComplianceTypeName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.LastModifiedOn).HasColumnType("datetime");

                entity.Property(e => e.TypeDescription)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.HasOne(d => d.ModifiedBy)
                    .WithMany(p => p.ComplianceTypes)
                    .HasForeignKey(d => d.ModifiedById)
                    .HasConstraintName("Fk_ComplianceTypesModified");
            });

            modelBuilder.Entity<Currency>(entity =>
            {
                entity.ToTable("Currency");

                entity.Property(e => e.CurrencyName)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Description)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.LastModifiedOn).HasColumnType("datetime");

                entity.HasOne(d => d.ModifiedBy)
                    .WithMany(p => p.Currencies)
                    .HasForeignKey(d => d.ModifiedById)
                    .HasConstraintName("Fk_CurrencyModified");
            });

            modelBuilder.Entity<Department>(entity =>
            {
                entity.Property(e => e.DepartmentName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Description)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.LastModifiedOn).HasColumnType("datetime");

                entity.HasOne(d => d.ModifiedBy)
                    .WithMany(p => p.Departments)
                    .HasForeignKey(d => d.ModifiedById)
                    .HasConstraintName("Fk_DepartmentsModified");
            });

            modelBuilder.Entity<Employee>(entity =>
            {
                entity.Property(e => e.FirstName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.HireDate).HasColumnType("date");

                entity.Property(e => e.LastModifiedOn).HasColumnType("datetime");

                entity.Property(e => e.LastName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.PhoneNumber)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.HasOne(d => d.Department)
                    .WithMany(p => p.Employees)
                    .HasForeignKey(d => d.DepartmentId)
                    .HasConstraintName("FK__Employees__Depar__778AC167");

                entity.HasOne(d => d.ModifiedBy)
                    .WithMany(p => p.InverseModifiedBy)
                    .HasForeignKey(d => d.ModifiedById)
                    .HasConstraintName("Fk_EmployeesModified");
            });

            modelBuilder.Entity<EmployeeProjectAllocation>(entity =>
            {
                entity.HasKey(e => e.EmployeeProjectAllocationsId)
                    .HasName("PK__Employee__8785983F79881D29");

                entity.Property(e => e.Billability).HasColumnType("decimal(3, 2)");

                entity.Property(e => e.EndDate).HasColumnType("date");

                entity.Property(e => e.LastModifiedOn).HasColumnType("datetime");

                entity.Property(e => e.StartDate).HasColumnType("date");

                entity.HasOne(d => d.Employee)
                    .WithMany(p => p.EmployeeProjectAllocationEmployees)
                    .HasForeignKey(d => d.EmployeeId)
                    .HasConstraintName("FK__EmployeeP__Emplo__70DDC3D8");

                entity.HasOne(d => d.ModifiedBy)
                    .WithMany(p => p.EmployeeProjectAllocationModifiedBies)
                    .HasForeignKey(d => d.ModifiedById)
                    .HasConstraintName("Fk_ProjectAllocationsModified");

                entity.HasOne(d => d.Project)
                    .WithMany(p => p.EmployeeProjectAllocations)
                    .HasForeignKey(d => d.ProjectId)
                    .HasConstraintName("FK__EmployeeP__Proje__71D1E811");

                entity.HasOne(d => d.Sow)
                    .WithMany(p => p.EmployeeProjectAllocations)
                    .HasForeignKey(d => d.SowId)
                    .HasConstraintName("FK__EmployeeP__SowId__72C60C4A");
            });

            modelBuilder.Entity<EmployeeRoleAssignment>(entity =>
            {
                entity.HasKey(e => e.EmployeeRoleMapId)
                    .HasName("PK__Employee__C74F74579E2D5BF9");

                entity.ToTable("EmployeeRoleAssignment");

                entity.Property(e => e.EndDate).HasColumnType("date");

                entity.Property(e => e.LastModifiedOn).HasColumnType("datetime");

                entity.Property(e => e.StartDate).HasColumnType("date");

                entity.HasOne(d => d.Employee)
                    .WithMany(p => p.EmployeeRoleAssignmentEmployees)
                    .HasForeignKey(d => d.EmployeeId)
                    .HasConstraintName("FK__EmployeeR__Emplo__74AE54BC");

                entity.HasOne(d => d.ModifiedBy)
                    .WithMany(p => p.EmployeeRoleAssignmentModifiedBies)
                    .HasForeignKey(d => d.ModifiedById)
                    .HasConstraintName("Fk_EmployeeRoleAssignmentModified");

                entity.HasOne(d => d.Role)
                    .WithMany(p => p.EmployeeRoleAssignments)
                    .HasForeignKey(d => d.RoleId)
                    .HasConstraintName("FK__EmployeeR__RoleI__75A278F5");
            });

            modelBuilder.Entity<EmployeeSkillAssignment>(entity =>
            {
                entity.HasKey(e => e.EmployeeSkillAssignmentMapId)
                    .HasName("PK__Employee__49C2D3BBAAABC565");

                entity.ToTable("EmployeeSkillAssignment");

                entity.Property(e => e.LastModifiedOn).HasColumnType("datetime");

                entity.HasOne(d => d.Employee)
                    .WithMany(p => p.EmployeeSkillAssignmentEmployees)
                    .HasForeignKey(d => d.EmployeeId)
                    .HasConstraintName("FK__EmployeeS__Emplo__797309D9");

                entity.HasOne(d => d.ModifiedBy)
                    .WithMany(p => p.EmployeeSkillAssignmentModifiedBies)
                    .HasForeignKey(d => d.ModifiedById)
                    .HasConstraintName("Fk_EmployeeSkillAssignmentModified");

                entity.HasOne(d => d.Skill)
                    .WithMany(p => p.EmployeeSkillAssignments)
                    .HasForeignKey(d => d.SkillId)
                    .HasConstraintName("FK__EmployeeS__Skill__7A672E12");

                entity.HasOne(d => d.SkillType)
                    .WithMany(p => p.EmployeeSkillAssignments)
                    .HasForeignKey(d => d.SkillTypeId)
                    .HasConstraintName("FK__EmployeeS__Skill__7B5B524B");
            });

            modelBuilder.Entity<Opportunity>(entity =>
            {
                entity.ToTable("Opportunity");

                entity.Property(e => e.LastModifiedOn).HasColumnType("datetime");

                entity.HasOne(d => d.ModifiedBy)
                    .WithMany(p => p.Opportunities)
                    .HasForeignKey(d => d.ModifiedById)
                    .HasConstraintName("Fk_OpportunityModified");
            });

            modelBuilder.Entity<Project>(entity =>
            {
                entity.Property(e => e.EndDate).HasColumnType("date");

                entity.Property(e => e.LastModifiedOn).HasColumnType("datetime");

                entity.Property(e => e.ProjectDescription)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ProjectName)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ProjectType)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.StartDate).HasColumnType("date");

                entity.HasOne(d => d.Account)
                    .WithMany(p => p.Projects)
                    .HasForeignKey(d => d.AccountId)
                    .HasConstraintName("FK__Projects__Accoun__02FC7413");

                entity.HasOne(d => d.ModifiedBy)
                    .WithMany(p => p.Projects)
                    .HasForeignKey(d => d.ModifiedById)
                    .HasConstraintName("Fk_ProjectsModified");
            });

            modelBuilder.Entity<ProjectManagerMap>(entity =>
            {
                entity.HasKey(e => e.ProjectManagerId)
                    .HasName("PK__ProjectM__35F0311166D4078E");

                entity.ToTable("ProjectManagerMap");

                entity.Property(e => e.EndDate).HasColumnType("datetime");

                entity.Property(e => e.LastModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.StartDate).HasColumnType("datetime");

                entity.HasOne(d => d.AccountManager)
                    .WithMany(p => p.ProjectManagerMapAccountManagers)
                    .HasForeignKey(d => d.AccountManagerId)
                    .HasConstraintName("FK__ProjectMa__Accou__7E37BEF6");

                entity.HasOne(d => d.Manager)
                    .WithMany(p => p.ProjectManagerMapManagers)
                    .HasForeignKey(d => d.ManagerId)
                    .HasConstraintName("FK__ProjectMa__Manag__7F2BE32F");

                entity.HasOne(d => d.ModifiedBy)
                    .WithMany(p => p.ProjectManagerMapModifiedBies)
                    .HasForeignKey(d => d.ModifiedById)
                    .HasConstraintName("Fk_ProjectManagerMapModified");

                entity.HasOne(d => d.Project)
                    .WithMany(p => p.ProjectManagerMaps)
                    .HasForeignKey(d => d.ProjectId)
                    .HasConstraintName("FK__ProjectMa__Proje__00200768");

                entity.HasOne(d => d.Sow)
                    .WithMany(p => p.ProjectManagerMaps)
                    .HasForeignKey(d => d.SowId)
                    .HasConstraintName("FK__ProjectMa__SowId__01142BA1");
            });

            modelBuilder.Entity<Question>(entity =>
            {
                entity.Property(e => e.LastModifiedOn).HasColumnType("datetime");

                entity.Property(e => e.QuestionWeightage)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Questions)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.HasOne(d => d.ModifiedBy)
                    .WithMany(p => p.Questions)
                    .HasForeignKey(d => d.ModifiedById)
                    .HasConstraintName("Fk_QuestionsModified");
            });

            modelBuilder.Entity<QuestionCategoryMap>(entity =>
            {
                entity.ToTable("QuestionCategoryMap");

                entity.Property(e => e.LastModifiedOn).HasColumnType("datetime");

                entity.HasOne(d => d.ComplianceType)
                    .WithMany(p => p.QuestionCategoryMaps)
                    .HasForeignKey(d => d.ComplianceTypeId)
                    .HasConstraintName("FK__QuestionC__Compl__04E4BC85");

                entity.HasOne(d => d.ModifiedBy)
                    .WithMany(p => p.QuestionCategoryMaps)
                    .HasForeignKey(d => d.ModifiedById)
                    .HasConstraintName("Fk_QuestionCategoryMapModified");

                entity.HasOne(d => d.Question)
                    .WithMany(p => p.QuestionCategoryMaps)
                    .HasForeignKey(d => d.QuestionId)
                    .HasConstraintName("FK__QuestionC__Quest__05D8E0BE");

                entity.HasOne(d => d.Role)
                    .WithMany(p => p.QuestionCategoryMaps)
                    .HasForeignKey(d => d.RoleId)
                    .HasConstraintName("FK__QuestionC__RoleI__06CD04F7");
            });

            modelBuilder.Entity<QuestionsCompliance>(entity =>
            {
                entity.ToTable("QuestionsCompliance");

                entity.Property(e => e.LastModifiedOn).HasColumnType("datetime");

                entity.Property(e => e.ModifiedBy)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.HasOne(d => d.ComplianceType)
                    .WithMany(p => p.QuestionsCompliances)
                    .HasForeignKey(d => d.ComplianceTypeId)
                    .HasConstraintName("FK__Questions__Compl__09A971A2");

                entity.HasOne(d => d.Question)
                    .WithMany(p => p.QuestionsCompliances)
                    .HasForeignKey(d => d.QuestionId)
                    .HasConstraintName("FK__Questions__Quest__0A9D95DB");
            });

            modelBuilder.Entity<Role>(entity =>
            {
                entity.Property(e => e.Description)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.LastModifiedOn).HasColumnType("datetime");

                entity.Property(e => e.RoleName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.HasOne(d => d.ModifiedBy)
                    .WithMany(p => p.Roles)
                    .HasForeignKey(d => d.ModifiedById)
                    .HasConstraintName("Fk_RolesModified");
            });

            modelBuilder.Entity<RoleComplianceType>(entity =>
            {
                entity.ToTable("RoleComplianceType");

                entity.Property(e => e.LastModifiedOn).HasColumnType("datetime");

                entity.HasOne(d => d.ComplianceType)
                    .WithMany(p => p.RoleComplianceTypes)
                    .HasForeignKey(d => d.ComplianceTypeId)
                    .HasConstraintName("FK__RoleCompl__Compl__0B91BA14");

                entity.HasOne(d => d.ModifiedBy)
                    .WithMany(p => p.RoleComplianceTypes)
                    .HasForeignKey(d => d.ModifiedById)
                    .HasConstraintName("Fk_RoleComplianceTypeModified");

                entity.HasOne(d => d.Role)
                    .WithMany(p => p.RoleComplianceTypes)
                    .HasForeignKey(d => d.RoleId)
                    .HasConstraintName("FK__RoleCompl__RoleI__0C85DE4D");
            });

            modelBuilder.Entity<Skill>(entity =>
            {
                entity.Property(e => e.LastModifiedOn).HasColumnType("datetime");

                entity.Property(e => e.SkillName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.HasOne(d => d.ModifiedBy)
                    .WithMany(p => p.Skills)
                    .HasForeignKey(d => d.ModifiedById)
                    .HasConstraintName("Fk_SkillsModified");
            });

            modelBuilder.Entity<SkillType>(entity =>
            {
                entity.Property(e => e.LastModifiedOn).HasColumnType("datetime");

                entity.Property(e => e.SkillTypeName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.HasOne(d => d.ModifiedBy)
                    .WithMany(p => p.SkillTypes)
                    .HasForeignKey(d => d.ModifiedById)
                    .HasConstraintName("Fk_SkillTypesModified");
            });

            modelBuilder.Entity<Sow>(entity =>
            {
                entity.Property(e => e.EndDate).HasColumnType("date");

                entity.Property(e => e.EngagementWeeks)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LastModifiedOn).HasColumnType("datetime");

                entity.Property(e => e.SowAmount).HasMaxLength(10);

                entity.Property(e => e.SowName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.StartDate).HasColumnType("date");

                entity.HasOne(d => d.Currency)
                    .WithMany(p => p.Sows)
                    .HasForeignKey(d => d.CurrencyId)
                    .HasConstraintName("FK__Sows__CurrencyId__1AD3FDA4");

                entity.HasOne(d => d.ModifiedBy)
                    .WithMany(p => p.Sows)
                    .HasForeignKey(d => d.ModifiedById)
                    .HasConstraintName("Fk_SowsModified");

                entity.HasOne(d => d.Opportunity)
                    .WithMany(p => p.Sows)
                    .HasForeignKey(d => d.OpportunityId)
                    .HasConstraintName("FK__Sows__Opportunit__1BC821DD");

                entity.HasOne(d => d.Project)
                    .WithMany(p => p.Sows)
                    .HasForeignKey(d => d.ProjectId)
                    .HasConstraintName("FK__Sows__ProjectId__1CBC4616");
            });

            modelBuilder.Entity<SowkickstartQuestionResponse>(entity =>
            {
                entity.ToTable("SOWKickstartQuestionResponse");

                entity.Property(e => e.SowkickstartQuestionResponseId).HasColumnName("SOWKickstartQuestionResponseId");

                entity.Property(e => e.Comments)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.LastModifiedOn).HasColumnType("datetime");

                entity.HasOne(d => d.Account)
                    .WithMany(p => p.SowkickstartQuestionResponses)
                    .HasForeignKey(d => d.AccountId)
                    .HasConstraintName("FK__SOWKickst__Accou__114A936A");

                entity.HasOne(d => d.Artefact)
                    .WithMany(p => p.SowkickstartQuestionResponses)
                    .HasForeignKey(d => d.ArtefactId)
                    .HasConstraintName("FK__SOWKickst__Artef__123EB7A3");

                entity.HasOne(d => d.CommentsType)
                    .WithMany(p => p.SowkickstartQuestionResponses)
                    .HasForeignKey(d => d.CommentsTypeId)
                    .HasConstraintName("FK__SOWKickst__Comme__1332DBDC");

                entity.HasOne(d => d.ComplianceStatus)
                    .WithMany(p => p.SowkickstartQuestionResponses)
                    .HasForeignKey(d => d.ComplianceStatusId)
                    .HasConstraintName("FK__SOWKickst__Compl__151B244E");

                entity.HasOne(d => d.ComplianceType)
                    .WithMany(p => p.SowkickstartQuestionResponses)
                    .HasForeignKey(d => d.ComplianceTypeId)
                    .HasConstraintName("FK__SOWKickst__Compl__14270015");

                entity.HasOne(d => d.ModifiedBy)
                    .WithMany(p => p.SowkickstartQuestionResponses)
                    .HasForeignKey(d => d.ModifiedById)
                    .HasConstraintName("Fk_SOWKickstartQuestionResponseModified");

                entity.HasOne(d => d.Project)
                    .WithMany(p => p.SowkickstartQuestionResponses)
                    .HasForeignKey(d => d.ProjectId)
                    .HasConstraintName("FK__SOWKickst__Proje__160F4887");

                entity.HasOne(d => d.Question)
                    .WithMany(p => p.SowkickstartQuestionResponses)
                    .HasForeignKey(d => d.QuestionId)
                    .HasConstraintName("FK__SOWKickst__Quest__17036CC0");

                entity.HasOne(d => d.Sow)
                    .WithMany(p => p.SowkickstartQuestionResponses)
                    .HasForeignKey(d => d.SowId)
                    .HasConstraintName("FK__SOWKickst__SowId__17F790F9");

                entity.HasOne(d => d.Stage)
                    .WithMany(p => p.SowkickstartQuestionResponses)
                    .HasForeignKey(d => d.StageId)
                    .HasConstraintName("FK__SOWKickst__Stage__18EBB532");
            });

            modelBuilder.Entity<Sprint>(entity =>
            {
                entity.Property(e => e.EndDate).HasColumnType("date");

                entity.Property(e => e.LastModifiedOn).HasColumnType("datetime");

                entity.Property(e => e.SprintName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.StartDate).HasColumnType("date");

                entity.HasOne(d => d.ModifiedBy)
                    .WithMany(p => p.Sprints)
                    .HasForeignKey(d => d.ModifiedById)
                    .HasConstraintName("Fk_SprintsModified");

                entity.HasOne(d => d.Project)
                    .WithMany(p => p.Sprints)
                    .HasForeignKey(d => d.ProjectId)
                    .HasConstraintName("FK__Sprints__Project__2B0A656D");

                entity.HasOne(d => d.Sow)
                    .WithMany(p => p.Sprints)
                    .HasForeignKey(d => d.SowId)
                    .HasConstraintName("FK__Sprints__SowId__2BFE89A6");
            });

            modelBuilder.Entity<SprintDetail>(entity =>
            {
                entity.Property(e => e.LastModifiedOn).HasColumnType("datetime");

                entity.Property(e => e.UsCompleted).HasColumnName("US_Completed");

                entity.Property(e => e.UsPlannedAtCompletion).HasColumnName("US_PlannedAtCompletion");

                entity.Property(e => e.UsPlannedAtStart).HasColumnName("US_PlannedAtStart");

                entity.HasOne(d => d.ModifiedBy)
                    .WithMany(p => p.SprintDetails)
                    .HasForeignKey(d => d.ModifiedById)
                    .HasConstraintName("Fk_SprintDetailsModified");

                entity.HasOne(d => d.Sprint)
                    .WithMany(p => p.SprintDetails)
                    .HasForeignKey(d => d.SprintId)
                    .HasConstraintName("FK__SprintDet__Sprin__1EA48E88");
            });

            modelBuilder.Entity<SprintQuestionResponse>(entity =>
            {
                entity.ToTable("SprintQuestionResponse");

                entity.Property(e => e.Comments)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ComplianceTypeId).HasColumnName("ComplianceTypeID");

                entity.Property(e => e.LastModifiedOn).HasColumnType("datetime");

                entity.Property(e => e.ModifiedById).HasColumnName("ModifiedByID");

                entity.Property(e => e.SprintId).HasColumnName("SprintID");

                entity.HasOne(d => d.Account)
                    .WithMany(p => p.SprintQuestionResponses)
                    .HasForeignKey(d => d.AccountId)
                    .HasConstraintName("FK__SprintQue__Accou__208CD6FA");

                entity.HasOne(d => d.Artefact)
                    .WithMany(p => p.SprintQuestionResponses)
                    .HasForeignKey(d => d.ArtefactId)
                    .HasConstraintName("FK__SprintQue__Artef__2180FB33");

                entity.HasOne(d => d.CommentsType)
                    .WithMany(p => p.SprintQuestionResponses)
                    .HasForeignKey(d => d.CommentsTypeId)
                    .HasConstraintName("FK__SprintQue__Comme__22751F6C");

                entity.HasOne(d => d.ComplianceStatus)
                    .WithMany(p => p.SprintQuestionResponses)
                    .HasForeignKey(d => d.ComplianceStatusId)
                    .HasConstraintName("FK__SprintQue__Compl__245D67DE");

                entity.HasOne(d => d.ComplianceType)
                    .WithMany(p => p.SprintQuestionResponses)
                    .HasForeignKey(d => d.ComplianceTypeId)
                    .HasConstraintName("FK__SprintQue__Compl__236943A5");

                entity.HasOne(d => d.ModifiedBy)
                    .WithMany(p => p.SprintQuestionResponses)
                    .HasForeignKey(d => d.ModifiedById)
                    .HasConstraintName("FK__SprintQue__Modif__25518C17");

                entity.HasOne(d => d.Project)
                    .WithMany(p => p.SprintQuestionResponses)
                    .HasForeignKey(d => d.ProjectId)
                    .HasConstraintName("FK__SprintQue__Proje__2645B050");

                entity.HasOne(d => d.Question)
                    .WithMany(p => p.SprintQuestionResponses)
                    .HasForeignKey(d => d.QuestionId)
                    .HasConstraintName("FK__SprintQue__Quest__2739D489");

                entity.HasOne(d => d.Sow)
                    .WithMany(p => p.SprintQuestionResponses)
                    .HasForeignKey(d => d.SowId)
                    .HasConstraintName("FK__SprintQue__SowId__282DF8C2");

                entity.HasOne(d => d.Sprint)
                    .WithMany(p => p.SprintQuestionResponses)
                    .HasForeignKey(d => d.SprintId)
                    .HasConstraintName("FK__SprintQue__Sprin__29221CFB");

                entity.HasOne(d => d.Stage)
                    .WithMany(p => p.SprintQuestionResponses)
                    .HasForeignKey(d => d.StageId)
                    .HasConstraintName("FK__SprintQue__Stage__2A164134");
            });

            modelBuilder.Entity<SprintScore>(entity =>
            {
                entity.Property(e => e.LastModifiedOn).HasColumnType("datetime");

                entity.HasOne(d => d.ModifiedBy)
                    .WithMany(p => p.SprintScores)
                    .HasForeignKey(d => d.ModifiedById)
                    .HasConstraintName("Fk_SprintScoresModified");

                entity.HasOne(d => d.Project)
                    .WithMany(p => p.SprintScores)
                    .HasForeignKey(d => d.ProjectId)
                    .HasConstraintName("FK__SprintSco__Proje__2DE6D218");

                entity.HasOne(d => d.Sprint)
                    .WithMany(p => p.SprintScores)
                    .HasForeignKey(d => d.SprintId)
                    .HasConstraintName("FK__SprintSco__Sprin__2EDAF651");

                entity.HasOne(d => d.Variance)
                    .WithMany(p => p.SprintScores)
                    .HasForeignKey(d => d.VarianceId)
                    .HasConstraintName("FK__SprintSco__Varia__2FCF1A8A");
            });

            modelBuilder.Entity<Models.Stage>(entity =>
            {
                entity.Property(e => e.Description)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.LastModifiedOn).HasColumnType("datetime");

                entity.Property(e => e.StageName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.HasOne(d => d.ModifiedBy)
                    .WithMany(p => p.Stages)
                    .HasForeignKey(d => d.ModifiedById)
                    .HasConstraintName("Fk_StagesModified");
            });

            modelBuilder.Entity<StageComplianceType>(entity =>
            {
                entity.ToTable("StageComplianceType");

                entity.Property(e => e.LastModifiedOn).HasColumnType("datetime");

                entity.HasOne(d => d.ComplianceType)
                    .WithMany(p => p.StageComplianceTypes)
                    .HasForeignKey(d => d.ComplianceTypeId)
                    .HasConstraintName("FK__StageComp__Compl__31B762FC");

                entity.HasOne(d => d.ModifiedBy)
                    .WithMany(p => p.StageComplianceTypes)
                    .HasForeignKey(d => d.ModifiedById)
                    .HasConstraintName("Fk_ComplianceStageModified");

                entity.HasOne(d => d.Stage)
                    .WithMany(p => p.StageComplianceTypes)
                    .HasForeignKey(d => d.StageId)
                    .HasConstraintName("FK__StageComp__Stage__32AB8735");
            });

            modelBuilder.Entity<StageDatum>(entity =>
            {
                entity.HasKey(e => e.StageId)
                    .HasName("PK__StageDat__03EB7AD812806C7A");

                entity.Property(e => e.LastModifiedOn).HasColumnType("datetime");

                entity.Property(e => e._1ProjectKickStart).HasColumnName("1.Project KickStart");

                entity.Property(e => e._2Design).HasColumnName("2.Design");

                entity.Property(e => e._3Agile).HasColumnName("3.Agile");

                entity.Property(e => e._4Closure).HasColumnName("4.Closure");

                entity.HasOne(d => d.ModifiedBy)
                    .WithMany(p => p.StageData)
                    .HasForeignKey(d => d.ModifiedById)
                    .HasConstraintName("Fk_StageDataModified");

                entity.HasOne(d => d.Project)
                    .WithMany(p => p.StageData)
                    .HasForeignKey(d => d.ProjectId)
                    .HasConstraintName("FK__StageData__Proje__3493CFA7");

                entity.HasOne(d => d.Sow)
                    .WithMany(p => p.StageData)
                    .HasForeignKey(d => d.SowId)
                    .HasConstraintName("FK__StageData__SowId__3587F3E0");
            });

            modelBuilder.Entity<Variance>(entity =>
            {
                entity.Property(e => e.VarianceId).HasColumnName("VarianceID");

                entity.Property(e => e.Description)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.LastModifiedOn).HasColumnType("datetime");

                entity.HasOne(d => d.ModifiedBy)
                    .WithMany(p => p.Variances)
                    .HasForeignKey(d => d.ModifiedById)
                    .HasConstraintName("Fk_VariancesModified");
            });

          //  OnModelCreatingPartial(modelBuilder);
        }

       // partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
