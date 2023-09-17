using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Client.WebApi.Models;

public partial class DbcustomerContext : DbContext
{
    public DbcustomerContext()
    {
    }

    public DbcustomerContext(DbContextOptions<DbcustomerContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Clients> Clients { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {

    }
    
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Clients>(entity =>
        {
            entity.HasKey(e => e.IdClient).HasName("PK__Client__C1961B338898E160");

            entity.ToTable("Client");

            entity.Property(e => e.BirthDate).HasColumnType("datetime");
            entity.Property(e => e.Direction)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("direction");
            entity.Property(e => e.NameClient)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
