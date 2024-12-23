using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using TestWPFApp.Commands;
using TestWPFApp.Models;

namespace TestWPFApp.ViewModels
{
    class PrescriptionWinViwModel : INotifyPropertyChanged
    {
        // Backing field for prescriptions list
        private List<Prescription> _prescriptions;

        // Public property for prescriptions that notifies when changed
        public List<Prescription> Prescriptions
        {
            get => _prescriptions;
            set
            {
                // Only update and notify if there's an actual change to reduce unnecessary UI refreshes
                if (_prescriptions != value)
                {
                    _prescriptions = value;
                    OnPropertyChanged(nameof(Prescriptions)); // Notify UI of change
                }
            }
        }

        // Command triggered to fetch and update prescriptions data
        public ICommand GetDataCommand { get; set; }

       
        public PrescriptionWinViwModel()
        {
            Prescriptions = new List<Prescription>(); // Initialize with an empty list
            GetDataCommand = new RelayCommand(GetData, (CanGetData => true)); 
        }

        // Command action to fetch prescription data
        private void GetData(object obj)
        {
            Prescriptions = AllPrescriptions.GetAll(); 
            OnPropertyChanged(nameof(Prescriptions)); // Notify the UI that the list has been updated
        }

        public event PropertyChangedEventHandler? PropertyChanged;

        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }

}
