using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace EFCore_Assignment_2.Enities;

public partial class EfcoreContext : DbContext
{
    public EfcoreContext()
    {
    }

    public EfcoreContext(DbContextOptions<EfcoreContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Course> Courses { get; set; }

    public virtual DbSet<Department> Departments { get; set; }

    public virtual DbSet<Enrollment> Enrollments { get; set; }

    public virtual DbSet<Student> Students { get; set; }

    public virtual DbSet<Teacher> Teachers { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Data Source=.\\SQLEXPRESS;Initial Catalog=EFCore;Integrated Security=True;Encrypt=True;Trust Server Certificate=True");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Course>(entity =>
        {
            entity.Property(e => e.Title).HasDefaultValue("");
        });

        modelBuilder.Entity<Department>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Departme__3214EC077A89F5CE");

            entity.ToTable("Department");

            entity.Property(e => e.Name).HasMaxLength(100);
        });

        modelBuilder.Entity<Enrollment>(entity =>
        {
            entity.HasIndex(e => e.CourseId, "IX_Enrollments_courseId");

            entity.HasIndex(e => e.StudentId, "IX_Enrollments_studentId");

            entity.Property(e => e.CourseId).HasColumnName("courseId");
            entity.Property(e => e.Grade).HasMaxLength(1);
            entity.Property(e => e.StudentId).HasColumnName("studentId");

            entity.HasOne(d => d.Course).WithMany(p => p.Enrollments).HasForeignKey(d => d.CourseId);

            entity.HasOne(d => d.Student).WithMany(p => p.Enrollments).HasForeignKey(d => d.StudentId);
        });

        modelBuilder.Entity<Student>(entity =>
        {
            entity.Property(e => e.Name)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValue("");
        });

        modelBuilder.Entity<Teacher>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Teacher__3214EC07BB3CAD9A");

            entity.ToTable("Teacher");

            entity.Property(e => e.Name).HasMaxLength(100);

            entity.HasOne(d => d.Department).WithMany(p => p.Teachers)
                .HasForeignKey(d => d.DepartmentId)
                .HasConstraintName("FK__Teacher__Departm__04E4BC85");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
