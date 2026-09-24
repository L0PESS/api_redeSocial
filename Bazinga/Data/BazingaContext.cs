using System;
using System.Collections.Generic;
using Bazinga.Models;
using Microsoft.EntityFrameworkCore;

namespace Bazinga.Data;

public partial class BazingaContext : DbContext
{
    public BazingaContext()
    {
    }

    public BazingaContext(DbContextOptions<BazingaContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Comentario> Comentario { get; set; }

    public virtual DbSet<Curtida> Curtida { get; set; }

    public virtual DbSet<Post> Post { get; set; }

    public virtual DbSet<Usuario> Usuario { get; set; }

    

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Comentario>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Comentar__3214EC07B4F3DB2A");

            entity.Property(e => e.CriadoEm).HasDefaultValueSql("(sysutcdatetime())");
            entity.Property(e => e.Texto).HasMaxLength(500);

            entity.HasOne(d => d.Post).WithMany(p => p.Comentario)
                .HasForeignKey(d => d.Post_Id)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Comentario_Post");

            entity.HasOne(d => d.Usuario).WithMany(p => p.Comentario)
                .HasForeignKey(d => d.Usuario_Id)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Comentario_Usuario");
        });

        modelBuilder.Entity<Curtida>(entity =>
        {
            entity.HasKey(e => new { e.Usuario_Id, e.Post_Id });

            entity.Property(e => e.CriadoEm).HasDefaultValueSql("(sysutcdatetime())");

            entity.HasOne(d => d.Post).WithMany(p => p.Curtida)
                .HasForeignKey(d => d.Post_Id)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Curtida_Post");

            entity.HasOne(d => d.Usuario).WithMany(p => p.Curtida)
                .HasForeignKey(d => d.Usuario_Id)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Curtida_Usuario");
        });

        modelBuilder.Entity<Post>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Post__3214EC07BC1E752A");

            entity.Property(e => e.CriadoEm).HasDefaultValueSql("(sysutcdatetime())");
            entity.Property(e => e.ImagemUrl)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.Texto).HasMaxLength(255);

            entity.HasOne(d => d.Usuario).WithMany(p => p.Post)
                .HasForeignKey(d => d.Usuario_Id)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Post_Usuario");
        });

        modelBuilder.Entity<Usuario>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Usuario__3214EC077105D4BF");

            entity.HasIndex(e => e.Email, "UQ__Usuario__A9D10534BC9252EA").IsUnique();

            entity.Property(e => e.Email).HasMaxLength(150);
            entity.Property(e => e.Nome).HasMaxLength(100);
            entity.Property(e => e.SenhaHash)
                .HasMaxLength(255)
                .IsUnicode(false);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
