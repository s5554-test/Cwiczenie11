using Cwiczenie11.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cwiczenie11.Configurations
{
    public class MedicamentEfConfiguration : IEntityTypeConfiguration<Medicament>
    {

        public void Configure(EntityTypeBuilder<Medicament> builder)
        {
            var medicaments = new List<Medicament>();
            medicaments.Add(new Medicament { IdMedicament = 111, Name = "APAP", Description = "gorączka", Type = "tabletki" });
            medicaments.Add(new Medicament { IdMedicament = 2222, Name = "Orofar", Description = "infekcja", Type = "spray" });
            medicaments.Add(new Medicament { IdMedicament = 3333, Name = "Ibuprom", Description = "gorączka", Type = "tabletki" });
            builder
                .HasData(medicaments);
        }
    }  
    
}
