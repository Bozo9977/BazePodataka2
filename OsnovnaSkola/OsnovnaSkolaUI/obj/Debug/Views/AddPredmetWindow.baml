   M S B A M L   `   `   `  ����I  EOsnovnaSkolaUI, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null;"clr-namespace:OsnovnaSkolaUI.ViewsOsnovnaSkolaUI.Views  5   	   +    %OsnovnaSkolaUI.Views.AddPredmetWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   4local"clr-namespace:OsnovnaSkolaUI.Views     5   	     � Title$  AddPredmetWindow��5   	   $	��717��6"   $	��566��6/    � 
ResizeMode$ NoResize=�6;    � WindowStartupLocation$ CenterScreen=�6Q    � 	Resources 5	         TextBoxBaseControlTemplate �� 
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
 Wrap=�6p   $	��Top=�6�   $	��227��6�   $��170,163,0,0q�6�   ���	#FF2E2E2E���	#FFA7A9A8$��22(�63  ��6�   �� *NoviPredmet.naziv+ �� UpdateSourceTrigger$ PropertyChanged=�63  �� 5"   
   #��[  6   $
��Left=�6I   $��39��6d   $��170,259,0,0q�6p   $
 Wrap=�6�   $	��Top=�6�   $	��227��6�   ���	#FF2E2E2E���	#FFA7A9A8$��22(�64  ��6�   �� *NoviPredmet.razred+$ PropertyChanged=�64  �� 5#   
   #��[  6   $
��Left=�6J   $��39��6e   $��170,351,0,0q�6q   $
 Wrap=�6�   $	��Top=�6�   $	��227��6  ���	#FF2E2E2E���	#FFA7A9A8$��22(�6;  ��6�   �� *NoviPredmet.broj_oblasti+$ PropertyChanged=�6;  �� 5%   
   $��Naziv:��6   $
��Left=�6"   $��40��6=   $��170,123,0,0q�6I   $	��Top=�6^   $	��227��6v   $��Segoe UI)�6�   ���	#FFFBFB9F$��22(�6�   $��Center=�6�   �� 5&   
   $��Razred:��6   $
��Left=�6#   $��42��6>   $��170,217,0,0q�6J   $	��Top=�6_   $	��227��6w   $��Segoe UI)�6�   ���	#FFFBFB9F$��22(�6�   $��Center=�6�   �� 5'   
   $��Broj oblasti:��6   $
��Left=�6)   $��36��6D   $��170,315,0,0q�6P   $	��Top=�6e   $	��227��6}   $��Segoe UI)�6�   ���	#FFFBFB9F$��22(�6�   $��Center=�6�   �� 5)   
   $	��ADD��6   $
��Left=�6d   $	��Top=�6   $	��221��6�   $��176,582,0,0q�6�   $��63��6�   $��Segoe UI)�6�   ���	#FFFBFB9F
������ 
�������$��36(�6  $
��Bold"�6,  y�6   �� *	Visible+��6>   �� *AddPredmetCommand+6,  �� 5+   
   $
��Left=�60   $��29��6K   $��170,194,0,0q�6W   $	��Top=�6l   $	��227��6�   $��Segoe UI)�6�   
���  ��$��14(�6�   ��6   �� *
ErrorNaziv+6�   �� 5,   
   $
��Left=�61   $��29��6L   $��170,286,0,0q�6X   $	��Top=�6m   $	��227��6�   $��Segoe UI)�6�   
���  ��$��14(�6�   ��6   �� *ErrorRazred+6�   �� 5-   
   $
��Left=�66   $��30��6Q   $��170,384,0,0q�6]   $	��Top=�6r   $	��227��6�   $��Segoe UI)�6�   
���  ��$��14(�6�   ��6   �� *ErrorBrojOblasti+6�   �� 5.   
   $��CHANGE��6   $
��Left=�6k   $	��Top=�6�   $	��221��6�   $��176,582,0,0q�6�   $��63��6�   $��Segoe UI)�6�   ���	#FFFBFB9F
������ 
�������$��36(�6%  $
��Bold"�63  y�6"   �� *
Visible2+��6B   �� *ChangePredmetCommand+63  51      52      