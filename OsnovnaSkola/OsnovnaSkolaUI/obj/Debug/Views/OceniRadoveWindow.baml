   M S B A M L   `   `   `  ����I  EOsnovnaSkolaUI, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null;"clr-namespace:OsnovnaSkolaUI.ViewsOsnovnaSkolaUI.Views  5   	   ,    &OsnovnaSkolaUI.Views.OceniRadoveWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   4local"clr-namespace:OsnovnaSkolaUI.Views     5   	     � Title$  Oceni Radove��5   	   $	��450��6   $��711.5��6+    � WindowStartupLocation$ CenterScreen=�69   .��5	      � 
���   �.+�5
   
   &   System.Windows.Controls.DataGrid     CanUserAddRows .     ColumnWidth5  /System.Windows.Controls.DataGridLengthConverter$ * 6}      AutoGenerateColumns .  $��0,0,0,97q�6�   ��6   �� *Radovi+ �� UpdateSourceTrigger$ PropertyChanged=� �� Mode$ TwoWay=�   Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$ Kontrolna tacka:��6%   	 �� TextAlignment$	 Center=�6?   
   
IsReadOnly
 . 1  +System.Windows.Controls.DataGridBoundColumn   Binding 6`   �� *#!Kontrolna_tackaId_kontrolne_tacke+   ElementStyle 5      �� 5       �� 
TargetType" ��6    .�5      ��  �� Property � �� �� Value$
 Wrap=�6=   �� 5       � ��$ Center=�6D   �� 5       � ��$ Center=�6B   5      5        5      $ Ucenik��6%   $	 Center=�65   
 .  6V   �� *UcenikId_ucenika+ 5      �� 5      " ��6    .�5      ��  � ��$
 Wrap=�6=   �� 5       � ��$ Center=�6D   �� 5       � ��$ Center=�6B   5      5        5!      $ Zapsleni��6%   $	 Center=�67   
 .  6X   �� *ZaposleniId_zaposlenog+ 5"      �� 5#      " ��6    .�5$      ��  � ��$
 Wrap=�6=   �� 5%       � ��$ Center=�6D   �� 5&       � ��$ Center=�6B   5'      5)        5+      $ Ocena��6%   $	 Center=�64    6U   �� *ocena+ 5,      �� 5-      " ��6    .�5.      ��  � ��$
 Wrap=�6=   �� 5/       � ��$ Center=�6D   �� 50       � ��$ Center=�6B   51      53        55      $ Zadatak��6%   $	 Center=�66   
 .  6W   �� *	zadatak+ 56      �� 57      " ��6    .�58      ��  � ��$
 Wrap=�6=   �� 59       � ��$ Center=�6D   �� 5:       � ��$ Center=�6B   5;      5=      5@      �� 5C   
   $��Oceni��6   $��18(�6C   
������ 
��� ���$��271,356,279,0q�6|   $	��Top=�6�   $��40��6�   ��6"   �� *OceniCommand+6�   5F      5G      