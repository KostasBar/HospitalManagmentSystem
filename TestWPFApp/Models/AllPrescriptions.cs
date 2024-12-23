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
    class AllPrescriptions
    {
        public static List<Prescription>? prescriptions =new List<Prescription>();

        /// <summary>
        /// Returns List Of All Prescriptions
        /// </summary>
        /// <returns>List<Prescription>: A list of all prescriptions</Prescription></returns>
        public static List<Prescription>? GetAll()
        {
            List<Prescription>? prescriptions = null;
            try
            {
                string jsonFilePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "DataFiles", "Therapy.json");
                string jsonData = File.ReadAllText(jsonFilePath);
                prescriptions = JsonConvert.DeserializeObject<List<Prescription>>(jsonData);

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

            return prescriptions;
        }


        /// <summary>
        /// Returns List Of Conditions Only
        /// </summary>
        /// <returns>List<string>: A list of all conditions</string></returns>
        public List<string> GetConditions()
        {
            List<Prescription> prescriptions = GetAll();
            List<string> conditions = new List<string>();
            prescriptions.ForEach( prescription => conditions.Add(prescription.Condition) );
            return conditions;
        }

        /// <summary>
        /// Returns a Prescription based on its condition
        /// </summary>
        /// <param name="name">The condition of the Prescription to be retrieved.</param>
        /// <returns></returns>
        public Prescription? GetPrescriptionByCondition(string name)
        {
            Prescription? prescription = null;
            prescription = GetAll().Where<Prescription>(p => p.Condition == name).FirstOrDefault();
            return prescription;
        }
    }
}
