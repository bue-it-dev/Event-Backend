using System;
using Event.Models.HrmModels;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Pomelo.EntityFrameworkCore.MySql.Scaffolding.Internal;

namespace Event.Models;

public partial class HrmDBContext : DbContext
{
    public HrmDBContext()
    {
    }

    public HrmDBContext(DbContextOptions<HrmDBContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Badgedepartmentrange> Badgedepartmentranges { get; set; }

    public virtual DbSet<BueAttAttendance> BueAttAttendances { get; set; }

    public virtual DbSet<BueAttAttendance2> BueAttAttendance2s { get; set; }

    public virtual DbSet<BueAttProcessHistory> BueAttProcessHistories { get; set; }

    public virtual DbSet<BueCreatedEmail> BueCreatedEmails { get; set; }

    public virtual DbSet<BueEmpAttRestriction> BueEmpAttRestrictions { get; set; }

    public virtual DbSet<BueEmpDepartment> BueEmpDepartments { get; set; }

    public virtual DbSet<BueEmpEducation> BueEmpEducations { get; set; }

    public virtual DbSet<BueEmpEducationLevel> BueEmpEducationLevels { get; set; }

    public virtual DbSet<BueEmpEmpEducation> BueEmpEmpEducations { get; set; }

    public virtual DbSet<BueEmpEmpEducationTmp> BueEmpEmpEducationTmps { get; set; }

    public virtual DbSet<BueEmpEmpLang> BueEmpEmpLangs { get; set; }

    public virtual DbSet<BueEmpEmpLangTmp> BueEmpEmpLangTmps { get; set; }

    public virtual DbSet<BueEmpEmpSalary> BueEmpEmpSalaries { get; set; }

    public virtual DbSet<BueEmpEmpSkill> BueEmpEmpSkills { get; set; }

    public virtual DbSet<BueEmpEmpSkillsTmp> BueEmpEmpSkillsTmps { get; set; }

    public virtual DbSet<BueEmpEmpWorkExperience> BueEmpEmpWorkExperiences { get; set; }

    public virtual DbSet<BueEmpEmpWorkExperienceTmp> BueEmpEmpWorkExperienceTmps { get; set; }

    public virtual DbSet<BueEmpEmployee> BueEmpEmployees { get; set; }

    public virtual DbSet<BueEmpEmployeeTmp> BueEmpEmployeeTmps { get; set; }

    public virtual DbSet<BueEmpLanguage> BueEmpLanguages { get; set; }

    public virtual DbSet<BueEmpNote> BueEmpNotes { get; set; }

    public virtual DbSet<BueEmpOvertimePolicy> BueEmpOvertimePolicies { get; set; }

    public virtual DbSet<BueEmpReportTo> BueEmpReportTos { get; set; }

    public virtual DbSet<BueEmpSalary> BueEmpSalaries { get; set; }

    public virtual DbSet<BueEmpSalaryFrequency> BueEmpSalaryFrequencies { get; set; }

    public virtual DbSet<BueEmpSkill> BueEmpSkills { get; set; }

    public virtual DbSet<BueEmpStatus> BueEmpStatuses { get; set; }

    public virtual DbSet<BueEmpType> BueEmpTypes { get; set; }

    public virtual DbSet<BueEmpWorkExperience> BueEmpWorkExperiences { get; set; }

    public virtual DbSet<BueEvaCompetency> BueEvaCompetencies { get; set; }

    public virtual DbSet<BueEvaEmpScore> BueEvaEmpScores { get; set; }

    public virtual DbSet<BueEvaEq> BueEvaEqs { get; set; }

    public virtual DbSet<BueEvaObjective> BueEvaObjectives { get; set; }

    public virtual DbSet<BueEvaTitle> BueEvaTitles { get; set; }

    public virtual DbSet<BueEvaTotalScore> BueEvaTotalScores { get; set; }

    public virtual DbSet<BueEvaTotalScoreObjective> BueEvaTotalScoreObjectives { get; set; }

    public virtual DbSet<BueEvaTrainig> BueEvaTrainigs { get; set; }

    public virtual DbSet<BueJobsAndTitle> BueJobsAndTitles { get; set; }

    public virtual DbSet<BueLeaveCopy> BueLeaveCopies { get; set; }

    public virtual DbSet<BueLeaveDepApproval> BueLeaveDepApprovals { get; set; }

    public virtual DbSet<BueLeaveEmpLeaveType> BueLeaveEmpLeaveTypes { get; set; }

    public virtual DbSet<BueLeaveEmpLeaveTypeHistory> BueLeaveEmpLeaveTypeHistories { get; set; }

    public virtual DbSet<BueLeaveEmpLeaveTypeHistoryDocument> BueLeaveEmpLeaveTypeHistoryDocuments { get; set; }

    public virtual DbSet<BueLeaveEmpLeaveTypeHistoryStatus> BueLeaveEmpLeaveTypeHistoryStatuses { get; set; }

    public virtual DbSet<BueLeaveLeaveType> BueLeaveLeaveTypes { get; set; }

    public virtual DbSet<BueLeaveStatus> BueLeaveStatuses { get; set; }

    public virtual DbSet<BueMchBuilding> BueMchBuildings { get; set; }

    public virtual DbSet<BueMchMachine> BueMchMachines { get; set; }

    public virtual DbSet<BuePolAttRestriction> BuePolAttRestrictions { get; set; }

    public virtual DbSet<BuePolEmpOfficialHoliday> BuePolEmpOfficialHolidays { get; set; }

    public virtual DbSet<BuePolEmpPenalty> BuePolEmpPenalties { get; set; }

    public virtual DbSet<BuePolEmpPermit> BuePolEmpPermits { get; set; }

    public virtual DbSet<BuePolEmpWorkingDay> BuePolEmpWorkingDays { get; set; }

    public virtual DbSet<BuePolEmpWorkingDayMaternity> BuePolEmpWorkingDayMaternities { get; set; }

    public virtual DbSet<BuePolEmpWorkingDayResearch> BuePolEmpWorkingDayResearches { get; set; }

    public virtual DbSet<BuePolOfficialHoliday> BuePolOfficialHolidays { get; set; }

    public virtual DbSet<BuePolOvertime> BuePolOvertimes { get; set; }

    public virtual DbSet<BuePolPenalty> BuePolPenalties { get; set; }

    public virtual DbSet<BuePolPermit> BuePolPermits { get; set; }

    public virtual DbSet<BuePolPermitPenalty> BuePolPermitPenalties { get; set; }

    public virtual DbSet<BuePolShift> BuePolShifts { get; set; }

    public virtual DbSet<BuePolWorkingDay> BuePolWorkingDays { get; set; }

    public virtual DbSet<BueResource> BueResources { get; set; }

    public virtual DbSet<BueUpdateDataEmp> BueUpdateDataEmps { get; set; }

    public virtual DbSet<BueUser> BueUsers { get; set; }

    public virtual DbSet<BueUserActivityLink> BueUserActivityLinks { get; set; }

    public virtual DbSet<BueUserActivityLog> BueUserActivityLogs { get; set; }

    public virtual DbSet<BueUserRole> BueUserRoles { get; set; }

    public virtual DbSet<BueUserRoleResource> BueUserRoleResources { get; set; }

    public virtual DbSet<BueViolationHistory> BueViolationHistories { get; set; }

    public virtual DbSet<Buecarinforole> Buecarinforoles { get; set; }

    public virtual DbSet<Buecarinfouser> Buecarinfousers { get; set; }

    public virtual DbSet<CarEntryLog> CarEntryLogs { get; set; }

    public virtual DbSet<Carstatuslookup> Carstatuslookups { get; set; }

    public virtual DbSet<EmpChangedCategory> EmpChangedCategories { get; set; }

    public virtual DbSet<EmpTraining> EmpTrainings { get; set; }

    public virtual DbSet<EmpTrainingCourse> EmpTrainingCourses { get; set; }

    public virtual DbSet<Issuedbuecarinfo> Issuedbuecarinfos { get; set; }

    public virtual DbSet<MachineApiLog> MachineApiLogs { get; set; }

    public virtual DbSet<Migration> Migrations { get; set; }

    public virtual DbSet<NewLeaveApproval> NewLeaveApprovals { get; set; }

    public virtual DbSet<ObjectiveEdit> ObjectiveEdits { get; set; }

    public virtual DbSet<ObjectiveEditHistory> ObjectiveEditHistories { get; set; }

    public virtual DbSet<Pendingbuecarinfo> Pendingbuecarinfos { get; set; }

    public virtual DbSet<Pendingbuecarinfoarchive> Pendingbuecarinfoarchives { get; set; }

    public virtual DbSet<RefundedHistory> RefundedHistories { get; set; }

    public virtual DbSet<Researchday> Researchdays { get; set; }

    public virtual DbSet<SrsApiLog> SrsApiLogs { get; set; }

    public virtual DbSet<UpdatedFaculty> UpdatedFaculties { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseMySql("server=192.168.0.88;database=buehrm_19_01_2023;user=HCMS@2021;password=74IdAQXOpYrD6pMh;treattinyasboolean=true", Microsoft.EntityFrameworkCore.ServerVersion.Parse("8.0.19-mysql"));

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder
            .UseCollation("utf8_unicode_ci")
            .HasCharSet("utf8");

        modelBuilder.Entity<Badgedepartmentrange>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("badgedepartmentrange");

            entity.Property(e => e.DepbadgeId).HasColumnName("depbadgeID");
            entity.Property(e => e.DepbadgeName)
                .HasMaxLength(255)
                .HasColumnName("depbadgeName");
            entity.Property(e => e.RangeFrom).HasColumnName("rangeFrom");
            entity.Property(e => e.RangeTo).HasColumnName("rangeTo");
        });

        modelBuilder.Entity<BueAttAttendance>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("bue_att_attendance");

            entity.HasIndex(e => e.CardNumber, "card_number");

            entity.HasIndex(e => e.Date, "date");

            entity.HasIndex(e => e.EmpId, "emp_id");

            entity.HasIndex(e => e.Processed, "processed");

            entity.HasIndex(e => e.PunchDate, "punch_date");

            entity.HasIndex(e => e.PunchInOut, "punch_in_out");

            entity.HasIndex(e => e.PunchInOutManualByUser, "punch_in_out_manual_by_user");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.CalculateAsAbsence)
                .HasDefaultValueSql("'0'")
                .HasColumnName("calculateAsAbsence");
            entity.Property(e => e.CardNumber).HasColumnName("card_number");
            entity.Property(e => e.Date).HasColumnName("date");
            entity.Property(e => e.EffectiveWorkingHours)
                .HasColumnType("time")
                .HasColumnName("effective_working_hours");
            entity.Property(e => e.EmpId).HasColumnName("emp_id");
            entity.Property(e => e.MachineId).HasColumnName("machine_id");
            entity.Property(e => e.OvertimeMorningHours)
                .HasColumnType("time")
                .HasColumnName("overtime_morning_hours");
            entity.Property(e => e.OvertimeNightHours)
                .HasColumnType("time")
                .HasColumnName("overtime_night_hours");
            entity.Property(e => e.Processed).HasColumnName("processed");
            entity.Property(e => e.PunchDate)
                .HasColumnType("datetime")
                .HasColumnName("punch_date");
            entity.Property(e => e.PunchInNote)
                .HasMaxLength(255)
                .HasColumnName("punch_in_note")
                .UseCollation("latin1_swedish_ci")
                .HasCharSet("latin1");
            entity.Property(e => e.PunchInOut)
                .HasColumnType("enum('in','out')")
                .HasColumnName("punch_in_out")
                .UseCollation("latin1_swedish_ci")
                .HasCharSet("latin1");
            entity.Property(e => e.PunchInOutManualByUser).HasColumnName("punch_in_out_manual_by_user");
            entity.Property(e => e.PunchOutNote)
                .HasMaxLength(255)
                .HasColumnName("punch_out_note")
                .UseCollation("latin1_swedish_ci")
                .HasCharSet("latin1");
            entity.Property(e => e.Time)
                .HasColumnType("time")
                .HasColumnName("time");
            entity.Property(e => e.VerifyMode)
                .HasColumnType("enum('finger','card')")
                .HasColumnName("verify_mode")
                .UseCollation("latin1_swedish_ci")
                .HasCharSet("latin1");
            entity.Property(e => e.WorkingHours)
                .HasColumnType("time")
                .HasColumnName("working_hours");
        });

        modelBuilder.Entity<BueAttAttendance2>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("bue_att_attendance2");

            entity.HasIndex(e => e.CardNumber, "card_number");

            entity.HasIndex(e => e.Date, "date");

            entity.HasIndex(e => e.EmpId, "emp_id");

            entity.HasIndex(e => e.Processed, "processed");

            entity.HasIndex(e => e.PunchDate, "punch_date");

            entity.HasIndex(e => e.PunchInOut, "punch_in_out");

            entity.HasIndex(e => e.PunchInOutManualByUser, "punch_in_out_manual_by_user");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.CalculateAsAbsence)
                .HasDefaultValueSql("'0'")
                .HasColumnName("calculateAsAbsence");
            entity.Property(e => e.CardNumber).HasColumnName("card_number");
            entity.Property(e => e.Date).HasColumnName("date");
            entity.Property(e => e.EffectiveWorkingHours)
                .HasColumnType("time")
                .HasColumnName("effective_working_hours");
            entity.Property(e => e.EmpId).HasColumnName("emp_id");
            entity.Property(e => e.MachineId).HasColumnName("machine_id");
            entity.Property(e => e.OvertimeMorningHours)
                .HasColumnType("time")
                .HasColumnName("overtime_morning_hours");
            entity.Property(e => e.OvertimeNightHours)
                .HasColumnType("time")
                .HasColumnName("overtime_night_hours");
            entity.Property(e => e.Processed).HasColumnName("processed");
            entity.Property(e => e.PunchDate)
                .HasColumnType("datetime")
                .HasColumnName("punch_date");
            entity.Property(e => e.PunchInNote)
                .HasMaxLength(255)
                .HasColumnName("punch_in_note")
                .UseCollation("latin1_swedish_ci")
                .HasCharSet("latin1");
            entity.Property(e => e.PunchInOut)
                .HasColumnType("enum('in','out')")
                .HasColumnName("punch_in_out")
                .UseCollation("latin1_swedish_ci")
                .HasCharSet("latin1");
            entity.Property(e => e.PunchInOutManualByUser).HasColumnName("punch_in_out_manual_by_user");
            entity.Property(e => e.PunchOutNote)
                .HasMaxLength(255)
                .HasColumnName("punch_out_note")
                .UseCollation("latin1_swedish_ci")
                .HasCharSet("latin1");
            entity.Property(e => e.Time)
                .HasColumnType("time")
                .HasColumnName("time");
            entity.Property(e => e.VerifyMode)
                .HasColumnType("enum('finger','card')")
                .HasColumnName("verify_mode")
                .UseCollation("latin1_swedish_ci")
                .HasCharSet("latin1");
            entity.Property(e => e.WorkingHours)
                .HasColumnType("time")
                .HasColumnName("working_hours");

            entity.HasOne(d => d.Emp).WithMany(p => p.BueAttAttendance2s)
                .HasForeignKey(d => d.EmpId)
                .HasConstraintName("bue_att_attendance2_ibfk_1");
        });

        modelBuilder.Entity<BueAttProcessHistory>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("bue_att_process_history")
                .UseCollation("utf8_general_ci");

            entity.HasIndex(e => e.UserId, "user_id");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Comment)
                .HasColumnType("text")
                .HasColumnName("comment");
            entity.Property(e => e.ProcessDateTime)
                .HasColumnType("datetime")
                .HasColumnName("process_date_time");
            entity.Property(e => e.UserId).HasColumnName("user_id");
        });

        modelBuilder.Entity<BueCreatedEmail>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("bue_created_emails");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.CreatedAt)
                .HasDefaultValueSql("CURRENT_TIMESTAMP")
                .HasColumnType("datetime")
                .HasColumnName("created_at");
            entity.Property(e => e.Email)
                .HasMaxLength(255)
                .HasDefaultValueSql("''")
                .HasColumnName("email");
            entity.Property(e => e.EmpId).HasColumnName("emp_id");
            entity.Property(e => e.FirstName)
                .HasMaxLength(255)
                .HasDefaultValueSql("''")
                .HasColumnName("first_name");
            entity.Property(e => e.LastName)
                .HasMaxLength(255)
                .HasDefaultValueSql("''")
                .HasColumnName("last_name");
            entity.Property(e => e.Password)
                .HasMaxLength(255)
                .HasDefaultValueSql("''")
                .HasColumnName("password");
            entity.Property(e => e.Path)
                .HasMaxLength(255)
                .HasDefaultValueSql("''")
                .HasColumnName("path");
        });

        modelBuilder.Entity<BueEmpAttRestriction>(entity =>
        {
            entity.HasKey(e => new { e.EmpId, e.PolicyId, e.StartDate })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0, 0 });

            entity
                .ToTable("bue_emp_att_restrictions")
                .HasCharSet("utf32")
                .UseCollation("utf32_general_ci");

            entity.HasIndex(e => e.PolicyId, "policy_id");

            entity.Property(e => e.EmpId).HasColumnName("emp_id");
            entity.Property(e => e.PolicyId).HasColumnName("policy_id");
            entity.Property(e => e.StartDate)
                .HasMaxLength(15)
                .HasColumnName("start_date");
            entity.Property(e => e.EndDate).HasColumnName("end_date");
        });

        modelBuilder.Entity<BueEmpDepartment>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("bue_emp_departments")
                .HasCharSet("latin1")
                .UseCollation("latin1_swedish_ci");

            entity.HasIndex(e => e.ParentDepartment, "parent_department");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.DepartmentName)
                .HasMaxLength(100)
                .HasColumnName("department_name");
            entity.Property(e => e.ParentDepartment).HasColumnName("parent_department");
        });

        modelBuilder.Entity<BueEmpEducation>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("bue_emp_education")
                .HasCharSet("latin1")
                .UseCollation("latin1_swedish_ci");

            entity.HasIndex(e => e.Level, "level");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Level).HasColumnName("level");
            entity.Property(e => e.MajorSpecification)
                .HasMaxLength(200)
                .HasColumnName("major_specification");
            entity.Property(e => e.MinorSpecification)
                .HasMaxLength(200)
                .HasColumnName("minor_specification");
            entity.Property(e => e.University)
                .HasMaxLength(200)
                .HasColumnName("university");
        });

        modelBuilder.Entity<BueEmpEducationLevel>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("bue_emp_education_level")
                .HasCharSet("latin1")
                .UseCollation("latin1_swedish_ci");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.LevelName)
                .HasMaxLength(200)
                .HasColumnName("level_name");
        });

        modelBuilder.Entity<BueEmpEmpEducation>(entity =>
        {
            entity.HasKey(e => new { e.EmpId, e.EducationId })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

            entity
                .ToTable("bue_emp_emp_education")
                .HasCharSet("latin1")
                .UseCollation("latin1_swedish_ci");

            entity.HasIndex(e => e.EducationId, "education_id");

            entity.HasIndex(e => e.EmpId, "emp_id");

            entity.Property(e => e.EmpId).HasColumnName("emp_id");
            entity.Property(e => e.EducationId).HasColumnName("education_id");
            entity.Property(e => e.EndDate).HasColumnName("end_date");
            entity.Property(e => e.GpaScore)
                .HasMaxLength(20)
                .HasColumnName("gpa_score");
            entity.Property(e => e.StartDate).HasColumnName("start_date");
            entity.Property(e => e.Year).HasColumnName("year");
        });

        modelBuilder.Entity<BueEmpEmpEducationTmp>(entity =>
        {
            entity.HasKey(e => new { e.EmpId2, e.EducationId })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

            entity
                .ToTable("bue_emp_emp_education_tmp")
                .HasCharSet("latin1")
                .UseCollation("latin1_swedish_ci");

            entity.HasIndex(e => e.EducationId, "education_id");

            entity.HasIndex(e => e.EmpId2, "emp_id2");

            entity.Property(e => e.EmpId2).HasColumnName("emp_id2");
            entity.Property(e => e.EducationId).HasColumnName("education_id");
            entity.Property(e => e.EndDate).HasColumnName("end_date");
            entity.Property(e => e.GpaScore)
                .HasMaxLength(200)
                .HasColumnName("gpa_score");
            entity.Property(e => e.StartDate).HasColumnName("start_date");
            entity.Property(e => e.Year).HasColumnName("year");
        });

        modelBuilder.Entity<BueEmpEmpLang>(entity =>
        {
            entity.HasKey(e => new { e.EmpId, e.LanguageId, e.Fluency })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0, 0 });

            entity
                .ToTable("bue_emp_emp_lang")
                .HasCharSet("latin1")
                .UseCollation("latin1_swedish_ci");

            entity.HasIndex(e => e.EmpId, "emp_id");

            entity.HasIndex(e => e.LanguageId, "language_id");

            entity.Property(e => e.EmpId).HasColumnName("emp_id");
            entity.Property(e => e.LanguageId).HasColumnName("language_id");
            entity.Property(e => e.Fluency)
                .HasDefaultValueSql("'writing'")
                .HasColumnType("enum('writing','speaking','reading')")
                .HasColumnName("fluency");
            entity.Property(e => e.Competency)
                .HasColumnType("enum('poor','basic','good','mother tongue')")
                .HasColumnName("competency");
        });

        modelBuilder.Entity<BueEmpEmpLangTmp>(entity =>
        {
            entity.HasKey(e => new { e.EmpId2, e.LanguageId, e.Competency })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0, 0 });

            entity
                .ToTable("bue_emp_emp_lang_tmp")
                .HasCharSet("latin1")
                .UseCollation("latin1_swedish_ci");

            entity.HasIndex(e => e.EmpId2, "emp_id2");

            entity.HasIndex(e => e.LanguageId, "language_id");

            entity.Property(e => e.EmpId2).HasColumnName("emp_id2");
            entity.Property(e => e.LanguageId).HasColumnName("language_id");
            entity.Property(e => e.Competency)
                .HasDefaultValueSql("'writing'")
                .HasColumnType("enum('writing','speaking','reading')")
                .HasColumnName("competency");
            entity.Property(e => e.Fluency)
                .HasColumnType("enum('poor','good','very good','fluent','mother tongue')")
                .HasColumnName("fluency");
        });

        modelBuilder.Entity<BueEmpEmpSalary>(entity =>
        {
            entity.HasKey(e => new { e.EmpId, e.SalaryId })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

            entity
                .ToTable("bue_emp_emp_salary")
                .HasCharSet("latin1")
                .UseCollation("latin1_swedish_ci");

            entity.HasIndex(e => e.EmpId, "emp_id");

            entity.HasIndex(e => e.SalaryId, "salary_id");

            entity.Property(e => e.EmpId).HasColumnName("emp_id");
            entity.Property(e => e.SalaryId).HasColumnName("salary_id");
        });

        modelBuilder.Entity<BueEmpEmpSkill>(entity =>
        {
            entity.HasKey(e => new { e.EmpId, e.SkillId })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

            entity
                .ToTable("bue_emp_emp_skills")
                .HasCharSet("latin1")
                .UseCollation("latin1_swedish_ci");

            entity.HasIndex(e => e.EmpId, "emp_id");

            entity.HasIndex(e => e.SkillId, "skill_id");

            entity.Property(e => e.EmpId).HasColumnName("emp_id");
            entity.Property(e => e.SkillId).HasColumnName("skill_id");
            entity.Property(e => e.YearsOfExperience).HasColumnName("years_of_experience");
        });

        modelBuilder.Entity<BueEmpEmpSkillsTmp>(entity =>
        {
            entity.HasKey(e => new { e.EmpId2, e.SkillId })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

            entity
                .ToTable("bue_emp_emp_skills_tmp")
                .HasCharSet("latin1")
                .UseCollation("latin1_swedish_ci");

            entity.HasIndex(e => e.EmpId2, "emp_id2");

            entity.HasIndex(e => e.SkillId, "skill_id");

            entity.Property(e => e.EmpId2).HasColumnName("emp_id2");
            entity.Property(e => e.SkillId).HasColumnName("skill_id");
            entity.Property(e => e.LevelOfExperience)
                .HasColumnType("enum('beginner','intermediate','expert')")
                .HasColumnName("level_of_experience");
        });

        modelBuilder.Entity<BueEmpEmpWorkExperience>(entity =>
        {
            entity.HasKey(e => new { e.EmpId, e.WorkExperienceId, e.DateFrom })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0, 0 });

            entity
                .ToTable("bue_emp_emp_work_experience")
                .HasCharSet("latin1")
                .UseCollation("latin1_swedish_ci");

            entity.HasIndex(e => e.EmpId, "emp_id");

            entity.HasIndex(e => e.WorkExperienceId, "work_experience_id");

            entity.Property(e => e.EmpId).HasColumnName("emp_id");
            entity.Property(e => e.WorkExperienceId).HasColumnName("work_experience_id");
            entity.Property(e => e.DateFrom)
                .HasMaxLength(50)
                .HasColumnName("date_from");
            entity.Property(e => e.DateTo).HasColumnName("date_to");
            entity.Property(e => e.Salary).HasColumnName("salary");
        });

        modelBuilder.Entity<BueEmpEmpWorkExperienceTmp>(entity =>
        {
            entity.HasKey(e => new { e.EmpId2, e.WorkExperienceId, e.DateFrom })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0, 0 });

            entity
                .ToTable("bue_emp_emp_work_experience_tmp")
                .HasCharSet("latin1")
                .UseCollation("latin1_swedish_ci");

            entity.HasIndex(e => e.EmpId2, "emp_id2");

            entity.HasIndex(e => e.WorkExperienceId, "work_experience_id");

            entity.Property(e => e.EmpId2).HasColumnName("emp_id2");
            entity.Property(e => e.WorkExperienceId).HasColumnName("work_experience_id");
            entity.Property(e => e.DateFrom)
                .HasMaxLength(50)
                .HasColumnName("date_from");
            entity.Property(e => e.DateTo).HasColumnName("date_to");
            entity.Property(e => e.Position)
                .HasMaxLength(200)
                .HasColumnName("position");
            entity.Property(e => e.Salary).HasColumnName("salary");
        });

        modelBuilder.Entity<BueEmpEmployee>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("bue_emp_employee")
                .UseCollation("utf8_general_ci");

            entity.HasIndex(e => e.CardNumber, "card_number").IsUnique();

            entity.HasIndex(e => e.DepartmentId, "department_id");

            entity.HasIndex(e => e.DirectManagerId, "direct_manager_id");

            entity.HasIndex(e => e.EmpTypeId, "emp_type_id");

            entity.HasIndex(e => e.JobId, "job_id");

            entity.HasIndex(e => e.OvertimeId, "overtime_id");

            entity.HasIndex(e => e.PolAttRestriction, "pol_att_restriction");

            entity.HasIndex(e => e.StatusId, "status_id");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.AddCity)
                .HasColumnType("text")
                .HasColumnName("add_city")
                .UseCollation("latin1_swedish_ci")
                .HasCharSet("latin1");
            entity.Property(e => e.AddCountry)
                .HasColumnType("text")
                .HasColumnName("add_country")
                .UseCollation("latin1_swedish_ci")
                .HasCharSet("latin1");
            entity.Property(e => e.AddStateProvince)
                .HasColumnType("text")
                .HasColumnName("add_state_province")
                .UseCollation("latin1_swedish_ci")
                .HasCharSet("latin1");
            entity.Property(e => e.AddStreet)
                .HasColumnType("text")
                .HasColumnName("add_street")
                .UseCollation("latin1_swedish_ci")
                .HasCharSet("latin1");
            entity.Property(e => e.AddZipPostalCode)
                .HasColumnType("text")
                .HasColumnName("add_zip_postal_code");
            entity.Property(e => e.BankAccountNumber)
                .HasMaxLength(100)
                .HasColumnName("bank_account_number");
            entity.Property(e => e.CardNumber).HasColumnName("card_number");
            entity.Property(e => e.Category).HasColumnName("category");
            entity.Property(e => e.Code)
                .HasMaxLength(10)
                .HasColumnName("code")
                .UseCollation("latin1_swedish_ci")
                .HasCharSet("latin1");
            entity.Property(e => e.ConsecutiveViolationCounter).HasColumnName("consecutiveViolationCounter");
            entity.Property(e => e.ContractEndDate).HasColumnName("contract_end_date");
            entity.Property(e => e.ContractFile)
                .HasMaxLength(100)
                .HasColumnName("contract_file")
                .UseCollation("latin1_swedish_ci")
                .HasCharSet("latin1");
            entity.Property(e => e.ContractStartDate).HasColumnName("contract_start_date");
            entity.Property(e => e.DateOfBirth).HasColumnName("date_of_birth");
            entity.Property(e => e.DepartmentId).HasColumnName("department_id");
            entity.Property(e => e.DirectManagerId).HasColumnName("direct_manager_id");
            entity.Property(e => e.DrivingLicenceExpiryDate).HasColumnName("driving_licence_expiry_date");
            entity.Property(e => e.DrivingLicenceNumber)
                .HasColumnType("text")
                .HasColumnName("driving_licence_number");
            entity.Property(e => e.EmpTypeId).HasColumnName("emp_type_id");
            entity.Property(e => e.Fname)
                .HasMaxLength(100)
                .HasColumnName("fname")
                .UseCollation("latin1_swedish_ci")
                .HasCharSet("latin1");
            entity.Property(e => e.Gender)
                .HasColumnType("enum('male','female')")
                .HasColumnName("gender")
                .UseCollation("latin1_swedish_ci")
                .HasCharSet("latin1");
            entity.Property(e => e.HasAttendance)
                .HasDefaultValueSql("'1'")
                .HasColumnName("has_attendance");
            entity.Property(e => e.HomePhone)
                .HasMaxLength(20)
                .HasColumnName("home_phone")
                .UseCollation("latin1_swedish_ci")
                .HasCharSet("latin1");
            entity.Property(e => e.IdNumber)
                .HasMaxLength(30)
                .HasColumnName("id_number")
                .UseCollation("latin1_swedish_ci")
                .HasCharSet("latin1");
            entity.Property(e => e.Image)
                .HasMaxLength(100)
                .HasColumnName("image")
                .UseCollation("latin1_swedish_ci")
                .HasCharSet("latin1");
            entity.Property(e => e.IsConsecutive).HasColumnName("isConsecutive");
            entity.Property(e => e.IsManager).HasColumnName("is_manager");
            entity.Property(e => e.JobId).HasColumnName("job_id");
            entity.Property(e => e.JobJointDate).HasColumnName("job_joint_date");
            entity.Property(e => e.Lname)
                .HasMaxLength(100)
                .HasColumnName("lname")
                .UseCollation("latin1_swedish_ci")
                .HasCharSet("latin1");
            entity.Property(e => e.MaritalStatus)
                .HasMaxLength(30)
                .HasColumnName("marital_status")
                .UseCollation("latin1_swedish_ci")
                .HasCharSet("latin1");
            entity.Property(e => e.Mname)
                .HasMaxLength(100)
                .HasColumnName("mname")
                .UseCollation("latin1_swedish_ci")
                .HasCharSet("latin1");
            entity.Property(e => e.MobilePhone)
                .HasMaxLength(20)
                .HasColumnName("mobile_phone")
                .UseCollation("latin1_swedish_ci")
                .HasCharSet("latin1");
            entity.Property(e => e.Nationality)
                .HasMaxLength(30)
                .HasColumnName("nationality")
                .UseCollation("latin1_swedish_ci")
                .HasCharSet("latin1");
            entity.Property(e => e.OtherEmail)
                .HasMaxLength(50)
                .HasColumnName("other_email")
                .UseCollation("latin1_swedish_ci")
                .HasCharSet("latin1");
            entity.Property(e => e.OvertimeId).HasColumnName("overtime_id");
            entity.Property(e => e.PolAttRestriction).HasColumnName("pol_att_restriction");
            entity.Property(e => e.Religion)
                .HasMaxLength(20)
                .HasColumnName("religion")
                .UseCollation("latin1_swedish_ci")
                .HasCharSet("latin1");
            entity.Property(e => e.ResignationDate).HasColumnName("resignation_date");
            entity.Property(e => e.SalaryAmount).HasColumnName("salary_amount");
            entity.Property(e => e.StatusId).HasColumnName("status_id");
            entity.Property(e => e.ViolationCounter).HasColumnName("violationCounter");
            entity.Property(e => e.WorkEmail)
                .HasMaxLength(50)
                .HasColumnName("work_email")
                .UseCollation("latin1_swedish_ci")
                .HasCharSet("latin1");
            entity.Property(e => e.WorkPhone)
                .HasMaxLength(20)
                .HasColumnName("work_phone")
                .UseCollation("latin1_swedish_ci")
                .HasCharSet("latin1");
        });

        modelBuilder.Entity<BueEmpEmployeeTmp>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("bue_emp_employee_tmp")
                .UseCollation("utf8_general_ci");

            entity.HasIndex(e => e.CardNumber, "card_number").IsUnique();

            entity.HasIndex(e => e.DepartmentId, "department_id");

            entity.HasIndex(e => e.EmpTypeId, "emp_type_id");

            entity.HasIndex(e => e.JobId, "job_id");

            entity.HasIndex(e => e.StatusId, "status_id");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.AddCity)
                .HasColumnType("text")
                .HasColumnName("add_city")
                .UseCollation("latin1_swedish_ci")
                .HasCharSet("latin1");
            entity.Property(e => e.AddCity2)
                .HasColumnType("text")
                .HasColumnName("add_city2")
                .UseCollation("latin1_swedish_ci")
                .HasCharSet("latin1");
            entity.Property(e => e.AddCountry)
                .HasColumnType("text")
                .HasColumnName("add_country")
                .UseCollation("latin1_swedish_ci")
                .HasCharSet("latin1");
            entity.Property(e => e.AddCountry2)
                .HasColumnType("text")
                .HasColumnName("add_country2")
                .UseCollation("latin1_swedish_ci")
                .HasCharSet("latin1");
            entity.Property(e => e.AddStateProvince)
                .HasColumnType("text")
                .HasColumnName("add_state_province")
                .UseCollation("latin1_swedish_ci")
                .HasCharSet("latin1");
            entity.Property(e => e.AddStateProvince2)
                .HasColumnType("text")
                .HasColumnName("add_state_province2")
                .UseCollation("latin1_swedish_ci")
                .HasCharSet("latin1");
            entity.Property(e => e.AddStreet)
                .HasColumnType("text")
                .HasColumnName("add_street")
                .UseCollation("latin1_swedish_ci")
                .HasCharSet("latin1");
            entity.Property(e => e.AddStreet2)
                .HasColumnType("text")
                .HasColumnName("add_street2")
                .UseCollation("latin1_swedish_ci")
                .HasCharSet("latin1");
            entity.Property(e => e.AddZipPostalCode).HasColumnName("add_zip_postal_code");
            entity.Property(e => e.AddZipPostalCode2).HasColumnName("add_zip_postal_code2");
            entity.Property(e => e.BankAccountNumber)
                .HasMaxLength(100)
                .HasColumnName("bank_account_number");
            entity.Property(e => e.CardNumber).HasColumnName("card_number");
            entity.Property(e => e.Code)
                .HasMaxLength(10)
                .HasColumnName("code")
                .UseCollation("latin1_swedish_ci")
                .HasCharSet("latin1");
            entity.Property(e => e.ContractEndDate).HasColumnName("contract_end_date");
            entity.Property(e => e.ContractFile)
                .HasMaxLength(100)
                .HasColumnName("contract_file")
                .UseCollation("latin1_swedish_ci")
                .HasCharSet("latin1");
            entity.Property(e => e.ContractStartDate).HasColumnName("contract_start_date");
            entity.Property(e => e.Cv)
                .HasColumnType("text")
                .HasColumnName("cv");
            entity.Property(e => e.DateOfBirth).HasColumnName("date_of_birth");
            entity.Property(e => e.DepartmentId).HasColumnName("department_id");
            entity.Property(e => e.DrivingLicenceExpiryDate).HasColumnName("driving_licence_expiry_date");
            entity.Property(e => e.DrivingLicenceNumber)
                .HasColumnType("text")
                .HasColumnName("driving_licence_number");
            entity.Property(e => e.EmpTypeId).HasColumnName("emp_type_id");
            entity.Property(e => e.Fname)
                .HasMaxLength(100)
                .HasColumnName("fname")
                .UseCollation("latin1_swedish_ci")
                .HasCharSet("latin1");
            entity.Property(e => e.FnameArabic)
                .HasMaxLength(100)
                .HasColumnName("fname_arabic");
            entity.Property(e => e.Gender)
                .HasColumnType("enum('male','female')")
                .HasColumnName("gender")
                .UseCollation("latin1_swedish_ci")
                .HasCharSet("latin1");
            entity.Property(e => e.HomePhone)
                .HasMaxLength(50)
                .HasColumnName("home_phone")
                .UseCollation("latin1_swedish_ci")
                .HasCharSet("latin1");
            entity.Property(e => e.IdExpiryDate).HasColumnName("id_expiry_date");
            entity.Property(e => e.IdNumber)
                .HasMaxLength(30)
                .HasColumnName("id_number")
                .UseCollation("latin1_swedish_ci")
                .HasCharSet("latin1");
            entity.Property(e => e.Image)
                .HasMaxLength(100)
                .HasColumnName("image")
                .UseCollation("latin1_swedish_ci")
                .HasCharSet("latin1");
            entity.Property(e => e.JobId).HasColumnName("job_id");
            entity.Property(e => e.JobJointDate).HasColumnName("job_joint_date");
            entity.Property(e => e.Lname)
                .HasMaxLength(100)
                .HasColumnName("lname")
                .UseCollation("latin1_swedish_ci")
                .HasCharSet("latin1");
            entity.Property(e => e.LnameArabic)
                .HasMaxLength(100)
                .HasColumnName("lname_arabic");
            entity.Property(e => e.MaritalStatus)
                .HasMaxLength(50)
                .HasColumnName("marital_status")
                .UseCollation("latin1_swedish_ci")
                .HasCharSet("latin1");
            entity.Property(e => e.MilitaryService)
                .HasColumnType("enum('exempted','exempted_temporary','undetermined','completed')")
                .HasColumnName("military_service")
                .UseCollation("latin1_swedish_ci")
                .HasCharSet("latin1");
            entity.Property(e => e.Mname)
                .HasMaxLength(100)
                .HasColumnName("mname")
                .UseCollation("latin1_swedish_ci")
                .HasCharSet("latin1");
            entity.Property(e => e.MnameArabic)
                .HasMaxLength(100)
                .HasColumnName("mname_arabic");
            entity.Property(e => e.MobilePhone)
                .HasMaxLength(50)
                .HasColumnName("mobile_phone")
                .UseCollation("latin1_swedish_ci")
                .HasCharSet("latin1");
            entity.Property(e => e.Nationality)
                .HasMaxLength(50)
                .HasColumnName("nationality")
                .UseCollation("latin1_swedish_ci")
                .HasCharSet("latin1");
            entity.Property(e => e.OtherEmail)
                .HasMaxLength(50)
                .HasColumnName("other_email")
                .UseCollation("latin1_swedish_ci")
                .HasCharSet("latin1");
            entity.Property(e => e.Religion)
                .HasMaxLength(50)
                .HasColumnName("religion")
                .UseCollation("latin1_swedish_ci")
                .HasCharSet("latin1");
            entity.Property(e => e.StatusId).HasColumnName("status_id");
            entity.Property(e => e.WorkEmail)
                .HasMaxLength(50)
                .HasColumnName("work_email")
                .UseCollation("latin1_swedish_ci")
                .HasCharSet("latin1");
            entity.Property(e => e.WorkPhone)
                .HasMaxLength(50)
                .HasColumnName("work_phone")
                .UseCollation("latin1_swedish_ci")
                .HasCharSet("latin1");
        });

        modelBuilder.Entity<BueEmpLanguage>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("bue_emp_languages")
                .HasCharSet("latin1")
                .UseCollation("latin1_swedish_ci");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.LanguageName)
                .HasMaxLength(50)
                .HasColumnName("language_name");
        });

        modelBuilder.Entity<BueEmpNote>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("bue_emp_note")
                .UseCollation("utf8_general_ci");

            entity.HasIndex(e => e.Emp, "emp_id");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Date).HasColumnName("date");
            entity.Property(e => e.Emp).HasColumnName("emp");
            entity.Property(e => e.Note)
                .HasColumnType("text")
                .HasColumnName("note");
        });

        modelBuilder.Entity<BueEmpOvertimePolicy>(entity =>
        {
            entity.HasKey(e => new { e.EmpId, e.PolicyId, e.StartDate })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0, 0 });

            entity
                .ToTable("bue_emp_overtime_policy")
                .HasCharSet("utf32")
                .UseCollation("utf32_general_ci");

            entity.HasIndex(e => e.PolicyId, "policy_id");

            entity.Property(e => e.EmpId).HasColumnName("emp_id");
            entity.Property(e => e.PolicyId).HasColumnName("policy_id");
            entity.Property(e => e.StartDate)
                .HasMaxLength(15)
                .HasColumnName("start_date");
            entity.Property(e => e.EndDate).HasColumnName("end_date");
        });

        modelBuilder.Entity<BueEmpReportTo>(entity =>
        {
            entity.HasKey(e => new { e.EmpId, e.EmpReportedToId })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

            entity
                .ToTable("bue_emp_report_to")
                .HasCharSet("latin1")
                .UseCollation("latin1_swedish_ci");

            entity.HasIndex(e => e.EmpId, "emp_id");

            entity.HasIndex(e => e.EmpReportedToId, "emp_reported_to_id");

            entity.Property(e => e.EmpId).HasColumnName("emp_id");
            entity.Property(e => e.EmpReportedToId).HasColumnName("emp_reported_to_id");
        });

        modelBuilder.Entity<BueEmpSalary>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("bue_emp_salary")
                .HasCharSet("latin1")
                .UseCollation("latin1_swedish_ci");

            entity.HasIndex(e => e.PayFrequencyId, "pay_frequency_id");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Currency)
                .HasMaxLength(50)
                .HasColumnName("currency");
            entity.Property(e => e.PayFrequencyId).HasColumnName("pay_frequency_id");
        });

        modelBuilder.Entity<BueEmpSalaryFrequency>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("bue_emp_salary_frequency")
                .HasCharSet("latin1")
                .UseCollation("latin1_swedish_ci");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.DurationInHours).HasColumnName("duration_in_hours");
            entity.Property(e => e.FrequencyName)
                .HasMaxLength(50)
                .HasColumnName("frequency_name");
        });

        modelBuilder.Entity<BueEmpSkill>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("bue_emp_skills")
                .HasCharSet("latin1")
                .UseCollation("latin1_swedish_ci");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.SkillName)
                .HasMaxLength(100)
                .HasColumnName("skill_name");
        });

        modelBuilder.Entity<BueEmpStatus>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("bue_emp_status")
                .HasCharSet("latin1")
                .UseCollation("latin1_swedish_ci");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.State)
                .HasMaxLength(50)
                .HasColumnName("state");
        });

        modelBuilder.Entity<BueEmpType>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("bue_emp_types")
                .HasCharSet("latin1")
                .UseCollation("latin1_swedish_ci");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Type)
                .HasMaxLength(50)
                .HasColumnName("type");
        });

        modelBuilder.Entity<BueEmpWorkExperience>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("bue_emp_work_experience")
                .HasCharSet("latin1")
                .UseCollation("latin1_swedish_ci");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Company)
                .HasMaxLength(100)
                .HasColumnName("company");
        });

        modelBuilder.Entity<BueEvaCompetency>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("bue_eva_competency")
                .UseCollation("utf8_general_ci");

            entity.HasIndex(e => e.TitleId, "title_id");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Description)
                .HasMaxLength(250)
                .HasColumnName("description");
            entity.Property(e => e.Name)
                .HasMaxLength(250)
                .HasColumnName("name");
            entity.Property(e => e.TitleId).HasColumnName("title_id");
            entity.Property(e => e.Weight).HasColumnName("weight");
        });

        modelBuilder.Entity<BueEvaEmpScore>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("bue_eva_emp_score")
                .UseCollation("utf8_general_ci");

            entity.HasIndex(e => e.EmpId, "emp_id");

            entity.HasIndex(e => e.EqId, "job_title_id");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.EmpId).HasColumnName("emp_id");
            entity.Property(e => e.EqId).HasColumnName("eq_id");
            entity.Property(e => e.Evidence)
                .HasMaxLength(5000)
                .HasColumnName("evidence");
            entity.Property(e => e.Score).HasColumnName("score");
        });

        modelBuilder.Entity<BueEvaEq>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("bue_eva_eq")
                .UseCollation("utf8_general_ci");

            entity.HasIndex(e => e.CompetencyId, "competency_id");

            entity.HasIndex(e => new { e.TitleId, e.CompetencyId }, "title_id");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.CompetencyId).HasColumnName("competency_id");
            entity.Property(e => e.Eq)
                .HasMaxLength(255)
                .HasColumnName("eq");
            entity.Property(e => e.TitleId).HasColumnName("title_id");
        });

        modelBuilder.Entity<BueEvaObjective>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("bue_eva_objective")
                .UseCollation("utf8_general_ci");

            entity.HasIndex(e => e.EmpId, "emp_id");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Confirm).HasColumnName("confirm");
            entity.Property(e => e.Dimension)
                .HasMaxLength(2500)
                .HasColumnName("dimension");
            entity.Property(e => e.EmpId).HasColumnName("emp_id");
            entity.Property(e => e.ExpectedResult)
                .HasMaxLength(2500)
                .HasColumnName("expected_result");
            entity.Property(e => e.GrantedMarks).HasColumnName("granted_marks");
            entity.Property(e => e.KeyPerformance)
                .HasMaxLength(2500)
                .HasColumnName("key_performance");
            entity.Property(e => e.ObjectiveName)
                .HasMaxLength(250)
                .HasColumnName("objective_name");
            entity.Property(e => e.PercentageAchievement).HasColumnName("percentage_achievement");
            entity.Property(e => e.Score).HasColumnName("score");
            entity.Property(e => e.Weight).HasColumnName("weight");
            entity.Property(e => e.Year).HasColumnName("year");
        });

        modelBuilder.Entity<BueEvaTitle>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("bue_eva_title")
                .UseCollation("utf8_general_ci");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.JobTitle)
                .HasMaxLength(500)
                .HasColumnName("job_title");
        });

        modelBuilder.Entity<BueEvaTotalScore>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("bue_eva_total_score")
                .UseCollation("utf8_general_ci");

            entity.HasIndex(e => e.EmpId, "emp_id");

            entity.HasIndex(e => e.TypeId, "type_id");

            entity.HasIndex(e => new { e.UserId, e.TypeId }, "user_id");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Date).HasColumnName("date");
            entity.Property(e => e.Delet).HasColumnName("delet");
            entity.Property(e => e.EmpId).HasColumnName("emp_id");
            entity.Property(e => e.Time)
                .HasDefaultValueSql("'00:00:00'")
                .HasColumnType("time")
                .HasColumnName("time");
            entity.Property(e => e.TotalScore).HasColumnName("total_score");
            entity.Property(e => e.TypeId).HasColumnName("type_id");
            entity.Property(e => e.UserId).HasColumnName("user_id");
        });

        modelBuilder.Entity<BueEvaTotalScoreObjective>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("bue_eva_total_score_objective")
                .UseCollation("utf8_general_ci");

            entity.HasIndex(e => e.EmpId, "bue_eva_total_score_objective_ibfk_1");

            entity.HasIndex(e => e.UserId, "bue_eva_total_score_objective_ibfk_2");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Date).HasColumnName("date");
            entity.Property(e => e.EmpId).HasColumnName("emp_id");
            entity.Property(e => e.Time)
                .HasDefaultValueSql("'00:00:00'")
                .HasColumnType("time")
                .HasColumnName("time");
            entity.Property(e => e.TotalScore).HasColumnName("total_score");
            entity.Property(e => e.UserId).HasColumnName("user_id");
        });

        modelBuilder.Entity<BueEvaTrainig>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("bue_eva_trainig")
                .UseCollation("utf8_general_ci");

            entity.HasIndex(e => e.EmpId, "emp_id");

            entity.HasIndex(e => e.UserId, "user_id");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.ComName)
                .HasMaxLength(250)
                .HasColumnName("com_name");
            entity.Property(e => e.EmpId).HasColumnName("emp_id");
            entity.Property(e => e.EndDate).HasColumnName("end_date");
            entity.Property(e => e.Score).HasColumnName("score");
            entity.Property(e => e.StartDate).HasColumnName("start_date");
            entity.Property(e => e.TrainigNeeds)
                .HasMaxLength(5000)
                .HasColumnName("trainig_needs");
            entity.Property(e => e.UserId).HasColumnName("user_id");
        });

        modelBuilder.Entity<BueJobsAndTitle>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("bue_jobs_and_titles")
                .HasCharSet("latin1")
                .UseCollation("latin1_swedish_ci");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.JobTitle)
                .HasMaxLength(50)
                .HasColumnName("job_title");
            entity.Property(e => e.Specification)
                .HasColumnType("text")
                .HasColumnName("specification");
        });

        modelBuilder.Entity<BueLeaveCopy>(entity =>
        {
            entity.HasKey(e => e.Increment).HasName("PRIMARY");

            entity
                .ToTable("bue_leave_copy")
                .HasCharSet("latin1")
                .UseCollation("latin1_swedish_ci");

            entity.HasIndex(e => e.EmpId, "emp_id");

            entity.HasIndex(e => e.FinalStatus, "final_status");

            entity.HasIndex(e => e.LeaveId, "leave_id");

            entity.Property(e => e.Increment).HasColumnName("increment");
            entity.Property(e => e.Comment)
                .HasColumnType("text")
                .HasColumnName("comment");
            entity.Property(e => e.Duration).HasColumnName("duration");
            entity.Property(e => e.EmpId).HasColumnName("emp_id");
            entity.Property(e => e.EndDate).HasColumnName("end_date");
            entity.Property(e => e.FinalStatus).HasColumnName("final_status");
            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.LeaveId).HasColumnName("leave_id");
            entity.Property(e => e.StartDate).HasColumnName("start_date");
        });

        modelBuilder.Entity<BueLeaveDepApproval>(entity =>
        {
            entity.HasKey(e => new { e.LeaveId, e.DepartmentId, e.ApprovedByEmp })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0, 0 });

            entity
                .ToTable("bue_leave_dep_approval")
                .HasCharSet("latin1")
                .UseCollation("latin1_swedish_ci");

            entity.HasIndex(e => e.ApprovedByEmp, "approved_by_emp");

            entity.HasIndex(e => e.ApprovedByEmpLeavesApprovedBy, "approved_by_emp_leaves_approved_by");

            entity.HasIndex(e => e.DepartmentId, "department_id");

            entity.HasIndex(e => e.LeaveId, "leave_id");

            entity.Property(e => e.LeaveId).HasColumnName("leave_id");
            entity.Property(e => e.DepartmentId).HasColumnName("department_id");
            entity.Property(e => e.ApprovedByEmp).HasColumnName("approved_by_emp");
            entity.Property(e => e.ApprovedByEmpIfExceed).HasColumnName("approved_by_emp_if_exceed");
            entity.Property(e => e.ApprovedByEmpLeavesApprovedBy).HasColumnName("approved_by_emp_leaves_approved_by");
            entity.Property(e => e.Priority).HasColumnName("priority");
        });

        modelBuilder.Entity<BueLeaveEmpLeaveType>(entity =>
        {
            entity.HasKey(e => new { e.EmpId, e.LeaveId, e.StartDate })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0, 0 });

            entity
                .ToTable("bue_leave_emp_leave_type")
                .HasCharSet("latin1")
                .UseCollation("latin1_swedish_ci");

            entity.HasIndex(e => e.EmpId, "emp_id");

            entity.HasIndex(e => e.LeaveId, "leave_id");

            entity.Property(e => e.EmpId).HasColumnName("emp_id");
            entity.Property(e => e.LeaveId).HasColumnName("leave_id");
            entity.Property(e => e.StartDate)
                .HasMaxLength(50)
                .HasColumnName("start_date");
            entity.Property(e => e.Balance).HasColumnName("balance");
            entity.Property(e => e.Carryover).HasColumnName("carryover");
            entity.Property(e => e.EndDate).HasColumnName("end_date");
            entity.Property(e => e.Entitlement).HasColumnName("entitlement");
        });

        modelBuilder.Entity<BueLeaveEmpLeaveTypeHistory>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("bue_leave_emp_leave_type_history")
                .HasCharSet("latin1")
                .UseCollation("latin1_swedish_ci");

            entity.HasIndex(e => e.EmpId, "emp_id");

            entity.HasIndex(e => e.FinalStatus, "final_status");

            entity.HasIndex(e => e.LeaveId, "leave_id");

            entity.HasIndex(e => new { e.StartDate, e.EndDate }, "start_date");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Comment)
                .HasColumnType("text")
                .HasColumnName("comment");
            entity.Property(e => e.CreatedAt)
                .HasDefaultValueSql("CURRENT_TIMESTAMP")
                .HasColumnType("datetime")
                .HasColumnName("created_at");
            entity.Property(e => e.Duration).HasColumnName("duration");
            entity.Property(e => e.EmpId).HasColumnName("emp_id");
            entity.Property(e => e.EndDate).HasColumnName("end_date");
            entity.Property(e => e.FinalStatus).HasColumnName("final_status");
            entity.Property(e => e.LeaveId).HasColumnName("leave_id");
            entity.Property(e => e.LeaveStatus).HasColumnName("leave_status");
            entity.Property(e => e.StartDate).HasColumnName("start_date");
        });

        modelBuilder.Entity<BueLeaveEmpLeaveTypeHistoryDocument>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("bue_leave_emp_leave_type_history_documents")
                .UseCollation("utf8_general_ci");

            entity.HasIndex(e => e.HistoryId, "history_id");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.DocumentDescription)
                .HasColumnType("text")
                .HasColumnName("document_description");
            entity.Property(e => e.DocumentFilename)
                .HasColumnType("text")
                .HasColumnName("document_filename");
            entity.Property(e => e.DocumentTitle)
                .HasColumnType("text")
                .HasColumnName("document_title");
            entity.Property(e => e.HistoryId).HasColumnName("history_id");
        });

        modelBuilder.Entity<BueLeaveEmpLeaveTypeHistoryStatus>(entity =>
        {
            entity.HasKey(e => new { e.HistoryId, e.StatusId, e.UserId })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0, 0 });

            entity
                .ToTable("bue_leave_emp_leave_type_history_status")
                .HasCharSet("latin1")
                .UseCollation("latin1_swedish_ci");

            entity.HasIndex(e => e.HistoryId, "history_id");

            entity.HasIndex(e => e.StatusId, "status_id");

            entity.HasIndex(e => e.UserId, "user_id");

            entity.Property(e => e.HistoryId).HasColumnName("history_id");
            entity.Property(e => e.StatusId).HasColumnName("status_id");
            entity.Property(e => e.UserId).HasColumnName("user_id");
            entity.Property(e => e.Date).HasColumnName("date");
            entity.Property(e => e.Time)
                .HasDefaultValueSql("'00:00:00'")
                .HasColumnType("time")
                .HasColumnName("time");
        });

        modelBuilder.Entity<BueLeaveLeaveType>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("bue_leave_leave_types")
                .HasCharSet("latin1")
                .UseCollation("latin1_swedish_ci");

            entity.HasIndex(e => e.DeductedFrom, "deducted_from");

            entity.HasIndex(e => e.LeaveCarryOverFrom, "leave_carry_over_from");

            entity.HasIndex(e => e.MaxRequestedInMonthFrom, "max_requested_in_month_from");

            entity.HasIndex(e => e.ReturnedTo, "returned_to");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.ApplyAfterMonths).HasColumnName("apply_after_months");
            entity.Property(e => e.AutoApproved).HasColumnName("auto_approved");
            entity.Property(e => e.DeductedFrom).HasColumnName("deducted_from");
            entity.Property(e => e.Description)
                .HasColumnType("text")
                .HasColumnName("description");
            entity.Property(e => e.HalfDayMode)
                .HasColumnType("enum('morning','afternoon')")
                .HasColumnName("half_day_mode");
            entity.Property(e => e.LeaveCarryOverFrom).HasColumnName("leave_carry_over_from");
            entity.Property(e => e.LeaveDayType)
                .HasColumnType("enum('halfday','fullday','specifichours')")
                .HasColumnName("Leave_day_type");
            entity.Property(e => e.LeaveType)
                .HasMaxLength(100)
                .HasColumnName("leave_type");
            entity.Property(e => e.MaxCarryOver).HasColumnName("max_carry_over");
            entity.Property(e => e.MaxDays).HasColumnName("max_days");
            entity.Property(e => e.MaxEntitlement).HasColumnName("max_entitlement");
            entity.Property(e => e.MaxRequestedInDays).HasColumnName("max_requested_in_days");
            entity.Property(e => e.MaxRequestedInMonthFrom).HasColumnName("max_requested_in_month_from");
            entity.Property(e => e.MinDays).HasColumnName("min_days");
            entity.Property(e => e.MinDaysBetweenTwoLeaves).HasColumnName("min_days_between_two_leaves");
            entity.Property(e => e.RequestedBeforeHours).HasColumnName("requested_before_hours");
            entity.Property(e => e.ReturnedTo).HasColumnName("returned_to");
            entity.Property(e => e.SpecificHoursDuration)
                .HasColumnType("time")
                .HasColumnName("specific_hours_duration");
            entity.Property(e => e.SpecificHoursType)
                .HasColumnType("enum('morning','evening')")
                .HasColumnName("specific_hours_type");
            entity.Property(e => e.TimeToApprovalHours).HasColumnName("time_to_approval_hours");
        });

        modelBuilder.Entity<BueLeaveStatus>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("bue_leave_status")
                .HasCharSet("latin1")
                .UseCollation("latin1_swedish_ci");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Name)
                .HasMaxLength(100)
                .HasColumnName("name");
            entity.Property(e => e.Status).HasColumnName("status");
        });

        modelBuilder.Entity<BueMchBuilding>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("bue_mch_building")
                .HasCharSet("latin1")
                .UseCollation("latin1_swedish_ci");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Location)
                .HasMaxLength(100)
                .HasColumnName("location");
        });

        modelBuilder.Entity<BueMchMachine>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("bue_mch_machines")
                .HasCharSet("latin1")
                .UseCollation("latin1_swedish_ci");

            entity.HasIndex(e => e.BuildingId, "building_id");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.BuildingId).HasColumnName("building_id");
            entity.Property(e => e.Ip)
                .HasMaxLength(50)
                .HasColumnName("ip");
            entity.Property(e => e.IsUsed).HasColumnName("isUsed");
            entity.Property(e => e.MachineName)
                .HasMaxLength(100)
                .HasColumnName("machine_name");
            entity.Property(e => e.Model)
                .HasDefaultValueSql("'1'")
                .HasColumnName("model");
            entity.Property(e => e.Port).HasColumnName("port");
            entity.Property(e => e.Working)
                .HasDefaultValueSql("'1'")
                .HasColumnName("working");
        });

        modelBuilder.Entity<BuePolAttRestriction>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("bue_pol_att_restrictions")
                .HasCharSet("latin1")
                .UseCollation("latin1_swedish_ci");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.AllowedCheckInAfterMinutes).HasColumnName("allowed_check_in_after_minutes");
            entity.Property(e => e.AllowedCheckInBeforeMinutes).HasColumnName("allowed_check_in_before_minutes");
            entity.Property(e => e.AllowedCheckOutAfterMinutes).HasColumnName("allowed_check_out_after_minutes");
            entity.Property(e => e.AllowedCheckOutBeforeMinutes).HasColumnName("allowed_check_out_before_minutes");
            entity.Property(e => e.CheckInFrom)
                .HasColumnType("time")
                .HasColumnName("check_in_from");
            entity.Property(e => e.CheckInTo)
                .HasColumnType("time")
                .HasColumnName("check_in_to");
            entity.Property(e => e.CheckOutFrom)
                .HasColumnType("time")
                .HasColumnName("check_out_from");
            entity.Property(e => e.CheckOutTo)
                .HasColumnType("time")
                .HasColumnName("check_out_to");
            entity.Property(e => e.DefaultValue).HasColumnName("default_value");
            entity.Property(e => e.MachineCheckInFrom)
                .HasColumnType("time")
                .HasColumnName("machine_check_in_from");
            entity.Property(e => e.MachineCheckInTo)
                .HasColumnType("time")
                .HasColumnName("machine_check_in_to");
            entity.Property(e => e.RestrictionName)
                .HasMaxLength(100)
                .HasColumnName("restriction_name");
        });

        modelBuilder.Entity<BuePolEmpOfficialHoliday>(entity =>
        {
            entity.HasKey(e => new { e.EmpId, e.HolidayId })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

            entity
                .ToTable("bue_pol_emp_official_holidays")
                .HasCharSet("latin1")
                .UseCollation("latin1_swedish_ci");

            entity.HasIndex(e => e.EmpId, "emp_id");

            entity.HasIndex(e => e.HolidayId, "holiday_id");

            entity.Property(e => e.EmpId).HasColumnName("emp_id");
            entity.Property(e => e.HolidayId).HasColumnName("holiday_id");
        });

        modelBuilder.Entity<BuePolEmpPenalty>(entity =>
        {
            entity.HasKey(e => new { e.EmpId, e.PenaltyId })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

            entity
                .ToTable("bue_pol_emp_penalties")
                .HasCharSet("latin1")
                .UseCollation("latin1_swedish_ci");

            entity.HasIndex(e => e.EmpId, "emp_id");

            entity.HasIndex(e => e.PenaltyId, "penalty_id");

            entity.Property(e => e.EmpId).HasColumnName("emp_id");
            entity.Property(e => e.PenaltyId).HasColumnName("penalty_id");
            entity.Property(e => e.Date).HasColumnName("date");
        });

        modelBuilder.Entity<BuePolEmpPermit>(entity =>
        {
            entity.HasKey(e => new { e.EmpId, e.PermitId })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

            entity
                .ToTable("bue_pol_emp_permits")
                .HasCharSet("latin1")
                .UseCollation("latin1_swedish_ci");

            entity.HasIndex(e => e.EmpId, "emp_id");

            entity.HasIndex(e => e.PermitId, "permit_id");

            entity.Property(e => e.EmpId).HasColumnName("emp_id");
            entity.Property(e => e.PermitId).HasColumnName("permit_id");
            entity.Property(e => e.EndDate).HasColumnName("end_date");
            entity.Property(e => e.StartDate).HasColumnName("start_date");
            entity.Property(e => e.Time)
                .HasColumnType("time")
                .HasColumnName("time");
        });

        modelBuilder.Entity<BuePolEmpWorkingDay>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("bue_pol_emp_working_day")
                .UseCollation("utf8_general_ci");

            entity.HasIndex(e => new { e.EmpId, e.WorkingDayId }, "emp_id");

            entity.HasIndex(e => new { e.EmpId, e.StartDate, e.WorkingDayId, e.Type }, "unique_values").IsUnique();

            entity.HasIndex(e => e.WorkingDayId, "working_day_id");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.EmpId).HasColumnName("emp_id");
            entity.Property(e => e.EndDate).HasColumnName("end_date");
            entity.Property(e => e.StartDate).HasColumnName("start_date");
            entity.Property(e => e.Type)
                .HasColumnType("enum('working/non-working','research','maternity')")
                .HasColumnName("type");
            entity.Property(e => e.WorkingDayId).HasColumnName("working_day_id");
        });

        modelBuilder.Entity<BuePolEmpWorkingDayMaternity>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("bue_pol_emp_working_day_maternity")
                .UseCollation("utf8_general_ci");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("id");
            entity.Property(e => e.HoursType)
                .HasColumnType("enum('morning','evening')")
                .HasColumnName("hours_type");
            entity.Property(e => e.Type)
                .HasColumnType("enum('full-day','hours')")
                .HasColumnName("type");
        });

        modelBuilder.Entity<BuePolEmpWorkingDayResearch>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("bue_pol_emp_working_day_research")
                .UseCollation("utf8_general_ci");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("id");
            entity.Property(e => e.HalfdayType)
                .HasColumnType("enum('morning','evening')")
                .HasColumnName("halfday_type");
            entity.Property(e => e.Type)
                .HasColumnType("enum('full-day','half-day')")
                .HasColumnName("type");
        });

        modelBuilder.Entity<BuePolOfficialHoliday>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("bue_pol_official_holidays")
                .HasCharSet("latin1")
                .UseCollation("latin1_swedish_ci");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.DefaultValue).HasColumnName("default_value");
            entity.Property(e => e.Description)
                .HasColumnType("text")
                .HasColumnName("description");
            entity.Property(e => e.EndDate).HasColumnName("end_date");
            entity.Property(e => e.Name)
                .HasMaxLength(100)
                .HasColumnName("name");
            entity.Property(e => e.StartDate).HasColumnName("start_date");
        });

        modelBuilder.Entity<BuePolOvertime>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("bue_pol_overtime")
                .HasCharSet("latin1")
                .UseCollation("latin1_swedish_ci");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.DayInLieuRate).HasColumnName("day_in_lieu_rate");
            entity.Property(e => e.DefaultValue).HasColumnName("default_value");
            entity.Property(e => e.EveningOvertimeRate).HasColumnName("evening_overtime_rate");
            entity.Property(e => e.MaxMorningOvertimeMinutes).HasColumnName("max_morning_overtime_minutes");
            entity.Property(e => e.MaxOvertimeRateDailyMinutes).HasColumnName("max_overtime_rate_daily_minutes");
            entity.Property(e => e.MaxOvertimeRateMonthlyMinutes).HasColumnName("max_overtime_rate_monthly_minutes");
            entity.Property(e => e.MinOvertimeRateAfterWork).HasColumnName("min_overtime_rate_after_work");
            entity.Property(e => e.MinOvertimeRateBeforeWork).HasColumnName("min_overtime_rate_before_work");
            entity.Property(e => e.MinOvertimeRateDailyMinutes).HasColumnName("min_overtime_rate_daily_minutes");
            entity.Property(e => e.MorningOvertimeRate).HasColumnName("morning_overtime_rate");
            entity.Property(e => e.Name)
                .HasMaxLength(100)
                .HasColumnName("name");
            entity.Property(e => e.OffHolidayRate).HasColumnName("off_holiday_rate");
            entity.Property(e => e.WeekendRate).HasColumnName("weekend_rate");
        });

        modelBuilder.Entity<BuePolPenalty>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("bue_pol_penalties")
                .HasCharSet("latin1")
                .UseCollation("latin1_swedish_ci");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.DayHour)
                .HasColumnType("enum('day','hour')")
                .HasColumnName("day_hour");
            entity.Property(e => e.DayHourRate).HasColumnName("day_hour_rate");
            entity.Property(e => e.Penalty)
                .HasMaxLength(100)
                .HasColumnName("penalty");
        });

        modelBuilder.Entity<BuePolPermit>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("bue_pol_permits")
                .HasCharSet("latin1")
                .UseCollation("latin1_swedish_ci");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Name)
                .HasMaxLength(100)
                .HasColumnName("name");
            entity.Property(e => e.PermitDays).HasColumnName("permit_days");
            entity.Property(e => e.PermitHours).HasColumnName("permit_hours");
            entity.Property(e => e.PermitRepeatTimeInMonths).HasColumnName("permit_repeat_time_in_months");
            entity.Property(e => e.PermitType)
                .HasColumnType("enum('paid','nonpaid')")
                .HasColumnName("permit_type");
        });

        modelBuilder.Entity<BuePolPermitPenalty>(entity =>
        {
            entity.HasKey(e => new { e.PermitId, e.PenaltyId })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

            entity
                .ToTable("bue_pol_permit_penalties")
                .HasCharSet("latin1")
                .UseCollation("latin1_swedish_ci");

            entity.HasIndex(e => e.PenaltyId, "penalty_id");

            entity.HasIndex(e => e.PermitId, "permit_id");

            entity.Property(e => e.PermitId).HasColumnName("permit_id");
            entity.Property(e => e.PenaltyId).HasColumnName("penalty_id");
        });

        modelBuilder.Entity<BuePolShift>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("bue_pol_shifts")
                .HasCharSet("latin1")
                .UseCollation("latin1_swedish_ci");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.DefaultValue).HasColumnName("default_value");
            entity.Property(e => e.EndTime)
                .HasColumnType("time")
                .HasColumnName("end_time");
            entity.Property(e => e.StartTime)
                .HasColumnType("time")
                .HasColumnName("start_time");
            entity.Property(e => e.Type)
                .HasColumnType("enum('fixed','unfixed')")
                .HasColumnName("type");
        });

        modelBuilder.Entity<BuePolWorkingDay>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("bue_pol_working_day")
                .HasCharSet("latin1")
                .UseCollation("latin1_swedish_ci");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Day)
                .HasMaxLength(50)
                .HasColumnName("day");
            entity.Property(e => e.DefaultValue).HasColumnName("default_value");
            entity.Property(e => e.State)
                .HasColumnType("enum('working','nonworking')")
                .HasColumnName("state");
        });

        modelBuilder.Entity<BueResource>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("bue_resources")
                .HasCharSet("latin1")
                .UseCollation("latin1_swedish_ci");

            entity.HasIndex(e => e.Name, "name").IsUnique();

            entity.HasIndex(e => e.ParentResource, "parent_resource");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.DisplayName)
                .HasMaxLength(200)
                .HasColumnName("display_name");
            entity.Property(e => e.IsMenu).HasColumnName("is_menu");
            entity.Property(e => e.Name)
                .HasMaxLength(100)
                .HasColumnName("name");
            entity.Property(e => e.ParentResource).HasColumnName("parent_resource");
            entity.Property(e => e.Route)
                .HasColumnType("text")
                .HasColumnName("route");
        });

        modelBuilder.Entity<BueUpdateDataEmp>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("bue_update_data_emp", tb => tb.HasComment("phd.Minor"))
                .UseCollation("utf8_general_ci");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.AddressAsPerNationalId)
                .HasMaxLength(225)
                .HasColumnName("Address_As_per_National_ID");
            entity.Property(e => e.Age).HasMaxLength(11);
            entity.Property(e => e.BaBSc)
                .HasMaxLength(225)
                .HasColumnName("BA/B.Sc.");
            entity.Property(e => e.BueEmail)
                .HasMaxLength(225)
                .HasColumnName("BUE email");
            entity.Property(e => e.City).HasMaxLength(225);
            entity.Property(e => e.Country).HasMaxLength(220);
            entity.Property(e => e.CurrentAddress)
                .HasMaxLength(225)
                .HasColumnName("Current_Address");
            entity.Property(e => e.DateOfBirth).HasColumnName("Date_of_Birth");
            entity.Property(e => e.DateOfPromotionToAssociateProfessor)
                .HasDefaultValueSql("'0000-00-00'")
                .HasColumnName("Date_of_promotion_to_Associate_Professor");
            entity.Property(e => e.DateOfPromotionToProfessor)
                .HasDefaultValueSql("'0000-00-00'")
                .HasColumnName("Date_of_promotion_to_Professor");
            entity.Property(e => e.Department)
                .HasMaxLength(225)
                .HasColumnName("department");
            entity.Property(e => e.EmergencyAddress)
                .HasMaxLength(225)
                .HasColumnName("EMERGENCY_address");
            entity.Property(e => e.EmergencyMobile)
                .HasMaxLength(255)
                .HasColumnName("EMERGENCY_mobile");
            entity.Property(e => e.EmergencyMobileHome)
                .HasMaxLength(255)
                .HasColumnName("EMERGENCY_mobile_home");
            entity.Property(e => e.EmergencyName)
                .HasMaxLength(255)
                .HasColumnName("EMERGENCY_name");
            entity.Property(e => e.EmergencyRelationship)
                .HasMaxLength(255)
                .HasColumnName("EMERGENCY_Relationship");
            entity.Property(e => e.EmploymentType)
                .HasMaxLength(225)
                .HasColumnName("Employment_Type");
            entity.Property(e => e.Faculty).HasMaxLength(225);
            entity.Property(e => e.Faculty11)
                .HasMaxLength(225)
                .HasColumnName("Faculty_11");
            entity.Property(e => e.FirstDegreeRelative1Name)
                .HasMaxLength(255)
                .HasColumnName("First Degree Relative 1 Name");
            entity.Property(e => e.FirstDegreeRelative2Name)
                .HasMaxLength(255)
                .HasColumnName("First Degree Relative 2 Name");
            entity.Property(e => e.FirstDegreeRelative3Name)
                .HasMaxLength(255)
                .HasColumnName("First Degree Relative 3 Name");
            entity.Property(e => e.FirstDegreeRelative4Name)
                .HasMaxLength(255)
                .HasColumnName("First Degree Relative 4 Name");
            entity.Property(e => e.FirstDegreeRelative5Name)
                .HasMaxLength(255)
                .HasColumnName("First Degree Relative 5 Name");
            entity.Property(e => e.FullNamInEnglish)
                .HasMaxLength(225)
                .HasColumnName("Full_Nam_ in_English");
            entity.Property(e => e.FullNameInArabic)
                .HasMaxLength(225)
                .HasColumnName("Full_Name_in_Arabic");
            entity.Property(e => e.Gender).HasMaxLength(225);
            entity.Property(e => e.IdNumber)
                .HasMaxLength(225)
                .HasColumnName("ID_Number");
            entity.Property(e => e.MaMSc)
                .HasMaxLength(225)
                .HasColumnName("MA/ M.Sc.");
            entity.Property(e => e.MaMScFaculty)
                .HasMaxLength(225)
                .HasColumnName("MA/ M.Sc.faculty");
            entity.Property(e => e.MaMScMajor)
                .HasMaxLength(225)
                .HasColumnName("MA/ M.Sc.Major");
            entity.Property(e => e.MaMScMinor)
                .HasMaxLength(225)
                .HasColumnName("MA/ M.Sc.Minor");
            entity.Property(e => e.MaMScYear)
                .HasMaxLength(225)
                .HasColumnName("MA/ M.Sc.year");
            entity.Property(e => e.Major).HasMaxLength(225);
            entity.Property(e => e.Minor).HasMaxLength(225);
            entity.Property(e => e.MobileNumber1)
                .HasMaxLength(225)
                .HasColumnName("Mobile_Number_1");
            entity.Property(e => e.MobileNumber2)
                .HasMaxLength(225)
                .HasColumnName("Mobile_Number_2");
            entity.Property(e => e.Nationality).HasMaxLength(225);
            entity.Property(e => e.NumberOfFirstDegreeRelatives)
                .HasMaxLength(255)
                .HasColumnName("Number_of_first_degree_relatives");
            entity.Property(e => e.PassportNumber)
                .HasMaxLength(225)
                .HasDefaultValueSql("'0000'")
                .HasColumnName("Passport_Number");
            entity.Property(e => e.PersonalEmail)
                .HasMaxLength(225)
                .HasColumnName("Personal_Email");
            entity.Property(e => e.PersonalPic)
                .HasMaxLength(255)
                .HasColumnName("personal_pic");
            entity.Property(e => e.Phd)
                .HasMaxLength(255)
                .HasColumnName("PHD");
            entity.Property(e => e.PhdFaculty)
                .HasMaxLength(225)
                .HasColumnName("phd.faculty");
            entity.Property(e => e.PhdMajor)
                .HasMaxLength(225)
                .HasColumnName("phd.Major");
            entity.Property(e => e.PhdMinor)
                .HasMaxLength(255)
                .HasColumnName("PHD.Minor");
            entity.Property(e => e.PhdYear)
                .HasMaxLength(225)
                .HasColumnName("phd.year");
            entity.Property(e => e.Place)
                .HasMaxLength(225)
                .HasColumnName("place");
            entity.Property(e => e.Place2)
                .HasMaxLength(225)
                .HasColumnName("place2");
            entity.Property(e => e.Position).HasMaxLength(225);
            entity.Property(e => e.Relation1).HasMaxLength(225);
            entity.Property(e => e.Relation2).HasMaxLength(225);
            entity.Property(e => e.Relation3).HasMaxLength(225);
            entity.Property(e => e.Relation4).HasMaxLength(255);
            entity.Property(e => e.Relation5).HasMaxLength(255);
            entity.Property(e => e.StaffNo)
                .HasMaxLength(225)
                .HasColumnName("Staff_No");
            entity.Property(e => e.TelephoneNumber)
                .HasMaxLength(225)
                .HasColumnName("Telephone_Number");
            entity.Property(e => e.University).HasMaxLength(225);
            entity.Property(e => e.UniversityMa)
                .HasMaxLength(225)
                .HasColumnName("UniversityMA");
            entity.Property(e => e.UniversityPhd)
                .HasMaxLength(225)
                .HasColumnName("UniversityPHD");
            entity.Property(e => e.Year)
                .HasMaxLength(225)
                .HasColumnName("year");
            entity.Property(e => e.ZipPostalCode)
                .HasMaxLength(225)
                .HasColumnName("Zip/postal code");
        });

        modelBuilder.Entity<BueUser>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("bue_user")
                .HasCharSet("latin1")
                .UseCollation("latin1_swedish_ci");

            entity.HasIndex(e => e.CreatedBy, "created_by");

            entity.HasIndex(e => e.EmpId, "emp_id");

            entity.HasIndex(e => e.ModifiedUserId, "modified_user_id");

            entity.HasIndex(e => e.RoleId, "role_id");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Authentication)
                .HasMaxLength(200)
                .HasColumnName("authentication");
            entity.Property(e => e.CreatedBy).HasColumnName("created_by");
            entity.Property(e => e.DateAdded)
                .HasColumnType("datetime")
                .HasColumnName("date_added");
            entity.Property(e => e.DateModified)
                .HasColumnType("datetime")
                .HasColumnName("date_modified");
            entity.Property(e => e.EmpId).HasColumnName("emp_id");
            entity.Property(e => e.ModifiedUserId).HasColumnName("modified_user_id");
            entity.Property(e => e.RoleId).HasColumnName("role_id");
            entity.Property(e => e.Status).HasColumnName("status");
            entity.Property(e => e.UserName)
                .HasMaxLength(100)
                .HasColumnName("user_name");
            entity.Property(e => e.UserPassword)
                .HasColumnType("text")
                .HasColumnName("user_password");
        });

        modelBuilder.Entity<BueUserActivityLink>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("bue_user_activity_link")
                .HasCharSet("latin1")
                .UseCollation("latin1_swedish_ci");

            entity.HasIndex(e => e.ActivityId, "activity_id");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.ActivityId).HasColumnName("activity_id");
            entity.Property(e => e.DateTime)
                .HasColumnType("datetime")
                .HasColumnName("date_time");
            entity.Property(e => e.Referer)
                .HasColumnType("text")
                .HasColumnName("referer");
            entity.Property(e => e.Url)
                .HasColumnType("text")
                .HasColumnName("url");
        });

        modelBuilder.Entity<BueUserActivityLog>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("bue_user_activity_log")
                .HasCharSet("latin1")
                .UseCollation("latin1_swedish_ci");

            entity.HasIndex(e => e.UserId, "user_id");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Browser)
                .HasMaxLength(400)
                .HasColumnName("browser");
            entity.Property(e => e.City)
                .HasMaxLength(100)
                .HasColumnName("city");
            entity.Property(e => e.Country)
                .HasMaxLength(100)
                .HasColumnName("country");
            entity.Property(e => e.Ip)
                .HasMaxLength(50)
                .HasColumnName("ip");
            entity.Property(e => e.Latitude)
                .HasMaxLength(100)
                .HasColumnName("latitude");
            entity.Property(e => e.Longitude)
                .HasMaxLength(100)
                .HasColumnName("longitude");
            entity.Property(e => e.Region)
                .HasMaxLength(100)
                .HasColumnName("region");
            entity.Property(e => e.Session)
                .HasMaxLength(150)
                .HasColumnName("session");
            entity.Property(e => e.UserId).HasColumnName("user_id");
        });

        modelBuilder.Entity<BueUserRole>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("bue_user_role")
                .HasCharSet("latin1")
                .UseCollation("latin1_swedish_ci");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.DisplayName)
                .HasMaxLength(100)
                .HasColumnName("display_name");
            entity.Property(e => e.Name)
                .HasMaxLength(100)
                .HasColumnName("name");
        });

        modelBuilder.Entity<BueUserRoleResource>(entity =>
        {
            entity.HasKey(e => new { e.RoleId, e.ResourceId })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

            entity
                .ToTable("bue_user_role_resources")
                .HasCharSet("latin1")
                .UseCollation("latin1_swedish_ci");

            entity.HasIndex(e => e.ResourceId, "resource_id");

            entity.HasIndex(e => e.RoleId, "role_id");

            entity.Property(e => e.RoleId).HasColumnName("role_id");
            entity.Property(e => e.ResourceId).HasColumnName("resource_id");
        });

        modelBuilder.Entity<BueViolationHistory>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("bue_violation_history")
                .UseCollation("utf8_general_ci");

            entity.HasIndex(e => e.EmpId, "emp_id");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.DateOfViolation).HasColumnName("date_of_violation");
            entity.Property(e => e.EmpId).HasColumnName("emp_id");
            entity.Property(e => e.Type)
                .HasColumnType("text")
                .HasColumnName("type");
            entity.Property(e => e.VioExists)
                .HasDefaultValueSql("'1'")
                .HasColumnName("vio_exists");
        });

        modelBuilder.Entity<Buecarinforole>(entity =>
        {
            entity.HasKey(e => e.RoleId).HasName("PRIMARY");

            entity.ToTable("buecarinforoles");

            entity.Property(e => e.RoleId).ValueGeneratedNever();
            entity.Property(e => e.HierarchyLevel).HasColumnName("hierarchyLevel");
            entity.Property(e => e.RoleName)
                .HasMaxLength(255)
                .HasColumnName("roleName");
        });

        modelBuilder.Entity<Buecarinfouser>(entity =>
        {
            entity.HasKey(e => e.UserId).HasName("PRIMARY");

            entity.ToTable("buecarinfousers");

            entity.HasIndex(e => e.EmployeeId, "carUserEmployee");

            entity.HasIndex(e => e.RoleId, "carUserRole");

            entity.HasIndex(e => e.Code, "code").IsUnique();

            entity.HasIndex(e => e.UserEmail, "userEmail").HasAnnotation("MySql:FullTextIndex", true);

            entity.Property(e => e.UserId).HasColumnName("userId");
            entity.Property(e => e.Code).HasColumnName("code");
            entity.Property(e => e.EmployeeId).HasColumnName("employeeId");
            entity.Property(e => e.FirstName)
                .HasMaxLength(255)
                .HasColumnName("firstName");
            entity.Property(e => e.LastName)
                .HasMaxLength(255)
                .HasColumnName("lastName");
            entity.Property(e => e.MiddleName)
                .HasMaxLength(255)
                .HasColumnName("middleName");
            entity.Property(e => e.RoleId).HasColumnName("roleId");
            entity.Property(e => e.UserEmail).HasColumnName("userEmail");
            entity.Property(e => e.UserName)
                .HasMaxLength(255)
                .HasColumnName("userName");

            entity.HasOne(d => d.Employee).WithMany(p => p.Buecarinfousers)
                .HasForeignKey(d => d.EmployeeId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("carUserEmployee");

            entity.HasOne(d => d.Role).WithMany(p => p.Buecarinfousers)
                .HasForeignKey(d => d.RoleId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("carUserRole");
        });

        modelBuilder.Entity<CarEntryLog>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("car_entry_logs");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.CarId).HasColumnName("carId");
            entity.Property(e => e.CarStatus).HasColumnName("carStatus");
            entity.Property(e => e.CreatedAt)
                .HasColumnType("datetime")
                .HasColumnName("createdAt");
            entity.Property(e => e.MigrationStatus).HasColumnName("migrationStatus");
            entity.Property(e => e.UserId).HasColumnName("userId");
        });

        modelBuilder.Entity<Carstatuslookup>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("carstatuslookup");

            entity.Property(e => e.CarStatusName)
                .HasMaxLength(255)
                .HasColumnName("carStatusName");
        });

        modelBuilder.Entity<EmpChangedCategory>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("emp_changed_categories")
                .UseCollation("utf8_general_ci");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.ChangedAt)
                .HasColumnType("datetime")
                .HasColumnName("changed_at");
            entity.Property(e => e.ChangedBy).HasColumnName("changed_by");
            entity.Property(e => e.ChangedByUsername)
                .HasMaxLength(255)
                .HasDefaultValueSql("''")
                .HasColumnName("changed_by_username");
            entity.Property(e => e.EmpId).HasColumnName("emp_id");
            entity.Property(e => e.OldCategory).HasColumnName("old_category");
        });

        modelBuilder.Entity<EmpTraining>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("emp_training");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Comment)
                .HasColumnType("text")
                .HasColumnName("comment");
            entity.Property(e => e.CreatedAt)
                .HasColumnType("timestamp")
                .HasColumnName("created_at");
            entity.Property(e => e.EmpId).HasColumnName("emp_id");
            entity.Property(e => e.NeedTraining).HasColumnName("need_training");
            entity.Property(e => e.UpdatedAt)
                .HasColumnType("timestamp")
                .HasColumnName("updated_at");
        });

        modelBuilder.Entity<EmpTrainingCourse>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("emp_training_courses");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.CourseEndDate).HasColumnName("course_end_date");
            entity.Property(e => e.CourseName)
                .HasMaxLength(255)
                .HasColumnName("course_name");
            entity.Property(e => e.CoursePlace)
                .HasMaxLength(255)
                .HasColumnName("course_place");
            entity.Property(e => e.CourseStartDate).HasColumnName("course_start_date");
            entity.Property(e => e.CreatedAt)
                .HasColumnType("timestamp")
                .HasColumnName("created_at");
            entity.Property(e => e.EmpId).HasColumnName("emp_id");
            entity.Property(e => e.UpdatedAt)
                .HasColumnType("timestamp")
                .HasColumnName("updated_at");
        });

        modelBuilder.Entity<Issuedbuecarinfo>(entity =>
        {
            entity.HasKey(e => e.CarId).HasName("PRIMARY");

            entity.ToTable("issuedbuecarinfo");

            entity.HasIndex(e => e.EmployeeId, "carEmp");

            entity.HasIndex(e => e.CarLicenseNumber, "carLicenseNumber").IsUnique();

            entity.HasIndex(e => e.CarLicenseArabicLetter, "car_license_plate").IsUnique();

            entity.Property(e => e.CarId).HasColumnName("carId");
            entity.Property(e => e.BrandName)
                .HasMaxLength(255)
                .HasColumnName("brandName");
            entity.Property(e => e.CarColor)
                .HasMaxLength(255)
                .HasColumnName("carColor");
            entity.Property(e => e.CarLicenseArabicLetter).HasColumnName("carLicenseArabicLetter");
            entity.Property(e => e.CarLicenseBackPhotoPath)
                .HasMaxLength(255)
                .HasColumnName("carLIcenseBackPhotoPath");
            entity.Property(e => e.CarLicenseEndDate)
                .HasColumnType("datetime")
                .HasColumnName("carLicenseEndDate");
            entity.Property(e => e.CarLicenseFrontPhotoPath)
                .HasMaxLength(255)
                .HasColumnName("carLIcenseFrontPhotoPath");
            entity.Property(e => e.CarLicenseNumber).HasColumnName("carLicenseNumber");
            entity.Property(e => e.CarModel)
                .HasMaxLength(255)
                .HasColumnName("carModel");
            entity.Property(e => e.CreatedAt)
                .HasDefaultValueSql("CURRENT_TIMESTAMP")
                .HasColumnType("datetime")
                .HasColumnName("created_At");
            entity.Property(e => e.EmployeeId).HasColumnName("employeeId");
            entity.Property(e => e.ModelYear).HasColumnName("modelYear");
        });

        modelBuilder.Entity<MachineApiLog>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("machine_api_logs");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.CreatedAt)
                .HasDefaultValueSql("CURRENT_TIMESTAMP")
                .HasColumnType("datetime")
                .HasColumnName("created_at");
            entity.Property(e => e.Data)
                .HasColumnType("text")
                .HasColumnName("data");
            entity.Property(e => e.Method)
                .HasMaxLength(255)
                .HasColumnName("method");
            entity.Property(e => e.Response)
                .HasColumnType("text")
                .HasColumnName("response");
            entity.Property(e => e.ResponseTime).HasColumnName("response_time");
            entity.Property(e => e.Url)
                .HasMaxLength(255)
                .HasColumnName("url");
        });

        modelBuilder.Entity<Migration>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("migrations");

            entity.Property(e => e.Batch).HasColumnName("batch");
            entity.Property(e => e.Migration1)
                .HasMaxLength(255)
                .HasColumnName("migration");
        });

        modelBuilder.Entity<NewLeaveApproval>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("new_leave_approval");

            entity.Property(e => e.ApprovedByEmp)
                .HasMaxLength(255)
                .HasDefaultValueSql("''")
                .HasColumnName("approved_by_emp");
            entity.Property(e => e.ApprovedByEmpIfExceed).HasColumnName("approved_by_emp_if_exceed");
            entity.Property(e => e.ApprovedByEmpLeavesApprovedBy).HasColumnName("approved_by_emp_leaves_approved_by");
            entity.Property(e => e.DepartmentId).HasColumnName("department_id");
            entity.Property(e => e.LeaveId).HasColumnName("leave_id");
            entity.Property(e => e.Priority).HasColumnName("priority");
        });

        modelBuilder.Entity<ObjectiveEdit>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("objective_edits")
                .UseCollation("utf8_general_ci");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.EditedAt)
                .HasColumnType("datetime")
                .HasColumnName("edited_at");
            entity.Property(e => e.EditedBy).HasColumnName("edited_by");
            entity.Property(e => e.EditedByName)
                .HasMaxLength(255)
                .HasDefaultValueSql("''")
                .HasColumnName("edited_by_name");
            entity.Property(e => e.EmpId).HasColumnName("emp_id");
        });

        modelBuilder.Entity<ObjectiveEditHistory>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("objective_edit_history")
                .UseCollation("utf8_general_ci");

            entity.HasIndex(e => e.EmpId, "emp_id");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Confirm).HasColumnName("confirm");
            entity.Property(e => e.Dimension)
                .HasMaxLength(2500)
                .HasColumnName("dimension");
            entity.Property(e => e.EditId).HasColumnName("edit_id");
            entity.Property(e => e.EmpId).HasColumnName("emp_id");
            entity.Property(e => e.ExpectedResult)
                .HasMaxLength(2500)
                .HasColumnName("expected_result");
            entity.Property(e => e.GrantedMarks).HasColumnName("granted_marks");
            entity.Property(e => e.KeyPerformance)
                .HasMaxLength(2500)
                .HasColumnName("key_performance");
            entity.Property(e => e.ObjectiveName)
                .HasMaxLength(250)
                .HasColumnName("objective_name");
            entity.Property(e => e.PercentageAchievement).HasColumnName("percentage_achievement");
            entity.Property(e => e.Score).HasColumnName("score");
            entity.Property(e => e.Weight).HasColumnName("weight");
            entity.Property(e => e.Year).HasColumnName("year");
        });

        modelBuilder.Entity<Pendingbuecarinfo>(entity =>
        {
            entity.HasKey(e => e.CarId).HasName("PRIMARY");

            entity.ToTable("pendingbuecarinfo");

            entity.HasIndex(e => e.EmployeeId, "carEmp");

            entity.HasIndex(e => new { e.CarLicenseNumber, e.CarLicenseArabicLetter }, "carLicenseNumber");

            entity.Property(e => e.CarId).HasColumnName("carId");
            entity.Property(e => e.ApprovedAt)
                .HasColumnType("datetime")
                .HasColumnName("approved_at");
            entity.Property(e => e.ApprovedBy)
                .HasMaxLength(255)
                .HasColumnName("approvedBy");
            entity.Property(e => e.BadgeNumber).HasColumnName("badgeNumber");
            entity.Property(e => e.BrandName)
                .HasMaxLength(255)
                .HasColumnName("brandName");
            entity.Property(e => e.BueOwner)
                .HasMaxLength(255)
                .HasColumnName("bueOwner");
            entity.Property(e => e.CarColor)
                .HasMaxLength(255)
                .HasColumnName("carColor");
            entity.Property(e => e.CarLicenseArabicLetter).HasColumnName("carLicenseArabicLetter");
            entity.Property(e => e.CarLicenseBackPhotoPath)
                .HasMaxLength(255)
                .HasColumnName("carLIcenseBackPhotoPath");
            entity.Property(e => e.CarLicenseEndDate)
                .HasColumnType("datetime")
                .HasColumnName("carLicenseEndDate");
            entity.Property(e => e.CarLicenseFrontPhotoPath)
                .HasMaxLength(255)
                .HasColumnName("carLIcenseFrontPhotoPath");
            entity.Property(e => e.CarLicenseNumber).HasColumnName("carLicenseNumber");
            entity.Property(e => e.CarModel)
                .HasMaxLength(255)
                .HasColumnName("carModel");
            entity.Property(e => e.CreatedAt)
                .HasDefaultValueSql("CURRENT_TIMESTAMP")
                .HasColumnType("datetime")
                .HasColumnName("created_At");
            entity.Property(e => e.Email)
                .HasMaxLength(100)
                .HasColumnName("email");
            entity.Property(e => e.EmployeeId).HasColumnName("employeeId");
            entity.Property(e => e.Hasbadge).HasColumnName("hasbadge");
            entity.Property(e => e.IsBueAsset).HasColumnName("isBueAsset");
            entity.Property(e => e.IsMigrated).HasColumnName("isMigrated");
            entity.Property(e => e.ModelYear).HasColumnName("modelYear");
            entity.Property(e => e.PhoneNumber)
                .HasMaxLength(20)
                .HasColumnName("phoneNumber");
            entity.Property(e => e.ReceivingLocation).HasMaxLength(255);
            entity.Property(e => e.RejectedBy)
                .HasMaxLength(255)
                .HasColumnName("rejectedBy");
            entity.Property(e => e.SecondaryPhone)
                .HasMaxLength(20)
                .HasColumnName("secondaryPhone");
            entity.Property(e => e.Status).HasColumnName("status");

            entity.HasOne(d => d.Employee).WithMany(p => p.Pendingbuecarinfos)
                .HasForeignKey(d => d.EmployeeId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("carEmp");
        });

        modelBuilder.Entity<Pendingbuecarinfoarchive>(entity =>
        {
            entity.HasKey(e => e.CarId).HasName("PRIMARY");

            entity.ToTable("pendingbuecarinfoarchive");

            entity.Property(e => e.CarId).HasColumnName("carId");
            entity.Property(e => e.ApprovedAt)
                .HasColumnType("datetime")
                .HasColumnName("approved_at");
            entity.Property(e => e.ApprovedBy)
                .HasMaxLength(255)
                .HasColumnName("approvedBy");
            entity.Property(e => e.BadgeNumber).HasColumnName("badgeNumber");
            entity.Property(e => e.BrandName)
                .HasMaxLength(255)
                .HasColumnName("brandName");
            entity.Property(e => e.CarColor)
                .HasMaxLength(255)
                .HasColumnName("carColor");
            entity.Property(e => e.CarLicenseArabicLetter)
                .HasMaxLength(255)
                .HasColumnName("carLicenseArabicLetter");
            entity.Property(e => e.CarLicenseBackPhotoPath)
                .HasMaxLength(255)
                .HasColumnName("carLIcenseBackPhotoPath");
            entity.Property(e => e.CarLicenseEndDate)
                .HasColumnType("datetime")
                .HasColumnName("carLicenseEndDate");
            entity.Property(e => e.CarLicenseFrontPhotoPath)
                .HasMaxLength(255)
                .HasColumnName("carLIcenseFrontPhotoPath");
            entity.Property(e => e.CarLicenseNumber).HasColumnName("carLicenseNumber");
            entity.Property(e => e.CarModel)
                .HasMaxLength(255)
                .HasColumnName("carModel");
            entity.Property(e => e.CreatedAt)
                .HasDefaultValueSql("CURRENT_TIMESTAMP")
                .HasColumnType("datetime")
                .HasColumnName("created_At");
            entity.Property(e => e.Email)
                .HasMaxLength(100)
                .HasColumnName("email");
            entity.Property(e => e.EmployeeId).HasColumnName("employeeId");
            entity.Property(e => e.ModelYear).HasColumnName("modelYear");
            entity.Property(e => e.PhoneNumber)
                .HasMaxLength(20)
                .HasColumnName("phoneNumber");
            entity.Property(e => e.ReceivingLocation).HasMaxLength(255);
            entity.Property(e => e.RejectedBy)
                .HasMaxLength(255)
                .HasColumnName("rejectedBy");
            entity.Property(e => e.SecondaryPhone)
                .HasMaxLength(20)
                .HasColumnName("secondaryPhone");
            entity.Property(e => e.Status).HasColumnName("status");
        });

        modelBuilder.Entity<RefundedHistory>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("refunded_history")
                .HasCharSet("latin1")
                .UseCollation("latin1_swedish_ci");

            entity.HasIndex(e => e.EmpId, "emp_id");

            entity.HasIndex(e => e.FinalStatus, "final_status");

            entity.HasIndex(e => e.LeaveId, "leave_id");

            entity.HasIndex(e => new { e.StartDate, e.EndDate }, "start_date");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Comment)
                .HasColumnType("text")
                .HasColumnName("comment");
            entity.Property(e => e.CreatedAt)
                .HasDefaultValueSql("CURRENT_TIMESTAMP")
                .HasColumnType("datetime")
                .HasColumnName("created_at");
            entity.Property(e => e.Duration).HasColumnName("duration");
            entity.Property(e => e.EmpId).HasColumnName("emp_id");
            entity.Property(e => e.EndDate).HasColumnName("end_date");
            entity.Property(e => e.FinalStatus).HasColumnName("final_status");
            entity.Property(e => e.LeaveId).HasColumnName("leave_id");
            entity.Property(e => e.StartDate).HasColumnName("start_date");
        });

        modelBuilder.Entity<Researchday>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("researchday");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("id");
            entity.Property(e => e.Code)
                .HasMaxLength(255)
                .HasColumnName("code");
            entity.Property(e => e.Name)
                .HasMaxLength(255)
                .HasColumnName("name");
        });

        modelBuilder.Entity<SrsApiLog>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("srs_api_logs");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.CreatedAt)
                .HasDefaultValueSql("CURRENT_TIMESTAMP")
                .HasColumnType("datetime")
                .HasColumnName("created_at");
            entity.Property(e => e.Data)
                .HasColumnType("text")
                .HasColumnName("data");
            entity.Property(e => e.Method)
                .HasMaxLength(255)
                .HasColumnName("method");
            entity.Property(e => e.Response)
                .HasColumnType("text")
                .HasColumnName("response");
            entity.Property(e => e.ResponseTime).HasColumnName("response_time");
            entity.Property(e => e.Url)
                .HasMaxLength(255)
                .HasColumnName("url");
        });

        modelBuilder.Entity<UpdatedFaculty>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("updated_faculties");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.EvaluateeCode)
                .HasMaxLength(250)
                .HasColumnName("Evaluatee Code");
            entity.Property(e => e.EvaluateeDepartment)
                .HasMaxLength(250)
                .HasColumnName("Evaluatee Department");
            entity.Property(e => e.EvaluateeId).HasColumnName("evaluatee_id");
            entity.Property(e => e.EvaluateeName)
                .HasMaxLength(250)
                .HasColumnName("Evaluatee Name");
            entity.Property(e => e.EvaluatorCode)
                .HasMaxLength(250)
                .HasColumnName("Evaluator Code");
            entity.Property(e => e.EvaluatorDepartment)
                .HasMaxLength(250)
                .HasColumnName("Evaluator Department");
            entity.Property(e => e.EvaluatorId).HasColumnName("evaluator_id");
            entity.Property(e => e.EvaluatorName)
                .HasMaxLength(250)
                .HasColumnName("Evaluator Name");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
