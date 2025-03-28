using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace StudentQuiz.Models;

public partial class FelixDbContext : DbContext
{
    public FelixDbContext()
    {
    }

    public FelixDbContext(DbContextOptions<FelixDbContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Answer> Answers { get; set; }

    public virtual DbSet<Class> Classes { get; set; }

    public virtual DbSet<Enrollment> Enrollments { get; set; }

    public virtual DbSet<Question> Questions { get; set; }

    public virtual DbSet<Quiz> Quizzes { get; set; }

    public virtual DbSet<Semester> Semesters { get; set; }

    public virtual DbSet<User> Users { get; set; }

 

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Answer>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__answer__3213E83F52A35ABB");

            entity.ToTable("answer");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.AnswerText)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("answer_text");
            entity.Property(e => e.CorrectValue)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValue("F")
                .IsFixedLength()
                .HasColumnName("correct_value");
            entity.Property(e => e.QuestionId).HasColumnName("question_id");

            entity.HasOne(d => d.Question).WithMany(p => p.Answers)
                .HasForeignKey(d => d.QuestionId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__answer__question__40058253");
        });

        modelBuilder.Entity<Class>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__class__3213E83FC16B3A9C");

            entity.ToTable("class");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Department)
                .HasMaxLength(4)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("department");
            entity.Property(e => e.EndTime)
                .HasColumnType("datetime")
                .HasColumnName("end_time");
            entity.Property(e => e.Number)
                .HasMaxLength(4)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("number");
            entity.Property(e => e.ProfId).HasColumnName("prof_id");
            entity.Property(e => e.Section)
                .HasMaxLength(3)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("section");
            entity.Property(e => e.SemesterId).HasColumnName("semester_id");
            entity.Property(e => e.StartTime)
                .HasColumnType("datetime")
                .HasColumnName("start_time");

            entity.HasOne(d => d.Prof).WithMany(p => p.Classes)
                .HasForeignKey(d => d.ProfId)
                .HasConstraintName("FK__class__prof_id__6FE99F9F");

            entity.HasOne(d => d.Semester).WithMany(p => p.Classes)
                .HasForeignKey(d => d.SemesterId)
                .HasConstraintName("fk_semesterID");
        });

        modelBuilder.Entity<Enrollment>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("enrollment");

            entity.Property(e => e.ClassId).HasColumnName("class_id");
            entity.Property(e => e.UserId).HasColumnName("user_id");

            entity.HasOne(d => d.Class).WithMany()
                .HasForeignKey(d => d.ClassId)
                .HasConstraintName("FK__enrollmen__class__0E6E26BF");

            entity.HasOne(d => d.User).WithMany()
                .HasForeignKey(d => d.UserId)
                .HasConstraintName("FK__enrollmen__user___0D7A0286");
        });

        modelBuilder.Entity<Question>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__question__3213E83FA1F5F945");

            entity.ToTable("question");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.ClassId).HasColumnName("class_id");
            entity.Property(e => e.QuestionText)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("question_text");

            entity.HasOne(d => d.Class).WithMany(p => p.Questions)
                .HasForeignKey(d => d.ClassId)
                .HasConstraintName("FK__question__class___3C34F16F");
        });

        modelBuilder.Entity<Quiz>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__quiz__3213E83F977011AC");

            entity.ToTable("quiz");

            entity.HasIndex(e => e.Password, "UQ__quiz__6E2DBEDEC605EF87").IsUnique();

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Password)
                .HasMaxLength(20)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("password");
            entity.Property(e => e.Title)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("title");
            entity.Property(e => e.ValidateAnswers)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValue("T")
                .IsFixedLength()
                .HasColumnName("validate_answers");

            entity.HasMany(d => d.Questions).WithMany(p => p.Quizzes)
                .UsingEntity<Dictionary<string, object>>(
                    "QuizQuestion",
                    r => r.HasOne<Question>().WithMany()
                        .HasForeignKey("QuestionId")
                        .HasConstraintName("FK__quiz_ques__quest__489AC854"),
                    l => l.HasOne<Quiz>().WithMany()
                        .HasForeignKey("QuizId")
                        .HasConstraintName("FK__quiz_ques__quiz___47A6A41B"),
                    j =>
                    {
                        j.HasKey("QuizId", "QuestionId").HasName("PK__quiz_que__AF9C72B84845E5B0");
                        j.ToTable("quiz_question");
                        j.IndexerProperty<int>("QuizId").HasColumnName("quiz_id");
                        j.IndexerProperty<int>("QuestionId").HasColumnName("question_id");
                    });
        });

        modelBuilder.Entity<Semester>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__semester__3213E83F5233365D");

            entity.ToTable("semester");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Description)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("description");
            entity.Property(e => e.EndDate).HasColumnName("end_date");
            entity.Property(e => e.StartDate).HasColumnName("start_date");
        });

        modelBuilder.Entity<User>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__users__3213E83F8DBC25EB");

            entity.ToTable("users");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Firstname)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasColumnName("firstname");
            entity.Property(e => e.Lastname)
                .HasMaxLength(35)
                .IsUnicode(false)
                .HasColumnName("lastname");
            entity.Property(e => e.LoginId)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("login_id");
            entity.Property(e => e.Passcode)
                .HasMaxLength(35)
                .IsUnicode(false)
                .HasColumnName("passcode");
            entity.Property(e => e.StudentId)
                .HasMaxLength(12)
                .IsUnicode(false)
                .HasColumnName("student_id");
            entity.Property(e => e.UserRole)
                .HasMaxLength(7)
                .IsUnicode(false)
                .HasDefaultValue("STUDENT")
                .IsFixedLength()
                .HasColumnName("user_role");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
