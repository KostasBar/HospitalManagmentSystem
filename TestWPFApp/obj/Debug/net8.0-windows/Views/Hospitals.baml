   M S B A M L   `   `   `  ����E  ATestWPFApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'clr-namespace:TestWPFApp
TestWPFApp  5   	        TestWPFApp.HospitalsWindow   5   	   W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   *localclr-namespace:TestWPFApp     5   	     � Title$  	Hospitals��5   	   $	��500��6   $	��650��6(    � WindowStartupLocation$ CenterScreen=�64   .��5
      � -   5         �Name$ Conditions_Grid��5
      ���	#FFB0CECE � RowDefinitions 5   
   �� 5      $
��Auto �6   �� 5      $��* �6   .+�5   
   &   System.Windows.Controls.DataGrid  -   5          Name$ HospitalData��5         AutoGenerateColumns$ False��6)   $��10q�6E   
�������$��2q�5   *      CanUserResizeColumns$
 True��6>   $��1��5         AlternatingRowBackground �	#FFB0CECE��6E   �� *	Hospitals+��5      �� 5       �� 
TargetType)  #System.Windows.Controls.DataGridRow"  6   .�5      -   5        5      	   Columns	 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn
   Header$
 Id��6%      Width5  /System.Windows.Controls.DataGridLengthConverter$ * 6P   1  +System.Windows.Controls.DataGridBoundColumn   Binding 61   �� *
HospitalId+6P     5      $
 Hospital��6%   $ * 6X    67   �� *HospitalName+6X     5      $
 Address��6%   $ * 6R    66   �� *	Address+6R     5      $
 Specialization��6%   $ * 6j    6=   �� *Specialization.Condition+6j     5      $
 Doctor��6%   $ * 6W      
Visibility$ Hidden=�6a    65   �� *SpecialDoctor+6a   5      5      5       