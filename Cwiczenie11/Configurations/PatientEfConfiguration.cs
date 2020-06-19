using Cwiczenie11.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cwiczenie11.Configurations
{
    public class PatientEfConfiguration : IEntityTypeConfiguration<Patient>
    {
        public void Configure(EntityTypeBuilder<Patient> builder)
        {
            var patients = new List<Patient>();
            patients.Add(new Patient { IdPatient = 11, FirstName = "Piotr", LastName = "Szela", Birthdate = DateTime.Now });
            patients.Add(new Patient { IdPatient = 22, FirstName = "Ada", LastName = "Piekarska", Birthdate = DateTime.Now });
            patients.Add(new Patient { IdPatient = 33, FirstName = "Michał", LastName = "Kościuszko", Birthdate = DateTime.Now });
            builder
                .HasData(patients);
        }
    }
}
