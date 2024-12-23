using Newtonsoft.Json;
using System.IO;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Shapes;
using TestWPFApp.Models;
using TestWPFApp.ViewModels;
using Path = System.IO.Path;

namespace TestWPFApp
{
    /// <summary>
    /// Interaction logic for Hospitals.xaml
    /// </summary>
    public partial class HospitalsWindow : Window
    {
        public HospitalsWindow()
        {
            InitializeComponent();
            HospitalsWindowViewModel viewModel = new HospitalsWindowViewModel();
            this.DataContext = viewModel;
        }

      

        private void RowDoubleClick(object sender, MouseButtonEventArgs e)
        {
            DataGridRow row = sender as DataGridRow;

            if (row != null)
            {
                Hospitals hospitals = row.Item as Hospitals;
                if (hospitals != null)
                {
                    // Inform the user about the doctor spesializing
                    MessageBox.Show($"Doctor {hospitals.SpecialDoctor} of {hospitals.HospitalName} " +
                                    $"\nis speacialized in treating {hospitals.Specialization.Condition}.");
                }
            }
        }


    }
}
