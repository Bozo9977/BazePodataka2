   M S B A M L   `   `   `  ����I  EOsnovnaSkolaUI, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null;"clr-namespace:OsnovnaSkolaUI.ViewsOsnovnaSkolaUI.Views  5   	   0    *OsnovnaSkolaUI.Views.OblastiPredmetaWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   4local"clr-namespace:OsnovnaSkolaUI.Views     5   	     � Title$  Change Oblast��5   	   $	��450��6   $��711.5��6,    � WindowStartupLocation$ CenterScreen=�6:   .��5	      � 
���   �.+�5
   
   &   System.Windows.Controls.DataGrid     ColumnWidth5  /System.Windows.Controls.DataGridLengthConverter$ * 6�      AutoGenerateColumns .     
IsReadOnly . $��0,0,0,97q�6�   ��6   �� *	Oblasti+ �� UpdateSourceTrigger$ PropertyChanged=� �� Mode$ TwoWay=� �� SelectedItem 6f   �� *SelectedOblast+   Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn	   Header$	 Id��6%   
 �� TextAlignment$
 Center=�61      
IsReadOnly . 1  +System.Windows.Controls.DataGridBoundColumn   Binding 6R   �� *
Id_oblasti+   ElementStyle 5      �� 5       �� 
TargetType" ��6    .�5      ��  �� Property � �� �� Value$
 Wrap=�6=   �� 5       � ��$ Center=�6D   �� 5       � ��$ Center=�6B   5      5        5      $	 Naziv��6%   $
 Center=�64    .  6U   �� *naziv+ 5      �� 5      " ��6    .�5      ��  � ��$
 Wrap=�6=   �� 5       � ��$ Center=�6D   �� 5       � ��$ Center=�6B   5      5        5!      $	 Id predmeta��6%   $
 Center=�6:    .  6[   �� *PredmetId_predmeta+ 5"      �� 5#      " ��6    .�5$      ��  � ��$
 Wrap=�6=   �� 5%       � ��$ Center=�6D   �� 5&       � ��$ Center=�6B   5'      5)      5,      �� 5-   
   $��Izmeni��66   $��18(�6o   
������ 
��� ���$��185,356,365,0q�6�   $	��Top=�6�   $��40��6�   y�6   �� *IzmenaOblasti+��6G   �� *ChangeOblastCommand+6�   �� 5.   
   $��Obrisi��66   $��18(�6o   
������ 
��� ���$��344,356,206,0q�6�   $	��Top=�6�   $��40��6�   y�6   �� *IzmenaOblasti+��6G   �� *DeleteOblastCommand+6�   �� 5/   
   $��Izaberi Oblast��6;   $��18(�6�   
������ 
��� ���$��271,356,279,0q�6�   $	��Top=�6�   $��40��6�   y�6   �� *CreatingPredavanje+��6T   �� *CreatePredavanjeCommand+6�   52      53      