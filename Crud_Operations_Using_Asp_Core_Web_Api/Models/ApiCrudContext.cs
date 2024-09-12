using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Crud_Operations_Using_Asp_Core_Web_Api.Models;

public partial class ApiCrudContext : DbContext
{
    public ApiCrudContext()
    {
    }

    public ApiCrudContext(DbContextOptions<ApiCrudContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Student> Students { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {

    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Student>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__tmp_ms_x__3214EC072E8EDAC1");

            entity.Property(e => e.FatherName).HasMaxLength(50);
            entity.Property(e => e.Gender).HasMaxLength(15);
            entity.Property(e => e.Name).HasMaxLength(50);
            entity.Property(e => e.Standard).HasMaxLength(20);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
