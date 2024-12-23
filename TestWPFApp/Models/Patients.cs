using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestWPFApp.Models
{
    class Patient
    {
        public int PatientId { get; set; }
        public string PatientFirstName { get; set; }
        public string PatientLastName { get; set; }
        public GenderType PatientGender { get; set; }
        public Prescription PatientPrescription { get; set; }
        public Hospitals PatientHospital {  get; set; } 

    }
}
