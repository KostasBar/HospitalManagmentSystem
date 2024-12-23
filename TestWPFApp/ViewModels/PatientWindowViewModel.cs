using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestWPFApp.Models;

namespace TestWPFApp.ViewModels
{
    class PatientWindowViewModel
    {
        public List<Patient>? Patients { get; set; }
        public AllPatients AllPatients { get; set; }

        public PatientWindowViewModel() 
        {
            Patients = AllPatients.GetAll();
        }
    }
}
