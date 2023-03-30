using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace ExaminationApp.Models;

public partial class ExaminationDbContext : DbContext
{
    public ExaminationDbContext()
    {
    }

    public ExaminationDbContext(DbContextOptions<ExaminationDbContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Course> Courses { get; set; }

    public virtual DbSet<Department> Departments { get; set; }

    public virtual DbSet<Exam> Exams { get; set; }

    public virtual DbSet<Instructor> Instructors { get; set; }

    public virtual DbSet<Question> Questions { get; set; }

    public virtual DbSet<StdAnswer> StdAnswers { get; set; }

    public virtual DbSet<StudExam> StudExams { get; set; }

    public virtual DbSet<Student> Students { get; set; }

    public virtual DbSet<Topic> Topics { get; set; }

    public virtual DbSet<User> Users { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Data Source=.;Initial Catalog=ExaminationDB; Trusted_Connection=true; encrypt=false;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Course>(entity =>
        {
            entity.HasKey(e => e.CrsId).HasName("PK__Course__ECAF537566760A60");

            entity.ToTable("Course");

            entity.Property(e => e.CrsId)
                .ValueGeneratedNever()
                .HasColumnName("crs_id");
            entity.Property(e => e.CrsDuration).HasColumnName("crs_duration");
            entity.Property(e => e.CrsName)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("crs_name");
            entity.Property(e => e.TopicId).HasColumnName("topic_id");

            entity.HasOne(d => d.Topic).WithMany(p => p.Courses)
                .HasForeignKey(d => d.TopicId)
                .HasConstraintName("topic_fk");
        });

        modelBuilder.Entity<Department>(entity =>
        {
            entity.HasKey(e => e.DeptId).HasName("PK__Departme__DCA6597406A12009");

            entity.ToTable("Department");

            entity.Property(e => e.DeptId)
                .ValueGeneratedNever()
                .HasColumnName("dept_id");
            entity.Property(e => e.DeptName)
                .HasMaxLength(40)
                .IsUnicode(false)
                .HasColumnName("dept_name");
        });

        modelBuilder.Entity<Exam>(entity =>
        {
            entity.HasKey(e => e.ExamId).HasName("PK__Exam__C782CA59F15E0701");

            entity.ToTable("Exam");

            entity.Property(e => e.ExamId).HasColumnName("Exam_Id");
            entity.Property(e => e.CrsId).HasColumnName("Crs_Id");
            entity.Property(e => e.ExamDuration).HasColumnName("Exam_Duration");
            entity.Property(e => e.PassScore).HasColumnName("Pass_Score");

            entity.HasOne(d => d.Crs).WithMany(p => p.Exams)
                .HasForeignKey(d => d.CrsId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Crs_Exam");

            entity.HasMany(d => d.Quests).WithMany(p => p.Exams)
                .UsingEntity<Dictionary<string, object>>(
                    "ExamQuestion",
                    r => r.HasOne<Question>().WithMany()
                        .HasForeignKey("QuestId")
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("FK_QUES"),
                    l => l.HasOne<Exam>().WithMany()
                        .HasForeignKey("ExamId")
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("FK_EXAM_QUESTION"),
                    j =>
                    {
                        j.HasKey("ExamId", "QuestId").HasName("COPOSITE_PRIMARY");
                        j.ToTable("Exam_Question");
                        j.IndexerProperty<int>("ExamId").HasColumnName("exam_id");
                        j.IndexerProperty<int>("QuestId").HasColumnName("quest_id");
                    });
        });

        modelBuilder.Entity<Instructor>(entity =>
        {
            entity.HasKey(e => e.InsId).HasName("PK__Instruct__9CB72D2084B35B67");

            entity.ToTable("Instructor");

            entity.HasIndex(e => e.InsEmail, "INS_EMAIL").IsUnique();

            entity.Property(e => e.InsId).HasColumnName("ins_id");
            entity.Property(e => e.DeptId).HasColumnName("dept_id");
            entity.Property(e => e.InsEmail)
                .HasMaxLength(40)
                .IsUnicode(false)
                .HasColumnName("ins_email");
            entity.Property(e => e.InsName)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("ins_name");
            entity.Property(e => e.InsPassword)
                .HasMaxLength(12)
                .IsUnicode(false)
                .HasColumnName("ins_password");

            entity.HasOne(d => d.Dept).WithMany(p => p.Instructors)
                .HasForeignKey(d => d.DeptId)
                .HasConstraintName("INS_FK");

            entity.HasMany(d => d.Crs).WithMany(p => p.Ins)
                .UsingEntity<Dictionary<string, object>>(
                    "InsCourse",
                    r => r.HasOne<Course>().WithMany()
                        .HasForeignKey("CrsId")
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("FK_COURSE"),
                    l => l.HasOne<Instructor>().WithMany()
                        .HasForeignKey("InsId")
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("FK_INST"),
                    j =>
                    {
                        j.HasKey("InsId", "CrsId").HasName("PK_INS_COURSE");
                        j.ToTable("Ins_Course");
                        j.IndexerProperty<int>("InsId").HasColumnName("ins_id");
                        j.IndexerProperty<int>("CrsId").HasColumnName("crs_id");
                    });
        });

        modelBuilder.Entity<Question>(entity =>
        {
            entity.HasKey(e => e.QuesId).HasName("PK__Question__A821235ED6C1C177");

            entity.ToTable("Question");

            entity.Property(e => e.QuesId)
                .ValueGeneratedNever()
                .HasColumnName("Ques_Id");
            entity.Property(e => e.ChoiceA)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("choice_a");
            entity.Property(e => e.ChoiceB)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("choice_b");
            entity.Property(e => e.ChoiceC)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("choice_c");
            entity.Property(e => e.CorrectAnswer)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("Correct_Answer");
            entity.Property(e => e.CrsId).HasColumnName("crs_id");
            entity.Property(e => e.QuesBody)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Ques_Body");
            entity.Property(e => e.QuesType)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Ques_Type");

            entity.HasOne(d => d.Crs).WithMany(p => p.Questions)
                .HasForeignKey(d => d.CrsId)
                .HasConstraintName("FK_Question_Course");
        });

        modelBuilder.Entity<StdAnswer>(entity =>
        {
            entity.HasKey(e => e.AnsId);

            entity.ToTable("std_answer");

            entity.Property(e => e.AnsId).HasColumnName("Ans_Id");
            entity.Property(e => e.ExamId).HasColumnName("Exam_Id");
            entity.Property(e => e.QuesId).HasColumnName("Ques_Id");
            entity.Property(e => e.SelectedAnswer)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasColumnName("Selected_Answer");
            entity.Property(e => e.StdId).HasColumnName("std_id");

            entity.HasOne(d => d.Exam).WithMany(p => p.StdAnswers)
                .HasForeignKey(d => d.ExamId)
                .HasConstraintName("FK_std_answer_Exam");

            entity.HasOne(d => d.Ques).WithMany(p => p.StdAnswers)
                .HasForeignKey(d => d.QuesId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_std_answer_Question");

            entity.HasOne(d => d.Std).WithMany(p => p.StdAnswers)
                .HasForeignKey(d => d.StdId)
                .HasConstraintName("FK_std_answer_Student");
        });

        modelBuilder.Entity<StudExam>(entity =>
        {
            entity.HasKey(e => new { e.StId, e.ExamId });

            entity.ToTable("Stud_Exam");

            entity.Property(e => e.StId).HasColumnName("St_Id");
            entity.Property(e => e.ExamId).HasColumnName("Exam_Id");
            entity.Property(e => e.ExamDate)
                .HasColumnType("date")
                .HasColumnName("Exam_Date");
            entity.Property(e => e.StScore).HasColumnName("St_Score");
            entity.Property(e => e.Status)
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.HasOne(d => d.Exam).WithMany(p => p.StudExams)
                .HasForeignKey(d => d.ExamId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Stud_Exam_Exam");

            entity.HasOne(d => d.St).WithMany(p => p.StudExams)
                .HasForeignKey(d => d.StId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Stud_Exam_Student");
        });

        modelBuilder.Entity<Student>(entity =>
        {
            entity.HasKey(e => e.StdId).HasName("PK__Student__0B0245BA13FAB992");

            entity.ToTable("Student");

            entity.HasIndex(e => e.StdEmail, "UNQ").IsUnique();

            entity.Property(e => e.StdId).HasColumnName("std_id");
            entity.Property(e => e.DeptId).HasColumnName("dept_id");
            entity.Property(e => e.StdAddress)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("std_address");
            entity.Property(e => e.StdAge).HasColumnName("std_age");
            entity.Property(e => e.StdEmail)
                .HasMaxLength(40)
                .IsUnicode(false)
                .HasColumnName("std_email");
            entity.Property(e => e.StdFname)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("std_fname");
            entity.Property(e => e.StdLname)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("std_lname");
            entity.Property(e => e.StdPassword)
                .HasMaxLength(12)
                .IsUnicode(false)
                .HasColumnName("std_password");

            entity.HasOne(d => d.Dept).WithMany(p => p.Students)
                .HasForeignKey(d => d.DeptId)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("FK");

            entity.HasMany(d => d.Crs).WithMany(p => p.Stds)
                .UsingEntity<Dictionary<string, object>>(
                    "StdCourse",
                    r => r.HasOne<Course>().WithMany()
                        .HasForeignKey("CrsId")
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("FK_Std_Course_Course"),
                    l => l.HasOne<Student>().WithMany()
                        .HasForeignKey("StdId")
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("FK_Std_Course_Student"),
                    j =>
                    {
                        j.HasKey("StdId", "CrsId");
                        j.ToTable("Std_Course");
                        j.HasIndex(new[] { "StdId" }, "IX_Std_Course");
                        j.IndexerProperty<int>("StdId").HasColumnName("std_id");
                        j.IndexerProperty<int>("CrsId").HasColumnName("crs_id");
                    });
        });

        modelBuilder.Entity<Topic>(entity =>
        {
            entity.HasKey(e => e.TopicId).HasName("PK__Topic__D5DAA3E9259D8D54");

            entity.ToTable("Topic");

            entity.Property(e => e.TopicId)
                .ValueGeneratedNever()
                .HasColumnName("topic_id");
            entity.Property(e => e.TopicName)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("topic_name");
        });

        modelBuilder.Entity<User>(entity =>
        {
            entity.HasKey(e => e.UserId).HasName("PK__Users__CB9A1CFFFEEFDE9B");

            entity.Property(e => e.UserId).HasColumnName("userId");
            entity.Property(e => e.UserEmail)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("userEmail");
            entity.Property(e => e.UserPassword)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("userPassword");
            entity.Property(e => e.UserRole)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("userRole");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
