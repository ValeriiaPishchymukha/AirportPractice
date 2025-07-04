﻿// <auto-generated />
using Airport.DAL.EF;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Airport.DAL.EF.Migrations
{
    [DbContext(typeof(AirportDbContext))]
    [Migration("20250628180038_Migration4")]
    partial class Migration4
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "9.0.6")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Airport.DAL.EF.Entities.Aircraft", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("AircraftTypeId")
                        .HasColumnType("int");

                    b.Property<string>("Condition")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("FlightHours")
                        .HasColumnType("int");

                    b.Property<string>("Manufacturer")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Model")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Year")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("AircraftTypeId");

                    b.ToTable("Aircrafts");
                });

            modelBuilder.Entity("Airport.DAL.EF.Entities.AircraftType", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("TypeName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("AircraftTypes");
                });

            modelBuilder.Entity("Airport.DAL.EF.Entities.Passenger", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FullName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Passengers");
                });

            modelBuilder.Entity("Airport.DAL.EF.Entities.Pilot", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("Age")
                        .HasColumnType("int");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("Rating")
                        .HasColumnType("float");

                    b.HasKey("Id");

                    b.ToTable("Pilots");
                });

            modelBuilder.Entity("Airport.DAL.EF.Entities.PilotAircraft", b =>
                {
                    b.Property<int>("PilotId")
                        .HasColumnType("int");

                    b.Property<int>("AircraftId")
                        .HasColumnType("int");

                    b.HasKey("PilotId", "AircraftId");

                    b.HasIndex("AircraftId");

                    b.ToTable("PilotAircrafts");
                });

            modelBuilder.Entity("Airport.DAL.EF.Entities.Aircraft", b =>
                {
                    b.HasOne("Airport.DAL.EF.Entities.AircraftType", "AircraftType")
                        .WithMany("Aircrafts")
                        .HasForeignKey("AircraftTypeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("AircraftType");
                });

            modelBuilder.Entity("Airport.DAL.EF.Entities.PilotAircraft", b =>
                {
                    b.HasOne("Airport.DAL.EF.Entities.Aircraft", "Aircraft")
                        .WithMany("PilotAircrafts")
                        .HasForeignKey("AircraftId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Airport.DAL.EF.Entities.Pilot", "Pilot")
                        .WithMany("PilotAircrafts")
                        .HasForeignKey("PilotId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Aircraft");

                    b.Navigation("Pilot");
                });

            modelBuilder.Entity("Airport.DAL.EF.Entities.Aircraft", b =>
                {
                    b.Navigation("PilotAircrafts");
                });

            modelBuilder.Entity("Airport.DAL.EF.Entities.AircraftType", b =>
                {
                    b.Navigation("Aircrafts");
                });

            modelBuilder.Entity("Airport.DAL.EF.Entities.Pilot", b =>
                {
                    b.Navigation("PilotAircrafts");
                });
#pragma warning restore 612, 618
        }
    }
}
