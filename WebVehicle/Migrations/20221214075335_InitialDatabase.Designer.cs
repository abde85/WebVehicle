// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using WebVehicle.DataContext;

#nullable disable

namespace WebVehicle.Migrations
{
    [DbContext(typeof(ApplicationDBContext))]
    [Migration("20221214075335_InitialDatabase")]
    partial class InitialDatabase
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("WebVehicle.DataContext.Repository.Bpkb", b =>
                {
                    b.Property<string>("Agreement_Number")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<DateTime>("Bpkb_Date")
                        .HasColumnType("datetime");

                    b.Property<DateTime>("Bpkb_Date_In")
                        .HasColumnType("datetime");

                    b.Property<string>("Bpkb_No")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Branch_Id")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.Property<DateTime>("Faktur_Date")
                        .HasColumnType("datetime");

                    b.Property<string>("Faktur_No")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Location_Id")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.Property<string>("Police_No")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.HasKey("Agreement_Number");

                    b.HasIndex("Location_Id");

                    b.ToTable("tr_bpkb");
                });

            modelBuilder.Entity("WebVehicle.DataContext.Repository.StorageLocation", b =>
                {
                    b.Property<string>("LocationId")
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.Property<string>("LocationName")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("LocationId");

                    b.ToTable("ms_storage_location");
                });

            modelBuilder.Entity("WebVehicle.DataContext.Repository.Bpkb", b =>
                {
                    b.HasOne("WebVehicle.DataContext.Repository.StorageLocation", "StorageLocations")
                        .WithMany("Bpkbs")
                        .HasForeignKey("Location_Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("StorageLocations");
                });

            modelBuilder.Entity("WebVehicle.DataContext.Repository.StorageLocation", b =>
                {
                    b.Navigation("Bpkbs");
                });
#pragma warning restore 612, 618
        }
    }
}
