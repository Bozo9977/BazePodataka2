   M S B A M L   `   `   `  ����I  EOsnovnaSkolaUI, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null;"clr-namespace:OsnovnaSkolaUI.ViewsOsnovnaSkolaUI.Views  5   	   ,    &OsnovnaSkolaUI.Views.AddRazredniWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   4local"clr-namespace:OsnovnaSkolaUI.Views     5   	     � Title$  AddRazredniWindow��5   	   $	��450��6#   $��711.5��60   .��5	      � 
���   �.+�5
   
   &   System.Windows.Controls.DataGrid     ColumnWidth5  /System.Windows.Controls.DataGridLengthConverter$ * 6�      AutoGenerateColumns .     
IsReadOnly . $��0,0,0,97q�6�   ��6   �� *	Zaposleni+ �� UpdateSourceTrigger$ PropertyChanged=� �� Mode$ TwoWay=� �� SelectedItem 6h   �� *SelectedZaposleni+   Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$ Id��6%   	 �� TextAlignment$	 Center=�61   
   
IsReadOnly
 . 1  +System.Windows.Controls.DataGridBoundColumn   Binding 6R   �� *Id_zaposlenog+   ElementStyle 5      �� 5       �� 
TargetType" ��6    .�5      ��  �� Property � �� �� Value$
 Wrap=�6=   �� 5       � ��$ Center=�6D   �� 5       � ��$ Center=�6B   5      5        5      $	 Ime��6%   $	 Center=�62   
 .  6S   �� *ime+ 5      �� 5      " ��6    .�5      ��  � ��$
 Wrap=�6=   �� 5       � ��$ Center=�6D   �� 5       � ��$ Center=�6B   5      5        5       $ Prezime��6%   $	 Center=�66   
 .  6W   �� *	prezime+ 5!      �� 5"      " ��6    .�5#      ��  � ��$
 Wrap=�6=   �� 5$       � ��$ Center=�6D   �� 5%       � ��$ Center=�6B   5&      5(        5*      $ Zvanje��6%   $	 Center=�65   
 .  6V   �� *zvanje+ 5+      �� 5,      " ��6    .�5-      ��  � ��$
 Wrap=�6=   �� 5.       � ��$ Center=�6D   �� 5/       � ��$ Center=�6B   50      52      55      �� 56   
   $��Dodaj��6   $��18(�6H   
������ 
��� ���$��276,356,274,0q�6�   $	��Top=�6�   $��40��6�   ��6!   �� *AddRazredniCommand+6�   59      5:      