using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using ASP.NETCore_Exercise10.Models;

namespace ASP.NETCore_Exercise10.Data;

public partial class AircraftDbContext : DbContext
{
    public AircraftDbContext()
    {
    }

    public AircraftDbContext(DbContextOptions<AircraftDbContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Aircraft> Aircraft { get; set; }

//    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
//#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
//        => optionsBuilder.UseSqlServer("Server=tcp:fy2603.database.windows.net,1433;Initial Catalog=AzureProductsDb;Persist Security Info=False;User ID=rafael.g.a.tolentino;Password=Zmqpal@12;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Aircraft>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Aircraft__3214EC277F93AAA1");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.CabinLength).HasMaxLength(100);
            entity.Property(e => e.CargoD3capacity)
                .HasMaxLength(100)
                .HasColumnName("CargoD3Capacity");
            entity.Property(e => e.FuselageWidth).HasMaxLength(100);
            entity.Property(e => e.Height).HasMaxLength(100);
            entity.Property(e => e.ImageUrl).HasMaxLength(500);
            entity.Property(e => e.MaxCabinWidth).HasMaxLength(100);
            entity.Property(e => e.MaxFuelCapacity).HasMaxLength(100);
            entity.Property(e => e.MaxLandingWeight).HasMaxLength(100);
            entity.Property(e => e.MaxRampWeight).HasMaxLength(100);
            entity.Property(e => e.MaxTakeOffWeight).HasMaxLength(100);
            entity.Property(e => e.Mmo)
                .HasMaxLength(50)
                .HasColumnName("MMO");
            entity.Property(e => e.Model).HasMaxLength(100);
            entity.Property(e => e.Name).HasMaxLength(200);
            entity.Property(e => e.OverallLength).HasMaxLength(100);
            entity.Property(e => e.PerformanceRange).HasMaxLength(100);
            entity.Property(e => e.ProductNumber).HasMaxLength(50);
            entity.Property(e => e.Track).HasMaxLength(100);
            entity.Property(e => e.WaterVolume).HasMaxLength(100);
            entity.Property(e => e.Wheelbase).HasMaxLength(100);
            entity.Property(e => e.WingSpan).HasMaxLength(100);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
