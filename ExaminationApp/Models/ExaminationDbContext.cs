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

    public virtual DbSet<StudAnswer> StudAnswers { get; set; }

    public virtual DbSet<StudExam> StudExams { get; set; }

    public virtual DbSet<Student> Students { get; set; }

    public virtual DbSet<Topic> Topics { get; set; }

    public virtual DbSet<User> Users { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=Dina;Database=ExaminationDB;Trusted_Connection=True;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Course>(entity =>
        {
            entity.HasKey(e => e.CrsId).HasName("PK__Course__ECAF5375E914BAB3");

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
            entity.HasKey(e => e.DeptId).HasName("PK__Departme__DCA65974647F8EE3");

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
            entity.HasKey(e => e.ExamId).HasName("PK__Exam__C782CA59D3567799");

            entity.ToTable("Exam");

            entity.Property(e => e.ExamId)
                .ValueGeneratedNever()
                .HasColumnName("Exam_Id");
            entity.Property(e => e.CrsId).HasColumnName("Crs_Id");
            entity.Property(e => e.ExamDuration).HasColumnName("Exam_Duration");
            entity.Property(e => e.PassScore).HasColumnName("Pass_Score");

            entity.HasOne(d => d.Crs).WithMany(p => p.Exams)
                .HasForeignKey(d => d.CrsId)
                .HasConstraintName("FK_Crs_Exam");
        });

        modelBuilder.Entity<Instructor>(entity =>
        {
            entity.HasKey(e => e.InsId).HasName("PK__Instruct__9CB72D2063A3B640");

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
                        .HasConstraintName("FK_Ins_Course_Course"),
                    l => l.HasOne<Instructor>().WithMany()
                        .HasForeignKey("InsId")
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("FK_Ins_Course_Instructor"),
                    j =>
                    {
                        j.HasKey("InsId", "CrsId");
                        j.ToTable("Ins_Course");
                        j.IndexerProperty<int>("InsId").HasColumnName("Ins_Id");
                        j.IndexerProperty<int>("CrsId").HasColumnName("Crs_Id");
                    });
        });

        modelBuilder.Entity<Question>(entity =>
        {
            entity.HasKey(e => e.QuesId).HasName("PK__Question__A821235E0E89713E");

            entity.ToTable("Question");

            entity.Property(e => e.QuesId)
                .ValueGeneratedNever()
                .HasColumnName("Ques_Id");
            entity.Property(e => e.Choice1)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Choice2)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Choice3)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.CorrectAnswer)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Correct_Answer");
            entity.Property(e => e.CrsId).HasColumnName("Crs_Id");
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

            entity.HasMany(d => d.Exams).WithMany(p => p.Ques)
                .UsingEntity<Dictionary<string, object>>(
                    "ExamQue",
                    r => r.HasOne<Exam>().WithMany()
                        .HasForeignKey("ExamId")
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("FK_Exam_Ques_Exam"),
                    l => l.HasOne<Question>().WithMany()
                        .HasForeignKey("QuesId")
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("FK_Exam_Ques_Question"),
                    j =>
                    {
                        j.HasKey("QuesId", "ExamId");
                        j.ToTable("Exam_Ques");
                        j.IndexerProperty<int>("QuesId").HasColumnName("Ques_Id");
                        j.IndexerProperty<int>("ExamId").HasColumnName("Exam_Id");
                    });
        });

        modelBuilder.Entity<StudAnswer>(entity =>
        {
            entity.HasKey(e => e.AnsId);

            entity.ToTable("Stud_Answer");

            entity.Property(e => e.AnsId)
                .ValueGeneratedNever()
                .HasColumnName("Ans_Id");
            entity.Property(e => e.ExamId).HasColumnName("Exam_Id");
            entity.Property(e => e.QuesId).HasColumnName("Ques_Id");
            entity.Property(e => e.SelectedAnswer)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasColumnName("Selected_Answer");
            entity.Property(e => e.StId).HasColumnName("St_Id");

            entity.HasOne(d => d.Exam).WithMany(p => p.StudAnswers)
                .HasForeignKey(d => d.ExamId)
                .HasConstraintName("FK_Stud_Answer_Exam");

            entity.HasOne(d => d.Ques).WithMany(p => p.StudAnswers)
                .HasForeignKey(d => d.QuesId)
                .HasConstraintName("FK_Stud_Answer_Question");

            entity.HasOne(d => d.St).WithMany(p => p.StudAnswers)
                .HasForeignKey(d => d.StId)
                .HasConstraintName("FK_Stud_Answer_Student");
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
        });

        modelBuilder.Entity<Student>(entity =>
        {
            entity.HasKey(e => e.StdId).HasName("PK__Student__0B0245BABE0D9F0B");

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

            entity.HasMany(d => d.Crs).WithMany(p => p.Sts)
                .UsingEntity<Dictionary<string, object>>(
                    "StudCourse",
                    r => r.HasOne<Course>().WithMany()
                        .HasForeignKey("CrsId")
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("FK_Stud_Course_Course"),
                    l => l.HasOne<Student>().WithMany()
                        .HasForeignKey("StId")
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("FK_Stud_Course_Student"),
                    j =>
                    {
                        j.HasKey("StId", "CrsId");
                        j.ToTable("Stud_Course");
                        j.IndexerProperty<int>("StId").HasColumnName("St_Id");
                        j.IndexerProperty<int>("CrsId").HasColumnName("Crs_Id");
                    });
        });

        modelBuilder.Entity<Topic>(entity =>
        {
            entity.HasKey(e => e.TopicId).HasName("PK__Topic__D5DAA3E925E5044D");

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
            entity.HasKey(e => e.UserId).HasName("PK__Users__CB9A1CFF04F425B3");

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
