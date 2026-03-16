using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace ONEtoONEapi.Models;

public partial class OnetoOneApiContext : DbContext
{
    public OnetoOneApiContext()
    {
    }

    public OnetoOneApiContext(DbContextOptions<OnetoOneApiContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Hostel> Hostels { get; set; }

    public virtual DbSet<Student> Students { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Data Source=.\\SQLEXPRESS;Initial Catalog=OnetoOneAPI;Integrated Security=True;Connect Timeout=30;Encrypt=True;TrustServerCertificate=True;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Hostel>(entity =>
        {
            entity.HasKey(e => e.HostelId).HasName("PK__Hostel__677EEB28CC480EBD");

            entity.ToTable("Hostel");
        });

        modelBuilder.Entity<Student>(entity =>
        {
            entity.HasKey(e => e.StudentId).HasName("PK__Student__32C52B998E622AD6");

            entity.ToTable("Student");

            entity.HasIndex(e => e.HostelId, "UQ__Student__677EEB29B6B8BE12").IsUnique();

            entity.Property(e => e.Name)
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.HasOne(d => d.Hostel).WithOne(p => p.Student)
                .HasForeignKey<Student>(d => d.HostelId)
                .HasConstraintName("FK__Student__HostelI__5FB337D6");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
