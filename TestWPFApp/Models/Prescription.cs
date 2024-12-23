using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestWPFApp.Models
{
    /// <summary>
    /// Represents a medical prescription and notifies clients that a property value has changed.
    /// </summary>
    public class Prescription
    {
        public int Pid { get; set; }
        public string Condition { get; set; }
        public string Recommended_substance { get; set; }
        public string Recommended_dose { get; set; }

    }
}
