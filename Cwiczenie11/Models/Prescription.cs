using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Cwiczenie11.Models
{
    public class Prescription
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IDPrescription { get; set; }
        public DateTime Date { get; set; }
        public DateTime DueDate { get; set; }
        
        public int IdPatient { get; set; }
        
        public int IdDoctor { get; set; }
        [ForeignKey("IdPatient")]
        public virtual Patient Patient { get; set; }
        [ForeignKey("IdDoctor")]
        public virtual Doctor Doctor { get; set; }
        public virtual PrescriptionMedicament PrescriptionMedicament {get; set;}
    }
}
