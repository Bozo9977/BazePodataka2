   M S B A M L   `   `   `  ����I  EOsnovnaSkolaUI, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null;"clr-namespace:OsnovnaSkolaUI.ViewsOsnovnaSkolaUI.Views  5   	   .    (OsnovnaSkolaUI.Views.AddPRedavanjeWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   4local"clr-namespace:OsnovnaSkolaUI.Views     5   	     � Title$  Novo Predavanje��5   	   $	��505��6!   $	��490��6.    � 
ResizeMode$ NoResize=�6:    � WindowStartupLocation$ CenterScreen=�6P    � 	Resources 5	         FocusTextBox �� 
TargetType �� Triggers �� Binding �� ElementName �� Path	 �� Value
 �� Property �� Value��%�   &	        �� 5
   
   " �6%    5      �� 5       6   �� $ 
textBoxIme��$ 	IsVisible�	 True6Y   .a�5      �� 
 �@+�FocusedElement 6D   �� $ textBoxPrezime��5      5      5      .��5      � -   5         �Name$ 	LoginGrid��5      
���   �$��0,0,0,-1q�61   #��[  6C   .+�5   
   �� $��Novo predavanje��6   $��Center=�6*   $��66��6N   $��
21,10,23,0q�6Z   $	��Top=�6n   $��26(�6�   $��Segoe UI)�6�   ���	#FFFBFB9F6�   �� 5   
   $��Opis:��6   $��Center=�6    $
��Left=�6D   $��34��6_   $��
113,93,0,0q�6k   $	��Top=�6   $	��244��6�   $��Segoe UI)�6�   ���	#FFFBFB9F$��20(�6�   �� 5   
   -   5         ��Name$ ImeBox��5      $
��Left=�6"   $
��Left=�6=   $��Center=�6_   $��Khmer UI)�6�   $��20(�6�    �� TextWrapping$
 Wrap=�6�   $	��244��6�   $��113,137,0,0q�6  ���	#FF2E2E2E���	#FF282829���	#FFFBFB9F$��39��6\  $	��Top=�6h  ��6�   �� *Opis+ �� UpdateSourceTrigger$ PropertyChanged=�.��6�   J� InputBindings 5      �� 5      
 �� Key$ Enter��6F    �� Command 6   �� *AddPredavanjeCommand+6F   .��5   %   5      �� 5   
   -   5        $��imeError��5   S   $��Center=�6c   $��Center=�6�   $
��Left=�6�   $��34��6�   $��
21,176,0,0q�6�   $	��Top=�6�   $	��440��6�   $��Segoe UI)�6  
���  ��$��16(�6/  ��6   �� *	OpisError+$ PropertyChanged=�6/  �� 5   
   $��Datum odrzavanja:��6   $��Center=�6,   $
��Left=�6P   $��38��6k   $��113,218,0,0q�6w   $	��Top=�6�   $	��244��6�   $��Segoe UI)�6�   ���	#FFFBFB9F$��20(�6�   (  "System.Windows.Controls.DatePicker  5#   
   $��113,261,127,186q�6=      SelectedDate 6   �� *SelectedDatum+6X   �� 5%   
   -   5        $��prezimeError��5%   S   $��Center=�6g   $��Center=�6�   $
��Left=�6�   $��34��6�   $��
21,323,0,0q�6�   $	��Top=�6�   $	��440��6   $��Segoe UI)�6  
���  ��$��16(�63  ��6   �� *	DateError+$ PropertyChanged=�63  �� 5'   
   $��Dodaj��6    �� 	IsDefault . $
��Left=�6\   $��24(�6x   $	��Top=�6�   $	��130��6�   $��168,382,0,0q�6�   $��48��6�    J� RenderTransformOrigin$ 0.769,0.381&�6�   $��Segoe UI)�6�   
������ 
����������	#FFFBFB9F$
��Bold"�6J  ��63   �� *AddPredavanjeCommand+6J  5)      5*      