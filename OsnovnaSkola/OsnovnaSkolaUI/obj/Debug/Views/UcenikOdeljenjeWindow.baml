   M S B A M L   `   `   `  ����I  EOsnovnaSkolaUI, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null;"clr-namespace:OsnovnaSkolaUI.ViewsOsnovnaSkolaUI.Views  5   	   0    *OsnovnaSkolaUI.Views.UcenikOdeljenjeWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   4local"clr-namespace:OsnovnaSkolaUI.Views     5   	     � Title$  Dodaj Odeljenje��5   	   $	��450��6!   $��711.5��6.    � WindowStartupLocation$ CenterScreen=�6<   .��5	      � 
���   �.+�5
   
   &   System.Windows.Controls.DataGrid     ColumnWidth5  /System.Windows.Controls.DataGridLengthConverter$ * 6�      AutoGenerateColumns .     
IsReadOnly . $��0,0,0,97q�6�   ��6   �� *	Odeljenja+ �� UpdateSourceTrigger$ PropertyChanged=� �� Mode$ TwoWay=� �� SelectedItem 6h   �� *SelectedOdeljenje+   Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn	   Header$	 Id��6%   
 �� TextAlignment$
 Center=�61      
IsReadOnly . 1  +System.Windows.Controls.DataGridBoundColumn   Binding 6R   �� *Id_odeljenja+   ElementStyle 5      �� 5       �� 
TargetType" ��6    .�5      ��  �� Property � �� �� Value$
 Wrap=�6=   �� 5       � ��$ Center=�6D   �� 5       � ��$ Center=�6B   5      5        5      $	 Razred��6%   $
 Center=�65    .  6V   �� *razred+ 5      �� 5      " ��6    .�5      ��  � ��$
 Wrap=�6=   �� 5       � ��$ Center=�6D   �� 5       � ��$ Center=�6B   5      5        5!      $	 Razredni��6%   $
 Center=�67    .  6X   �� *
Razredni+ 5"      �� 5#      " ��6    .�5$      ��  � ��$
 Wrap=�6=   �� 5%       � ��$ Center=�6D   �� 5&       � ��$ Center=�6B   5'      5)      5,      �� 5-   
   $��Dodaj��6   $��18(�6K   
������ 
��� ���$��249,369,301,0q�6�   $	��Top=�6�   $��40��6�   ��6!   �� *DodajOdeljenjeCommand+6�   51      52      