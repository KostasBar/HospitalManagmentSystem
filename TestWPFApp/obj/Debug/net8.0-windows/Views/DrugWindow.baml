   M S B A M L   `   `   `  ����E  ATestWPFApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'clr-namespace:TestWPFApp
TestWPFApp  5   	       TestWPFApp.DrugWindow   5   	   W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   *localclr-namespace:TestWPFApp     5   	     � Title$  
Conditions��5   	   $	��500��6   $	��650��6)    � WindowStartupLocation$ CenterScreen=�65   .��5	      � -   5         �Name$ ConditionsGrid��5	      ���	#FFB0CECE � RowDefinitions 5   
   �� 5      $
��Auto �6   �� 5      $��* �6   .+�5   
   �� $��	Load Data��64   $��Right=�6H   $	��Top=�6d   $��60��6|   $	��100��6�   $��10q�6�   ��6   �� *GetDataCommand+6�   &   System.Windows.Controls.DataGrid  5   
   -   5          Name$ PrescriptionData��5         AutoGenerateColumns$ False��6-   $��10q�6I   
�������$��2q�5   *      CanUserResizeColumns$
 True��6>   $��1��5         AlternatingRowBackground �	#FFB0CECE��6E   �� *Prescriptions+��5      �� 5       �� 
TargetType)  #System.Windows.Controls.DataGridRow"  6   .�5      -   5        5      	   Columns	 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn
   Header$
 Id��6%      Width5  /System.Windows.Controls.DataGridLengthConverter$ * 6I   1  +System.Windows.Controls.DataGridBoundColumn   Binding 61   �� *Pid+6I     5      $
 	Condition��6%   $ * 6V    68   �� *	Condition+6V     5      $
 Recommended Substance��6%   $ * 6n      
Visibility$ Hidden=�6x    6D   �� *Recommended_substance+6x     5      $
 Recommended Dose��6%   $ * 6d   $ Hidden=�6n    6?   �� *Recommended_dose+6n   5!      5"      5#      