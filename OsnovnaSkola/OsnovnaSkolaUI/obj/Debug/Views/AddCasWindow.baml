   M S B A M L   `   `   `  ����I  EOsnovnaSkolaUI, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null;"clr-namespace:OsnovnaSkolaUI.ViewsOsnovnaSkolaUI.Views  5   	   '    !OsnovnaSkolaUI.Views.AddCasWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   4local"clr-namespace:OsnovnaSkolaUI.Views     5   	     � Title$  Novi Cas��5   
   $��607.491��6   $	��490��6,    � 
ResizeMode$ NoResize=�68    � WindowStartupLocation$ CenterScreen=�6N    � 	Resources 5	         FocusTextBox �� 
TargetType �� Triggers �� Binding �� ElementName �� Path	 �� Value
 �� Property �� Value��%�   &	        �� 5
   
   " �6%    5      �� 5       6   �� $ 
textBoxIme��$ 	IsVisible�	 True6Y   .a�5      �� 
 �@+�FocusedElement 6D   �� $ textBoxPrezime��5      5      5      .��5      � -   5         �Name$ 	LoginGrid��5      
���   �$��0,0,0,-1q�61   #��[  6C   .+�5   
   �� $��Novi Cas��6   $��Center=�6#   $��66��6G   $��
21,10,23,0q�6S   $	��Top=�6g   $��26(�6�   $��Segoe UI)�6�   ���	#FFFBFB9F6�   �� 5   
   $��Pocetak:��6   $��Center=�6#   $
��Left=�6G   $��34��6b   $��113,193,0,0q�6n   $	��Top=�6�   $	��244��6�   $��Segoe UI)�6�   ���	#FFFBFB9F$��20(�6�   �� 5   
   -   5         ��Name$ ImeBox��5      $
��Left=�6"   $
��Left=�6=   $��Center=�6_   $��Khmer UI)�6�   $��20(�6�    �� TextWrapping$
 Wrap=�6�   $	��244��6�   $��113,232,0,0q�6  ���	#FF2E2E2E���	#FF282829���	#FFFBFB9F$��39��6_  $	��Top=�6k  ��6�   �� *	Pocetak+ �� UpdateSourceTrigger$ PropertyChanged=�.��6�   J� InputBindings 5      �� 5      
 �� Key$ Enter��6?    �� Command 6   �� *AddCasCommand+6?   .��5   %   5      �� 5   
   -   5        $��imeError��5   V   $��Center=�6f   $��Center=�6�   $
��Left=�6�   $��21,276,0,266q�6�   $	��440��6�   $��Segoe UI)�6�   
���  ��$��16(�6  ��6   �� *PocetakError+$ PropertyChanged=�6  �� 5   
   $��Datum odrzavanja:��6   $��Center=�6,   $
��Left=�6P   $��38��6k   $��
113,76,0,0q�6w   $	��Top=�6�   $	��244��6�   $��Segoe UI)�6�   ���	#FFFBFB9F$��20(�6�   (  "System.Windows.Controls.DatePicker  5#   
   $��113,119,127,425q�6=      SelectedDate 6   �� *SelectedDatum+6X   �� 5%   
   -   5        $��prezimeError��5%   S   $��Center=�6g   $��Center=�6�   $
��Left=�6�   $��34��6�   $��
21,154,0,0q�6�   $	��Top=�6�   $	��440��6   $��Segoe UI)�6  
���  ��$��16(�63  ��6   �� *	DateError+$ PropertyChanged=�63  �� 5'   
    �� 	IsDefault . $
��Left=�6g   $��24(�6�   $	��Top=�6�   $	��130��6�   $��169,515,0,0q�6�   $��48��6�    J� RenderTransformOrigin$ 0.769,0.381&�6�   $��Segoe UI)�6�   
������ 
����������	#FFFBFB9F$
��Bold"�6U  ��6   �� *ButtonContent+��6E   �� *AddCasCommand+6U  �� 5(   
   $��Kraj:��6   $��Center=�6    $
��Left=�6D   $��34��6_   $��113,334,0,0q�6k   $	��Top=�6�   $	��244��6�   $��Segoe UI)�6�   ���	#FFFBFB9F$��20(�6�   �� 5)   
   -   5        $ ImeBox_Copy��5)      $
��Left=�6'   $
��Left=�6B   $��Center=�6d   $��Khmer UI)�6�   $��20(�6�   $
 Wrap=�6�   $	��244��6�   $��113,373,0,0q�6  ���	#FF2E2E2E���	#FF282829���	#FFFBFB9F$��39��6a  $	��Top=�6m  ��6�   �� *Kraj+$ PropertyChanged=�.��6�   5*      �� 5+      $ Enter��6?    6   �� *AddCasCommand+6?   .��5,   %   5-      �� 5.   
   -   5         ��Name$ imeError_Copy��5.   S   $��Center=�6j   $��Center=�6�   $
��Left=�6�   $��21,417,0,112q�6�   $	��440��6�   $��Segoe UI)�6�   
���  ��$��16(�6  ��6   �� *	KrajError+$ PropertyChanged=�6  �� 5/   
   $��Obrisi��6    . $
��Left=�6�   $��24(�6�   $	��Top=�6�   $	��130��6�   $��169,472,0,0q�6�   $��48��6�   $ 0.769,0.381&�6�   $��Segoe UI)�6  
������ 
����������	#FFFBFB9F$
��Bold"�6n  y�6#   �� *DeletionEnabled+��6[   �� *DeleteCasCommand+6n  51      52      