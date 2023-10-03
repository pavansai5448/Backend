using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Tinting_Banco_D180_Bangalore.Models;

public partial class TintingDepotRecordsContext : DbContext
{
    public TintingDepotRecordsContext()
    {
    }

    public TintingDepotRecordsContext(DbContextOptions<TintingDepotRecordsContext> options)
        : base(options)
    {
    }

    public virtual DbSet<LoginPage> LoginPages { get; set; }

    public virtual DbSet<Observation> Observations { get; set; }

    public virtual DbSet<TintingBancoD180Bangalore> TintingBancoD180Bangalores { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseNpgsql("Host=localhost;Database=Tinting_Depot_Records;Username=postgres;Password=root");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<LoginPage>(entity =>
        {
            entity.HasKey(e => e.Username).HasName("LoginPage_pkey");

            entity.ToTable("LoginPage");
        });

        modelBuilder.Entity<Observation>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("Observation_pkey");

            entity.ToTable("Observation");

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.BaseTintedAsPerHistoryFileInLit).HasColumnName("Base_Tinted_As_Per_History_File_In_Lit");
            entity.Property(e => e.BaseTintedAsPerReportInLit).HasColumnName("Base_Tinted_As_Per_Report_In_Lit");
            entity.Property(e => e.BrandlingForDispensingMachine).HasColumnName("Brandling_For_Dispensing_Machine");
            entity.Property(e => e.BrandlingForGyroshakerMachine).HasColumnName("Brandling_For_Gyroshaker_Machine");
            entity.Property(e => e.ColorantConsumedInLit).HasColumnName("Colorant_Consumed_In_Lit");
            entity.Property(e => e.ColorantPouredInCannistersInLit).HasColumnName("Colorant_Poured_In_Cannisters_In_Lit");
        });

        modelBuilder.Entity<TintingBancoD180Bangalore>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("Tinting-Banco&D180-Bangalore_pkey");

            entity.ToTable("Tinting-Banco&D180-Bangalore");

            entity.Property(e => e.BaseBatchNo).HasColumnName("Base_Batch_No");
            entity.Property(e => e.DispensingMachine).HasColumnName("Dispensing_Machine");
            entity.Property(e => e.ForProjectOrRetail).HasColumnName("For_Project_Or_Retail");
            entity.Property(e => e.FormulationFor1LitrePackSize).HasColumnName("Formulation_For_1_Litre_Pack_Size");
            entity.Property(e => e.NameOfTheProject).HasColumnName("Name_Of_The_Project");
            entity.Property(e => e.OtherObservations).HasColumnName("Other_Observations");
            entity.Property(e => e.QuantityTintedInLitres).HasColumnName("Quantity_Tinted_In_Litres");
            entity.Property(e => e.ShadeCode).HasColumnName("Shade_Code");
            entity.Property(e => e.ShadeMatchConfirmation).HasColumnName("Shade_Match_Confirmation");
            entity.Property(e => e.ShadeName).HasColumnName("Shade_Name");
            entity.Property(e => e.ShadePatchSwatch).HasColumnName("Shade_Patch/Swatch");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
