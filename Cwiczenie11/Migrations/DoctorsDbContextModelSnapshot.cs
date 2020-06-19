﻿// <auto-generated />
using System;
using Cwiczenie11.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Cwiczenie11.Migrations
{
    [DbContext(typeof(DoctorsDbContext))]
    partial class DoctorsDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Cwiczenie11.Models.Doctor", b =>
                {
                    b.Property<int>("IdDoctor")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(100)")
                        .HasMaxLength(100);

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(100)")
                        .HasMaxLength(100);

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(100)")
                        .HasMaxLength(100);

                    b.HasKey("IdDoctor");

                    b.ToTable("Doctors");

                    b.HasData(
                        new
                        {
                            IdDoctor = 1,
                            Email = "email1",
                            FirstName = "Ryszard",
                            LastName = "Swetru"
                        },
                        new
                        {
                            IdDoctor = 2,
                            Email = "email2",
                            FirstName = "Monika",
                            LastName = "Skoczylas"
                        });
                });

            modelBuilder.Entity("Cwiczenie11.Models.Medicament", b =>
                {
                    b.Property<int>("IdMedicament")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Type")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("IdMedicament");

                    b.ToTable("Medicaments");

                    b.HasData(
                        new
                        {
                            IdMedicament = 111,
                            Description = "gorączka",
                            Name = "APAP",
                            Type = "tabletki"
                        },
                        new
                        {
                            IdMedicament = 2222,
                            Description = "infekcja",
                            Name = "Orofar",
                            Type = "spray"
                        },
                        new
                        {
                            IdMedicament = 3333,
                            Description = "gorączka",
                            Name = "Ibuprom",
                            Type = "tabletki"
                        });
                });

            modelBuilder.Entity("Cwiczenie11.Models.Patient", b =>
                {
                    b.Property<int>("IdPatient")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("Birthdate")
                        .HasColumnType("datetime2");

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("IdPatient");

                    b.ToTable("Patients");

                    b.HasData(
                        new
                        {
                            IdPatient = 11,
                            Birthdate = new DateTime(2020, 6, 19, 16, 3, 46, 841, DateTimeKind.Local).AddTicks(1607),
                            FirstName = "Piotr",
                            LastName = "Szela"
                        },
                        new
                        {
                            IdPatient = 22,
                            Birthdate = new DateTime(2020, 6, 19, 16, 3, 46, 843, DateTimeKind.Local).AddTicks(8454),
                            FirstName = "Ada",
                            LastName = "Piekarska"
                        },
                        new
                        {
                            IdPatient = 33,
                            Birthdate = new DateTime(2020, 6, 19, 16, 3, 46, 843, DateTimeKind.Local).AddTicks(8488),
                            FirstName = "Michał",
                            LastName = "Kościuszko"
                        });
                });

            modelBuilder.Entity("Cwiczenie11.Models.Prescription", b =>
                {
                    b.Property<int>("IDPrescription")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DueDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("IdDoctor")
                        .HasColumnType("int");

                    b.Property<int>("IdPatient")
                        .HasColumnType("int");

                    b.HasKey("IDPrescription");

                    b.HasIndex("IdDoctor");

                    b.HasIndex("IdPatient");

                    b.ToTable("Prescriptions");

                    b.HasData(
                        new
                        {
                            IDPrescription = 1111,
                            Date = new DateTime(2020, 6, 19, 16, 3, 46, 844, DateTimeKind.Local).AddTicks(7489),
                            DueDate = new DateTime(2020, 6, 19, 16, 3, 46, 844, DateTimeKind.Local).AddTicks(7940),
                            IdDoctor = 0,
                            IdPatient = 0
                        },
                        new
                        {
                            IDPrescription = 2222,
                            Date = new DateTime(2020, 6, 19, 16, 3, 46, 844, DateTimeKind.Local).AddTicks(8384),
                            DueDate = new DateTime(2020, 6, 19, 16, 3, 46, 844, DateTimeKind.Local).AddTicks(8399),
                            IdDoctor = 0,
                            IdPatient = 0
                        },
                        new
                        {
                            IDPrescription = 3333,
                            Date = new DateTime(2020, 6, 19, 16, 3, 46, 844, DateTimeKind.Local).AddTicks(8408),
                            DueDate = new DateTime(2020, 6, 19, 16, 3, 46, 844, DateTimeKind.Local).AddTicks(8410),
                            IdDoctor = 0,
                            IdPatient = 0
                        },
                        new
                        {
                            IDPrescription = 4444,
                            Date = new DateTime(2020, 6, 19, 16, 3, 46, 844, DateTimeKind.Local).AddTicks(8413),
                            DueDate = new DateTime(2020, 6, 19, 16, 3, 46, 844, DateTimeKind.Local).AddTicks(8415),
                            IdDoctor = 0,
                            IdPatient = 0
                        });
                });

            modelBuilder.Entity("Cwiczenie11.Models.PrescriptionMedicament", b =>
                {
                    b.Property<int>("IdPrescription")
                        .HasColumnType("int");

                    b.Property<string>("Details")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("Dose")
                        .HasColumnType("int");

                    b.Property<int>("IdMedicament")
                        .HasColumnType("int");

                    b.HasKey("IdPrescription");

                    b.HasIndex("IdMedicament");

                    b.ToTable("PrescriptionsMedicaments");
                });

            modelBuilder.Entity("Cwiczenie11.Models.Prescription", b =>
                {
                    b.HasOne("Cwiczenie11.Models.Doctor", "Doctor")
                        .WithMany("Prescriptions")
                        .HasForeignKey("IdDoctor")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Cwiczenie11.Models.Patient", "Patient")
                        .WithMany("Prescriptions")
                        .HasForeignKey("IdPatient")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Cwiczenie11.Models.PrescriptionMedicament", b =>
                {
                    b.HasOne("Cwiczenie11.Models.Medicament", "Medicament")
                        .WithMany("PrescriptionsMedicaments")
                        .HasForeignKey("IdMedicament")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Cwiczenie11.Models.Prescription", "Prescription")
                        .WithOne("PrescriptionMedicament")
                        .HasForeignKey("Cwiczenie11.Models.PrescriptionMedicament", "IdPrescription")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
