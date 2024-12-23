using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace TestWPFApp.Models
{
    /// <summary>
    /// Class managing patient data operations.
    /// </summary>
    class AllPatients
    {
        // Static list to store patients loaded from JSON.
        public static List<Patient>? Patients = new List<Patient>();

        /// <summary>
        /// Retrieves all patients from a JSON file.
        /// </summary>
        /// <returns>A list of Patients if successful, null if an error occurs</returns>
        public static List<Patient>? GetAll()
        {
            List<Patient>? patients = null;
            try
            {
                
                string jsonFilePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "DataFiles", "Patients.json");
                
                string jsonData = File.ReadAllText(jsonFilePath);
                
                patients = JsonConvert.DeserializeObject<List<Patient>>(jsonData);
            }
            catch (FileNotFoundException)
            {
                
                MessageBox.Show("The JSON file was not found.");
            }
            catch (System.Text.Json.JsonException)
            {
                
                MessageBox.Show("Error parsing the JSON file.");
            }
            catch (Exception ex)
            {
                
                MessageBox.Show($"An error occurred: {ex.Message}");
            }

            return patients;
        }

        /// <summary>
        /// Adds a new patient to the JSON file.
        /// </summary>
        /// <param name="patient">Patient to add</param>
        public static void AddPatient(Patient patient)
        {
            try
            {
                // Retrieve current list of patients or initialize if null
                List<Patient> patients = GetAll() ?? new List<Patient>();
                patients.Add(patient);

                string patientsJSON = JsonConvert.SerializeObject(patients, Formatting.Indented);
                string jsonFilePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "DataFiles", "Patients.json");

                File.WriteAllText(jsonFilePath, patientsJSON);
            }
            catch (FileNotFoundException)
            {

                MessageBox.Show("The JSON file was not found.");
            }
            catch (System.Text.Json.JsonException)
            {
                MessageBox.Show("Error parsing the JSON file.");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}");
            }
        }

        /// <summary>
        /// Calculates the next available unique ID for a new patient.
        /// </summary>
        /// <returns>The next available ID</returns>
        public int MaxId()
        {
            List<Patient>? patients = GetAll();
            // If there are no patients yet, begin ID sequence with 1
            if (patients is null || !patients.Any())
            {
                return 1;
            }
            // Return the highest current ID incremented by one
            int maxId = patients.Max(p => p.PatientId);
            return maxId + 1;
        }
    }

}
