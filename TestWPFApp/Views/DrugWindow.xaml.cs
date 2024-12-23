using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using Newtonsoft.Json;
using TestWPFApp.Models;
using TestWPFApp.ViewModels; 

namespace TestWPFApp
{
    /// <summary>
    /// Interaction logic for DrugWindow.xaml
    /// </summary>
    public partial class DrugWindow : Window
    {
        public DrugWindow()
        {
            InitializeComponent();
            PrescriptionWinViwModel prescriptionWinViwModel = new PrescriptionWinViwModel();
            this.DataContext = prescriptionWinViwModel;
        }

        /// <summary>
        /// Shows Window with more info about condition's therapy
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RowDoubleClick(object sender, MouseButtonEventArgs e)
        {
            DataGridRow row = sender as DataGridRow;
            
            if (row != null)
            {
                Prescription prescription = row.Item as Prescription;
                if (prescription != null)
                {
                    // Open the new window and pass the selected Prescription object
                    TherapyDetails therapyDetails = new TherapyDetails();
                   
                    therapyDetails.DataContext = prescription;
                    therapyDetails.ShowDialog();
                }
            }
        }
    }
}
