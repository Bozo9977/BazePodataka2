   M S B A M L   `   `   `  ����I  EOsnovnaSkolaUI, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null;"clr-namespace:OsnovnaSkolaUI.ViewsOsnovnaSkolaUI.Views  5   	   *    $OsnovnaSkolaUI.Views.AddUcenikWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   4local"clr-namespace:OsnovnaSkolaUI.Views     5   	     � Title$  Dodaj učenika��5   	   $	��505��6   $	��490��6,    � 
ResizeMode$ NoResize=�68    � WindowStartupLocation$ CenterScreen=�6N    � 	Resources 5	         FocusTextBox �� 
TargetType �� Triggers �� Binding �� ElementName �� Path	 �� Value
 �� Property �� Value��%�   &	        �� 5
   
   " �6%    5      �� 5       6   �� $ 
textBoxIme��$ 	IsVisible�	 True6Y   .a�5      �� 
 �@+�FocusedElement 6D   �� $ textBoxPrezime��5      5      5      .��5      � -   5         �Name$ 	LoginGrid��5      
���   �$��0,0,0,-1q�61   #��[  6C   .+�5   
   �� $��Novi učenik��6   $��Center=�6&   $��66��6J   $��
21,10,23,0q�6V   $	��Top=�6j   $��26(�6�   $��Segoe UI)�6�   ���	#FFFBFB9F6�   �� 5   
   $
��Ime:��6   $��Center=�6   $
��Left=�6C   $��34��6^   $��
113,93,0,0q�6j   $	��Top=�6~   $	��244��6�   $��Segoe UI)�6�   ���	#FFFBFB9F$��20(�6�   �� 5   
   -   5         ��Name$ ImeBox��5      $
��Left=�6"   $
��Left=�6=   $��Center=�6_   $��Khmer UI)�6�   $��20(�6�    �� TextWrapping$
 Wrap=�6�   $	��244��6�   $��113,137,0,0q�6   ���	#FF2E2E2E���	#FF282829���	#FFFBFB9F$��39��6[  $	��Top=�6g  ��6�   �� *Ime+ �� UpdateSourceTrigger$ PropertyChanged=�.��6   J� InputBindings 5      �� 5      
 �� Key$ Enter��6E    �� Command 6   �� *DodajUcenikaCommand+6E   .��5   %   5      �� 5   
   -   5        $��imeError��5   R   $��Center=�6b   $��Center=�6�   $
��Left=�6�   $��34��6�   $��
21,176,0,0q�6�   $	��Top=�6�   $	��440��6�   $��Segoe UI)�6  
���  ��$��16(�6.  ��6   �� *
ImeError+$ PropertyChanged=�6.  �� 5   
   $��Prezime:��6   $��Center=�6#   $
��Left=�6G   $��38��6b   $��113,218,0,0q�6n   $	��Top=�6�   $	��244��6�   $��Segoe UI)�6�   ���	#FFFBFB9F$��20(�6�   �� 5    
   -   5        $ 
PrezimeBox��5       $
��Left=�6'   ���	#FF2E2E2E$��1q�6�   ���	#FF282829$
��Left=�6�   $��Center=�6�   $��34��6  $	��243��6  ���	#FFFBFB9F$��114,261,0,169q�66  ��6Y   �� *	Prezime+$ PropertyChanged=�.��6M  5"      �� 5$   
   -   5        $��prezimeError��5$   V   $��Center=�6j   $��Center=�6�   $
��Left=�6�   $��34��6�   $��
21,323,0,0q�6�   $	��Top=�6�   $	��440��6  $��Segoe UI)�6  
���  ��$��16(�66  ��6   �� *PrezimeError+$ PropertyChanged=�66  �� 5&   
    �� 	IsDefault . $
��Left=�6�   $��24(�6�   $	��Top=�6�   $	��130��6�   $��168,382,0,0q�6�   $��48��6�    J� RenderTransformOrigin$ 0.769,0.381&�6�   $��Segoe UI)�6#  
������ 
����������	#FFFBFB9F$
��Bold"�6}  ��6   �� *ButtonContent+$ PropertyChanged=���6j   �� *AddUcenikCommand+6}  5(      5)      