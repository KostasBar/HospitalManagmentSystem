   M S B A M L   `   `   `  ����E  ATestWPFApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'clr-namespace:TestWPFApp
TestWPFApp  5   	       TestWPFApp.TherapyDetails   5   	   W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   *localclr-namespace:TestWPFApp     5   	   -   5        $	��450��5	   %   $	��600��62     � WindowStartupLocation$  CenterScreen=�6>    � Title 6	   �� *	Condition+.��5
      � -   5         �Name$ TherapyDetailsGrid��5
      ���	#FFB0CECE � RowDefinitions 5   
   �� 5      $
��Auto �6   �� 5      $��* �6   .+�5   
   �� -   5         ��Name$ ConditionLabel��5      $��Center=�6F   $	��Top=�6c   $��0, 10, 0, 0q�6{   $��1q�5      
���������5   (   �� *	Condition+5   $   �� 5   
   -   5         ��Name$ TherapyDetailsBorder��5      $��Center=�6/   $��Center=�6J   $��30q�6g   $��1��6s   $��1q�6�   
�������._�5      �� $��Center=�6   $��Center=�64   .+�5      �� $��Recommended Substance:��6   $
��Bold"�69   $��5q�6K   $��10q�6W   �� 5      -   5        $ r_substance��5      
�������$��1q�6k   $��10q�6   $��5q�6�   $��Center=�5      $��Center=�6:   ��5   -   �� *Recommended_substance+5   :   �� 5      $��Recommended Dose:��6   $
��Bold"�64   $��5q�6F   $��10q�6R   �� 5      -   5        $ r_dose��5      
�������$��1q�6a   $��10q�6u   $��5q�6�   $��Center=�5      $��Center=�6:   ��5   (   �� *Recommended_dose+5   :   5       5!      5"      5#      