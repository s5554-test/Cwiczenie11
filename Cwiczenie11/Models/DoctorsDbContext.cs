using Cwiczenie11.Configurations;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cwiczenie11.Models
{
    public class DoctorsDbContext : DbContext
    {

        public DbSet<Doctor> Doctors { get; set; }

        public DbSet<Prescription> Prescriptions { get; set; }

        public DbSet<PrescriptionMedicament> PrescriptionsMedicaments { get; set; }

        public DbSet<Patient> Patients { get; set; }
        public DbSet<Medicament> Medicaments { get; set; }
        public DoctorsDbContext()
        {

        }

        public DoctorsDbContext(DbContextOptions options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelbuilder)
        {
            base.OnModelCreating(modelbuilder);

            modelbuilder.ApplyConfiguration(new DoctorEfConfiguration());
            modelbuilder.ApplyConfiguration(new PatientEfConfiguration());
            modelbuilder.ApplyConfiguration(new MedicamentEfConfiguration());
            modelbuilder.ApplyConfiguration(new PrescriptionEfConfiguration());
            modelbuilder.ApplyConfiguration(new PrescriptionMedicamentConfiguration());


            /* modelbuilder.Entity<PrescriptionMedicament>()
                 .HasKey(e => e.IdMedicament);

             modelbuilder.Entity<PrescriptionMedicament>()
                 .HasKey(e => e.IdPrescription);

             var doctors = new List<Doctor>();
             doctors.Add(new Doctor { IdDoctor = 1, FirstName = "Ryszard", LastName = "Swetru", Email = "email1" });
             doctors.Add(new Doctor { IdDoctor = 2, FirstName = "Monika", LastName = "Skoczylas", Email = "email2" });
             modelbuilder.Entity<Doctor>()
                 .HasData(doctors);

             var patients = new List<Patient>();
             patients.Add(new Patient { IdPatient = 11, FirstName = "Piotr", LastName = "Szela", Birthdate = DateTime.Now});
             patients.Add(new Patient { IdPatient = 22, FirstName = "Ada", LastName = "Piekarska", Birthdate = DateTime.Now });
             patients.Add(new Patient { IdPatient = 33, FirstName = "Michał", LastName = "Kościuszko", Birthdate = DateTime.Now });
             modelbuilder.Entity<Patient>()
                 .HasData(patients);

             var medicaments = new List<Medicament>();
             medicaments.Add(new Medicament { IdMedicament = 111, Name = "APAP", Description = "gorączka", Type = "tabletki" });
             medicaments.Add(new Medicament { IdMedicament = 2222, Name = "Orofar", Description = "infekcja", Type = "spray" });
             medicaments.Add(new Medicament { IdMedicament = 3333, Name = "Ibuprom", Description = "gorączka", Type = "tabletki" });
             modelbuilder.Entity<Medicament>()
                 .HasData(medicaments);

             var prescriptions = new List<Prescription>();
            prescriptions.Add(new Prescription { IDPrescription = 1111, Date = DateTime.Now, DueDate = DateTime.Now});
            prescriptions.Add(new Prescription { IDPrescription = 2222, Date = DateTime.Now, DueDate = DateTime.Now });
            prescriptions.Add(new Prescription { IDPrescription = 3333, Date = DateTime.Now, DueDate = DateTime.Now });
            prescriptions.Add(new Prescription { IDPrescription = 4444, Date = DateTime.Now, DueDate = DateTime.Now });
             modelbuilder.Entity<Prescription>()
                 .HasData(prescriptions);

             var prescriptionmeds = new List<PrescriptionMedicament>();
             prescriptionmeds.Add(new PrescriptionMedicament { Dose = 200, Details = "details1" });
             prescriptionmeds.Add(new PrescriptionMedicament { Dose = 250, Details = "details2" });
             prescriptionmeds.Add(new PrescriptionMedicament { Dose = 400, Details = "details3" });
             prescriptionmeds.Add(new PrescriptionMedicament { Dose = 100, Details = "details4" });
             modelbuilder.Entity<PrescriptionMedicament>()
                 .HasData(prescriptionmeds);*/
        }



    }
}
