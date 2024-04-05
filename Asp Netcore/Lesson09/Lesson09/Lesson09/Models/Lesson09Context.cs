using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Lesson09.Models;

public partial class Lesson09Context : DbContext
{
    public Lesson09Context()
    {
    }

    public Lesson09Context(DbContextOptions<Lesson09Context> options)
        : base(options)
    {
    }

    public virtual DbSet<Customer> Customers { get; set; }

//    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
//#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
//        => optionsBuilder.UseSqlServer("Server=DUONG-ITDVAPCF\\MSSQLSERVER01;Database=Lesson09;uid=sa;pwd=123456;MultipleActiveResultSets=True; TrustServerCertificate=True ");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Customer>(entity =>
        {
            entity.ToTable("CUSTOMER");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("ID");
            entity.Property(e => e.Address)
                .HasMaxLength(50)
                .HasColumnName("ADDRESS");
            entity.Property(e => e.Email)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("EMAIL");
            entity.Property(e => e.Fullname)
                .HasMaxLength(50)
                .IsFixedLength()
                .HasColumnName("FULLNAME");
            entity.Property(e => e.Password)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("PASSWORD");
            entity.Property(e => e.Phone)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("PHONE");
            entity.Property(e => e.Username)
                .HasMaxLength(50)
                .IsFixedLength()
                .HasColumnName("USERNAME");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
