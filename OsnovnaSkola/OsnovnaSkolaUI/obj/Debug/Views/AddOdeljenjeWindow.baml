   M S B A M L   `   `   `  ����I  EOsnovnaSkolaUI, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null;"clr-namespace:OsnovnaSkolaUI.ViewsOsnovnaSkolaUI.Views  5   	   -    'OsnovnaSkolaUI.Views.AddOdeljenjeWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   4local"clr-namespace:OsnovnaSkolaUI.Views     5   	     � Title$  Dodaj odeljenje��5      $��404.281��6    $	��490��61    � 
ResizeMode$ NoResize=�6=    � WindowStartupLocation$ CenterScreen=�6S    � 	Resources 5	         FocusTextBox �� 
TargetType �� Triggers �� Binding �� ElementName �� Path	 �� Value
 �� Property �� Value��%�   &	        �� 5
   
   " �6%    5      �� 5       6   �� $ 
textBoxIme��$ 	IsVisible�	 True6Y   .a�5      �� 
 �@+�FocusedElement 6D   �� $ textBoxPrezime��5      5      5      .��5      � -   5         �Name$ 	LoginGrid��5      
���   �$��0,0,0,-1q�61   #��[  6C   .+�5   
   �� $��Novo odeljenje��6   $��Center=�6)   $��66��6M   $��
21,10,23,0q�6Y   $	��Top=�6m   $��26(�6�   $��Segoe UI)�6�   ���	#FFFBFB9F6�   �� 5   
   $��Razred:��6   $��Center=�6"   $
��Left=�6F   $��34��6a   $��
113,93,0,0q�6m   $	��Top=�6�   $	��244��6�   $��Segoe UI)�6�   ���	#FFFBFB9F$��20(�6�   �� 5   
   -   5         ��Name$ ImeBox��5      $
��Left=�6"   $
��Left=�6>   $��Center=�6`   $��Khmer UI)�6�   $��20(�6�    �� TextWrapping$
 Wrap=�6�   $	��244��6�   $��113,137,0,0q�6  ���	#FF2E2E2E���	#FF282829���	#FFFBFB9F$��39��6_  $	��Top=�6k  ��6�   �� *Razred+ �� UpdateSourceTrigger$ PropertyChanged=�.��6�   J� InputBindings 5      �� 5      
 �� Key$ Enter��6E    �� Command 6   �� *AddOdeljenjeCommand+6E   .��5   %   5      �� 5   
   -   5        $��imeError��5   U   $��Center=�6e   $��Center=�6�   $
��Left=�6�   $��34��6�   $��
21,176,0,0q�6�   $	��Top=�6�   $	��440��6�   $��Segoe UI)�6
  
���  ��$��16(�61  ��6   �� *RazredError+$ PropertyChanged=�61  �� 5   
    �� 	IsDefault . $
��Left=�6�   $��24(�6�   $	��Top=�6�   $	��130��6�   $��168,233,0,0q�6�   $��48��6�    J� RenderTransformOrigin$ 0.769,0.381&�6  $��Segoe UI)�6&  
������ 
����������	#FFFBFB9F$
��Bold"�6�  ��6   �� *ButtonContent+$ PropertyChanged=���6j   �� *AddOdeljenjeCommand+6�  5!      5"      