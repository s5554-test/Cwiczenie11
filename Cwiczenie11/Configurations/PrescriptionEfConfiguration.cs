using Cwiczenie11.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cwiczenie11.Configurations
{
    public class PrescriptionEfConfiguration : IEntityTypeConfiguration<Prescription>
    {
        public void Configure(EntityTypeBuilder<Prescription> builder)
        {
            var perscriptions = new List<Prescription>();
            perscriptions.Add(new Prescription { IDPrescription = 1111, Date = DateTime.Now, DueDate = DateTime.Now });
            perscriptions.Add(new Prescription { IDPrescription = 2222, Date = DateTime.Now, DueDate = DateTime.Now });
            perscriptions.Add(new Prescription { IDPrescription = 3333, Date = DateTime.Now, DueDate = DateTime.Now });
            perscriptions.Add(new Prescription { IDPrescription = 4444, Date = DateTime.Now, DueDate = DateTime.Now });
            builder
                .HasData(perscriptions);
        }
    }
}
