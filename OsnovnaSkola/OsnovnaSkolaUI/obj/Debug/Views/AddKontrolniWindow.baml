   M S B A M L   `   `   `  ����I  EOsnovnaSkolaUI, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null;"clr-namespace:OsnovnaSkolaUI.ViewsOsnovnaSkolaUI.Views  5   	   -    'OsnovnaSkolaUI.Views.AddKontrolniWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   4local"clr-namespace:OsnovnaSkolaUI.Views     5   	     � Title$  AddKontrolniWindow��5   	   $	��717��6$   $	��566��61    � 
ResizeMode$ NoResize=�6=    � WindowStartupLocation$ CenterScreen=�6S    � 	Resources 5	         TextBoxBaseControlTemplate �� 
TargetType ��Name �� CornerRadius ��Name �� Triggers	 P� Property
 P� Value �� Value �� 
TargetName �� Property��%�  &	        �� 5
   
   " ��6=   .R�5      �� $ Bd��5      #��z��5      ���	#FF252323#��z��5      $ 5��6E   ._�5      �� $ PART_ContentHost��6   5       5      P� 5      	 � {�
 .  . �5      �� # � ��63   $ Bd��6u    � ���� 5      # � ��63    � ��5      P� 5      	 � ��$

 Auto��6+   . �5      ��  � ��$	 100��61   5      P� 5      	 � ��$

 Auto��6,   . �5      ��  � ��$ 20��62   5      5      5      .��5      � 
���   �.+�5   
   �� $��Center=�6+   $
��Left=�6O   $��66��6j   $��
137,18,0,0q�6v   $	��Top=�6�   $	��299��6�   $��28(�6�   $��Segoe UI)�6�   ���	#FFFBFB9F��6   �� *Naslov+6�   �� 5!   
   #��[  6   $
��Left=�6I   $��39��6d    �� TextWrapping$
 Wrap=�6p   $	��Top=�6�   $	��464��6�   $��
55,163,0,0q�6�   ���	#FF2E2E2E���	#FFA7A9A8$��22(�66  ��6�   �� *NoviKontrolni.zadatak+ �� UpdateSourceTrigger$ PropertyChanged=�66  (  "System.Windows.Controls.DatePicker  5"   
   $��55,255,41,402q�6M      SelectedDate 6   �� * NoviKontrolni.datum_odrzavanja+6f   �� 5$   
   $��Zadatak:��6   $
��Left=�6$   $��40��6?   $��170,123,0,0q�6K   $	��Top=�6`   $	��227��6x   $��Segoe UI)�6�   ���	#FFFBFB9F$��22(�6�   $��Center=�6�   �� 5%   
   $��Datum odrzavanja:��6   $
��Left=�6-   $��42��6H   $��170,217,0,0q�6T   $	��Top=�6i   $	��227��6�   $��Segoe UI)�6�   ���	#FFFBFB9F$��22(�6�   $��Center=�6�   �� 5'   
   $
��Left=�6\   $	��Top=�6w   $	��221��6�   $��176,582,0,0q�6�   $��63��6�   $��Segoe UI)�6�   ���	#FFFBFB9F
������ 
�������$��36(�6  $
��Bold"�6$  ��6   �� *ButtonContent+��64   �� *AddKontrolniCommand+6$  �� 5(   
   $
��Left=�62   $��29��6M   $��
55,194,0,0q�6Y   $	��Top=�6m   $	��464��6�   $��Segoe UI)�6�   
���  ��$��14(�6�   ��6   �� *ErrorZadatak+6�   �� 5)   
   $
��Left=�69   $��29��6T   $��
55,286,0,0q�6`   $	��Top=�6t   $	��464��6�   $��Segoe UI)�6�   
���  ��$��14(�6�   ��6   �� *ErrorDatumZadavanja+6�   �� 5,   
   $��Obrisi��6    �� 	IsDefault . $
��Left=�6�   $��24(�6�   $	��Top=�6�   $	��221��6�   $��176,534,0,0q�6�   $��48��6�    J� RenderTransformOrigin$ 0.769,0.381&�6�   $��Segoe UI)�6  
������ 
����������	#FFFBFB9F$
��Bold"�6t  y�6#   �� *DeletionEnabled+��6[   �� *DeleteKontrolniCommand+6t  5.      5/      