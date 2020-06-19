using Cwiczenie11.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cwiczenie11.Configurations
{
    public class DoctorEfConfiguration : IEntityTypeConfiguration<Doctor>
    {
        public void Configure(EntityTypeBuilder<Doctor> builder){
            var doctors = new List<Doctor>();
            doctors.Add(new Doctor { IdDoctor = 1, FirstName = "Ryszard", LastName = "Swetru", Email = "email1" });
            doctors.Add(new Doctor { IdDoctor = 2, FirstName = "Monika", LastName = "Skoczylas", Email = "email2" });
            builder
                .HasData(doctors);
        }
       
    }
}
