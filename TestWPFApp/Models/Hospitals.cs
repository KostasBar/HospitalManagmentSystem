using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestWPFApp.Models;

namespace TestWPFApp.Models
{
    class Hospitals
    {
        public string HospitalId { get; set; }
        public string HospitalName { get; set; }
        public string Address { get; set; }
        public Prescription Specialization { get; set; }
        public string SpecialDoctor { get; set; }
    }
}