using System;
using System.Collections.Generic;
using InformSystem.Forms;
using Microsoft.EntityFrameworkCore;

namespace InformSystem.dataBase;

public partial class PnppkContext : DbContext
{
    public PnppkContext()
    {
    }

    public PnppkContext(DbContextOptions<PnppkContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Access> Accesses { get; set; }

    public virtual DbSet<DepartmentDict> DepartmentDicts { get; set; }

    public virtual DbSet<Disk> Disks { get; set; }

    public virtual DbSet<Hardware> Hardwares { get; set; }

    public virtual DbSet<HardwareProperty> HardwareProperties { get; set; }

    public virtual DbSet<HardwareType> HardwareTypes { get; set; }

    public virtual DbSet<HardwareValue> HardwareValues { get; set; }

    public virtual DbSet<History> Histories { get; set; }

    public virtual DbSet<Place> Places { get; set; }

    public virtual DbSet<Repair> Repairs { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseMySQL($"Server=5.42.95.173;Database=pnppk;User Id={Login.login};Password={Login.password};");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Access>(entity =>
        {
            entity.HasKey(e => e.IdA).HasName("PRIMARY");

            entity.ToTable("Access");

            entity.HasIndex(e => e.HardwareA, "hardware_a");

            entity.Property(e => e.IdA)
                .HasColumnType("int(11)")
                .HasColumnName("ID_A");
            entity.Property(e => e.HardwareA)
                .HasColumnType("int(11)")
                .HasColumnName("hardware_a");
            entity.Property(e => e.Person)
                .HasColumnType("int(11)")
                .HasColumnName("person");

            entity.HasOne(d => d.HardwareANavigation).WithMany(p => p.Accesses)
                .HasForeignKey(d => d.HardwareA)
                .OnDelete(DeleteBehavior.Restrict)
                .HasConstraintName("access_ibfk_1");
        });

        modelBuilder.Entity<DepartmentDict>(entity =>
        {
            entity.HasKey(e => e.IdDd).HasName("PRIMARY");

            entity.ToTable("Department_Dict");

            entity.Property(e => e.IdDd)
                .HasColumnType("int(11)")
                .HasColumnName("ID_DD");
            entity.Property(e => e.NameD)
                .HasMaxLength(50)
                .HasColumnName("name_d");
        });

        modelBuilder.Entity<Disk>(entity =>
        {
            entity.HasKey(e => e.IdD).HasName("PRIMARY");

            entity.ToTable("Disk");

            entity.HasIndex(e => e.HardwareD, "hardware_d");

            entity.Property(e => e.IdD)
                .HasColumnType("int(11)")
                .HasColumnName("ID_D");
            entity.Property(e => e.Creator)
                .HasMaxLength(50)
                .HasColumnName("creator");
            entity.Property(e => e.HardwareD)
                .HasColumnType("int(11)")
                .HasColumnName("hardware_d");
            entity.Property(e => e.Model)
                .HasMaxLength(50)
                .HasColumnName("model");
            entity.Property(e => e.Size)
                .HasColumnType("int(11)")
                .HasColumnName("size");
            entity.Property(e => e.Type)
                .HasMaxLength(50)
                .HasColumnName("type");

            entity.HasOne(d => d.HardwareDNavigation).WithMany(p => p.Disks)
                .HasForeignKey(d => d.HardwareD)
                .OnDelete(DeleteBehavior.Restrict)
                .HasConstraintName("disk_ibfk_1");
        });

        modelBuilder.Entity<Hardware>(entity =>
        {
            entity.HasKey(e => e.IdH).HasName("PRIMARY");

            entity.ToTable("hardware");

            entity.HasIndex(e => e.Parent, "parent");

            entity.HasIndex(e => e.TypeH, "type_h");

            entity.Property(e => e.IdH)
                .HasColumnType("int(11)")
                .HasColumnName("ID_H");
            entity.Property(e => e.Iswork)
                .IsRequired()
                .HasDefaultValueSql("'1'")
                .HasColumnName("iswork");
            entity.Property(e => e.Parent)
                .HasColumnType("int(11)")
                .HasColumnName("parent");
            entity.Property(e => e.TypeH)
                .HasColumnType("int(11)")
                .HasColumnName("type_h");

            entity.HasOne(d => d.ParentNavigation).WithMany(p => p.InverseParentNavigation)
                .HasForeignKey(d => d.Parent)
                .OnDelete(DeleteBehavior.Restrict)
                .HasConstraintName("hardware_ibfk_2");

            entity.HasOne(d => d.TypeHNavigation).WithMany(p => p.Hardwares)
                .HasForeignKey(d => d.TypeH)
                .OnDelete(DeleteBehavior.Restrict)
                .HasConstraintName("hardware_ibfk_1");
        });

        modelBuilder.Entity<HardwareProperty>(entity =>
        {
            entity.HasKey(e => e.IdHp).HasName("PRIMARY");

            entity.ToTable("Hardware_Property");

            entity.HasIndex(e => e.TypeP, "type_p");

            entity.Property(e => e.IdHp)
                .HasColumnType("int(11)")
                .HasColumnName("ID_HP");
            entity.Property(e => e.NameP)
                .HasMaxLength(50)
                .HasColumnName("name_p");
            entity.Property(e => e.TypeP)
                .HasColumnType("int(11)")
                .HasColumnName("type_p");

            entity.HasOne(d => d.TypePNavigation).WithMany(p => p.HardwareProperties)
                .HasForeignKey(d => d.TypeP)
                .OnDelete(DeleteBehavior.Restrict)
                .HasConstraintName("hardware_property_ibfk_1");
        });

        modelBuilder.Entity<HardwareType>(entity =>
        {
            entity.HasKey(e => e.IdHt).HasName("PRIMARY");

            entity.ToTable("Hardware_Type");

            entity.Property(e => e.IdHt)
                .HasColumnType("int(11)")
                .HasColumnName("ID_HT");
            entity.Property(e => e.NameT)
                .HasMaxLength(20)
                .HasColumnName("name_t");
        });

        modelBuilder.Entity<HardwareValue>(entity =>
        {
            entity.HasKey(e => e.IdHv).HasName("PRIMARY");

            entity.ToTable("Hardware_Value");

            entity.HasIndex(e => e.HardwareV, "hardware_v");

            entity.HasIndex(e => e.Property, "property");

            entity.Property(e => e.IdHv)
                .HasColumnType("int(11)")
                .HasColumnName("ID_HV");
            entity.Property(e => e.HardwareV)
                .HasColumnType("int(11)")
                .HasColumnName("hardware_v");
            entity.Property(e => e.Property)
                .HasColumnType("int(11)")
                .HasColumnName("property");
            entity.Property(e => e.Value)
                .HasMaxLength(100)
                .HasColumnName("value");

            entity.HasOne(d => d.HardwareVNavigation).WithMany(p => p.HardwareValues)
                .HasForeignKey(d => d.HardwareV)
                .OnDelete(DeleteBehavior.Restrict)
                .HasConstraintName("hardware_value_ibfk_1");

            entity.HasOne(d => d.PropertyNavigation).WithMany(p => p.HardwareValues)
                .HasForeignKey(d => d.Property)
                .OnDelete(DeleteBehavior.Restrict)
                .HasConstraintName("hardware_value_ibfk_2");
        });

        modelBuilder.Entity<History>(entity =>
        {
            entity.HasKey(e => e.IdHi).HasName("PRIMARY");

            entity.ToTable("History");

            entity.HasIndex(e => e.Computer, "computer");

            entity.HasIndex(e => e.HardwareNew, "hardware_new");

            entity.HasIndex(e => e.HardwareOld, "hardware_old");

            entity.Property(e => e.IdHi)
                .HasColumnType("int(11)")
                .HasColumnName("ID_Hi");
            entity.Property(e => e.Computer)
                .HasColumnType("int(11)")
                .HasColumnName("computer");
            entity.Property(e => e.DateH)
                .HasDefaultValueSql("CURRENT_TIMESTAMP")
                .HasColumnType("timestamp")
                .HasColumnName("date_h");
            entity.Property(e => e.HardwareNew)
                .HasColumnType("int(11)")
                .HasColumnName("hardware_new");
            entity.Property(e => e.HardwareOld)
                .HasColumnType("int(11)")
                .HasColumnName("hardware_old");

            entity.HasOne(d => d.ComputerNavigation).WithMany(p => p.HistoryComputerNavigations)
                .HasForeignKey(d => d.Computer)
                .OnDelete(DeleteBehavior.Restrict)
                .HasConstraintName("history_ibfk_1");

            entity.HasOne(d => d.HardwareNewNavigation).WithMany(p => p.HistoryHardwareNewNavigations)
                .HasForeignKey(d => d.HardwareNew)
                .OnDelete(DeleteBehavior.Restrict)
                .HasConstraintName("history_ibfk_2");

            entity.HasOne(d => d.HardwareOldNavigation).WithMany(p => p.HistoryHardwareOldNavigations)
                .HasForeignKey(d => d.HardwareOld)
                .OnDelete(DeleteBehavior.Restrict)
                .HasConstraintName("history_ibfk_3");
        });

        modelBuilder.Entity<Place>(entity =>
        {
            entity.HasKey(e => e.IdP).HasName("PRIMARY");

            entity.ToTable("Place");

            entity.HasIndex(e => e.DepartmentId, "department_id");

            entity.HasIndex(e => e.HardwareP, "hardware_p");

            entity.Property(e => e.IdP)
                .HasColumnType("int(11)")
                .HasColumnName("ID_P");
            entity.Property(e => e.Building)
                .HasColumnType("int(11)")
                .HasColumnName("building");
            entity.Property(e => e.Data)
                .HasColumnType("date")
                .HasColumnName("data");
            entity.Property(e => e.DepartmentId)
                .HasColumnType("int(11)")
                .HasColumnName("department_id");
            entity.Property(e => e.Floor)
                .HasColumnType("int(11)")
                .HasColumnName("floor");
            entity.Property(e => e.HardwareP)
                .HasColumnType("int(11)")
                .HasColumnName("hardware_p");
            entity.Property(e => e.Office)
                .HasColumnType("int(11)")
                .HasColumnName("office");

            entity.HasOne(d => d.Department).WithMany(p => p.Places)
                .HasForeignKey(d => d.DepartmentId)
                .OnDelete(DeleteBehavior.Restrict)
                .HasConstraintName("place_ibfk_2");

            entity.HasOne(d => d.HardwarePNavigation).WithMany(p => p.Places)
                .HasForeignKey(d => d.HardwareP)
                .OnDelete(DeleteBehavior.Restrict)
                .HasConstraintName("place_ibfk_1");
        });

        modelBuilder.Entity<Repair>(entity =>
        {
            entity.HasKey(e => e.IdR).HasName("PRIMARY");

            entity.ToTable("Repair");

            entity.HasIndex(e => e.HardwareR, "hardware_r");

            entity.Property(e => e.IdR)
                .HasColumnType("int(11)")
                .HasColumnName("ID_R");
            entity.Property(e => e.DateIn)
                .HasColumnType("date")
                .HasColumnName("date_in");
            entity.Property(e => e.DateOut)
                .HasColumnType("date")
                .HasColumnName("date_out");
            entity.Property(e => e.DocumentIn)
                .HasColumnType("int(11)")
                .HasColumnName("document_in");
            entity.Property(e => e.DocumentOut)
                .HasColumnType("int(11)")
                .HasColumnName("document_out");
            entity.Property(e => e.HardwareR)
                .HasColumnType("int(11)")
                .HasColumnName("hardware_r");
            entity.Property(e => e.Reason)
                .HasMaxLength(50)
                .HasDefaultValueSql("'неизвестно'")
                .HasColumnName("reason");
            entity.Property(e => e.Verdict)
                .HasMaxLength(50)
                .HasColumnName("verdict");

            entity.HasOne(d => d.HardwareRNavigation).WithMany(p => p.Repairs)
                .HasForeignKey(d => d.HardwareR)
                .OnDelete(DeleteBehavior.Restrict)
                .HasConstraintName("repair_ibfk_1");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
