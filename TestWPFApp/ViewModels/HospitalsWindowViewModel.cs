using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using TestWPFApp.Commands;
using TestWPFApp.Models;

namespace TestWPFApp.ViewModels
{
    class HospitalsWindowViewModel
    {
        public List<Hospitals> Hospitals {  get; set; }


        public HospitalsWindowViewModel()
        {
            Hospitals = AllHospitals.GetAll();

           
        }

    }
}
