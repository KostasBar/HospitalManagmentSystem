   M S B A M L   `   `   `  ����E  ATestWPFApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null3clr-namespace:TestWPFApp.ViewsTestWPFApp.Views  5   	   %    TestWPFApp.Views.PatientsWindow   5   	   W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   0localclr-namespace:TestWPFApp.Views     5   	     � Title$  PatientsWindow��5   	   $	��450��6    $	��800��6-   .��5	      � -   5         �Name$ Conditions_Grid��5	      ���	#FFB0CECE � RowDefinitions 5   
   �� 5      $
��Auto �6   �� 5      $��* �6   .+�5   
   &   System.Windows.Controls.DataGrid  -   5          Name$ HospitalData��5         AutoGenerateColumns$ False��6)   $��10q�6E   
�������$��2q�5   &      CanUserResizeColumns$
 True��6:   $��1��5         AlternatingRowBackground �	#FFB0CECE��6A   �� *
Patients+   Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$ Id��6%   	   Width5  /System.Windows.Controls.DataGridLengthConverter$	 1* 6O   1  +System.Windows.Controls.DataGridBoundColumn
   Binding
 61   �� *	PatientId+6O     5      $ 
First Name��6%   $	 * 6^   
 69   �� *PatientFirstName+6^     5      $ 	Last Name��6%   $	 * 6\   
 68   �� *PatientLastName+6\     5      $ 	Condition��6%   $	 * 6j   
 68   �� *PatientPrescription.Condition+6j     5      $ Hospital��6%   $	 * 6h   
 67   �� *PatientHospital.HospitalName+6h     5      $ Doctor��6%   $	 * 6g   
 65   �� *PatientHospital.SpecialDoctor+6g   5!      5"      5#      