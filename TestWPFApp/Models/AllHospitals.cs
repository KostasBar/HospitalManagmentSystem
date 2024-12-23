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
    /// Class responsible for managing hospital data operations.
    /// </summary>
    class AllHospitals
    {
        // Static list to store hospitals loaded from JSON.
        public static List<Hospitals> _JsonHsopitals = new List<Hospitals>();

        /// <summary>
        /// Retrieves all hospitals from a JSON file.
        /// </summary>
        /// <returns>A list of Hospitals if successful, null if an error occurs</returns>
        public static List<Hospitals>? GetAll()
        {
            List<Hospitals>? hospitals = null;
            try
            {
                string jsonFilePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "DataFiles", "Hospitals.json");
                string jsonData = File.ReadAllText(jsonFilePath);
                hospitals = JsonConvert.DeserializeObject<List<Hospitals>>(jsonData);
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

            return hospitals;
        }

        /// <summary>
        /// Retrieves the names of all hospitals stored in the JSON file.
        /// </summary>
        /// <returns>A list of hospital names</returns>
        public List<string> GetHospitals()
        {
            List<Hospitals> hospitals = GetAll(); // Fetch all hospital data
            List<string> hospitalNames = new List<string>(); 
            // Loop through each hospital and add its name to the list
            hospitals.ForEach(hospital => hospitalNames.Add(hospital.HospitalName));
            return hospitalNames;
        }

        /// <summary>
        /// Finds a hospital by its name.
        /// </summary>
        /// <param name="name">The name of the hospital to find</param>
        /// <returns>The matching hospital or null if not found</returns>
        public Hospitals? GetHospitalByName(string name)
        {
            Hospitals? hospital = null;
            hospital = GetAll().Where<Hospitals>(h => h.HospitalName.Equals(name)).FirstOrDefault();
            return hospital;
        }
    }

}
