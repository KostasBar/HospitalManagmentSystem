using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;
using TestWPFApp.Commands;
using TestWPFApp.Models;
using TestWPFApp.Utils;
using TestWPFApp.Views;

namespace TestWPFApp.ViewModels
{
    // ViewModel class for managing the main window's data bindings and interactions
    internal class MainWindowViewModel : INotifyPropertyChanged
    {
        // Public properties to bind UI elements for selection
        public IEnumerable<GenderType> GenderTypes { get; set; }
        public IEnumerable<string> Conditions { get; set; }
        public IEnumerable<string> Hospitals { get; set; }

        // Private instances managing prescriptions, hospitals, and patients data
        private AllPrescriptions AllPrescriptions { get; set; }
        private AllHospitals AllHospitals { get; set; }
        private AllPatients AllPatients { get; set; }

        // Commands linked to UI actions
        public ICommand AdmitPatientCommand { get; set; }
        public ICommand ShowPatientWindowCommand { get; set; }
        public ICommand ShowHospitalWindowCommand { get; set; }
        public ICommand ShowConditionWindowCommand { get; set; }

        // Properties bound to user input fields
        private string _firstName;
        private string _lastName;
        private string _gender;
        private string _condition;
        private string _hospital;

        // Properties to expose private fields with notification on changes
        public string? FirstName
        {
            get => _firstName;
            set { _firstName = value; OnPropertyChanged(nameof(FirstName)); }
        }
        public string? LastName
        {
            get => _lastName;
            set { _lastName = value; OnPropertyChanged(nameof(LastName)); }
        }
        public string? GenderType
        {
            get => _gender;
            set { _gender = value; OnPropertyChanged(nameof(GenderType)); }
        }
        public string? Hospital
        {
            get => _hospital;
            set { _hospital = value; OnPropertyChanged(nameof(Hospital)); }
        }
        public string? Condition
        {
            get => _condition;
            set { _condition = value; OnPropertyChanged(nameof(Condition)); }
        }

        // Utility to map data models
        Mapper _mapper { get; set; }

        // Constructor initializing properties, commands, and loading data
        public MainWindowViewModel()
        {
            _mapper = new Mapper();
            AllPrescriptions = new AllPrescriptions();
            AllHospitals = new AllHospitals();
            AllPatients = new AllPatients();
            GenderTypes = Enum.GetValues(typeof(GenderType)).Cast<GenderType>();
            Conditions = AllPrescriptions.GetConditions();
            Hospitals = AllHospitals.GetHospitals();
            AdmitPatientCommand = new RelayCommand(AdmitPatient, (CanAdmit => true));
            ShowPatientWindowCommand = new RelayCommand(ShowPatientWindow, (CanShow => true));
            ShowHospitalWindowCommand = new RelayCommand(ShowHospitalWindow, (CanShow => true));
            ShowConditionWindowCommand = new RelayCommand(ShowConditionWindow, (CanShow => true));
        }

        // Method implementations for command actions showing different windows
        private void ShowConditionWindow(object obj)
        {
            DrugWindow drugWindow = new DrugWindow();
            drugWindow.ShowDialog();
        }

        private void ShowHospitalWindow(object obj)
        {
            HospitalsWindow hospitalsWindow = new HospitalsWindow();
            hospitalsWindow.ShowDialog();
        }

        private void ShowPatientWindow(object obj)
        {
            PatientsWindow patientsWindow = new PatientsWindow();
            patientsWindow.ShowDialog();
        }

        // Admitting a new patient and adding to the collection
        private void AdmitPatient(object obj)
        {
            int id = AllPatients.MaxId(); // Get the next ID
            Patient? patientToAdmit = _mapper.MapToPatient(id, FirstName, LastName, Condition, Hospital, GenderType);
            if (patientToAdmit != null)
            {
                AllPatients.AddPatient(patientToAdmit);
                MessageBox.Show($"Successfully admitted {FirstName} {LastName} to {Hospital}.");
            }
            ClearFields();
        }

        // Clear all user input fields after submission
        public void ClearFields()
        {
            FirstName = "";
            LastName = "";
            Hospital = null;
            GenderType = null;
            Condition = null;
        }

        // Event and method to notify UI of property changes
        public event PropertyChangedEventHandler? PropertyChanged;
        protected void OnPropertyChanged(string propertyName) =>
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    

    }
}

