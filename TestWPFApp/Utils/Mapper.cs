using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using TestWPFApp.Models;

namespace TestWPFApp.Utils
{
    internal class Mapper
    {
        public Patient? MapToPatient(int id, string Firstname, string Lastname, string condition, string hospitalname, string gender)
        {
            AllPatients allPatients = new AllPatients();
            AllHospitals allHospitals = new AllHospitals();
            AllPrescriptions allPrescriptions = new AllPrescriptions();

            Prescription? prescriptionToAdmit = allPrescriptions.GetPrescriptionByCondition(condition);
            Hospitals? hospitalToAdmit = allHospitals.GetHospitalByName(hospitalname);
            Patient patient = new Patient();
            patient.PatientFirstName = Firstname;
            patient.PatientLastName = Lastname;

            if (Enum.TryParse(gender, true, out GenderType genderResult))
            {
                patient.PatientGender = genderResult;
            }
            else
            {
                MessageBox.Show("Invalid gender type provided.");
                return null;
            }

            if (hospitalToAdmit == null)
            {
                MessageBox.Show("Error in finding Hospital to admit the patient!");
                return null;
            }
            else
            {
                patient.PatientHospital = hospitalToAdmit;
            }
            
            if (prescriptionToAdmit == null)
            {
                MessageBox.Show("Error in finding Prescription to admit the patient!");
                return null;
            }
            else
            {
                patient.PatientPrescription = prescriptionToAdmit;
            }
            id = allPatients.MaxId();
            patient.PatientId = id;


            return patient;
        }
    }
}
