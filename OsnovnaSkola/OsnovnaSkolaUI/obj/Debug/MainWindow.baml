   M S B A M L   `   `   `  ����I  EOsnovnaSkolaUI, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null/clr-namespace:OsnovnaSkolaUIOsnovnaSkolaUI  5   	       OsnovnaSkolaUI.MainWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   .localclr-namespace:OsnovnaSkolaUI     5   	     � Title$  
MainWindow��5   	    � WindowStartupLocation$ CenterScreen=�6   $��662.65��6B   $
��1359��6R    � 
ResizeMode$ NoResize=�6_    � WindowState$ 	Maximized=�6u   .��5	      � 
���   �.+�5
   
   � .+�5      �� $	��Ime��6   $
��Bold"�6"   $
��Left=�64   $��10,0,0,0q�6O   $	��Top=�6a   
��� ���6y   �� 5      -   5         ��Name$	 Ime��5      $
��Left=�6%   $��	10,26,0,0q�6@   $
��Wrap=�6S   $	��Top=�6�   $	��124��6�   ���	#FFFBFB9F��6g   �� *LoggedIn.ime+6�   �� 5      $��Prezime��6   $
��Bold"�6&   $
��Left=�68   $��	10,42,0,0q�6S   $	��Top=�6f   
��� ���6~   �� 5      -   5        $ Prezime��5      $
��Left=�6)   $��	10,68,0,0q�6D   $
��Wrap=�6W   $	��Top=�6�   $	��124��6�   ���	#FFFBFB9F��6k   �� *LoggedIn.prezime+6�   �� 5      $��Zvanje��6   $
��Bold"�6&   $
��Left=�68   $��	10,89,0,0q�6S   $	��Top=�6f   
��� ��� J� RenderTransformOrigin$ 0.405,-1.945&�6�   �� 5      -   5        $ Zvanje��5      $
��Left=�6(   $��
10,115,0,0q�6C   $
��Wrap=�6W   $	��Top=�6�   $	��124��6�   ���	#FFFBFB9F��6k   �� *LoggedIn.zvanje+6�   �� 5      $��Change��6   
���   �$��Center=�6~   $��10,136,1211,0q�6�   $	��Top=�6�   $	��132��6�   $��22(�6�   ���	#FFFBFB9F
��� ���$��40��6  ��6&   �� *ChangeInfoCommand+y�6L   �� *	IsAdmin+6  5      �� 5   
   -   5        $��
TabControl��5      $��472,236,10,10q�6'   .@�5      �� $��	Zaposleni��6   y�6)   �� *AuthorizeAdmin+.��5      &   System.Windows.Controls.DataGrid     ColumnWidth5  /System.Windows.Controls.DataGridLengthConverter$ * 6�      AutoGenerateColumns .     
IsReadOnly . y�6   �� *AuthorizeAdmin+��6A   �� *	Zaposleni+	 �� UpdateSourceTrigger$	 PropertyChanged=�
 �� Mode$
 TwoWay=� �� SelectedItem 6�   �� *SelectedZaposleni+   Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$ Id��6-    �� TextAlignment$ Center=�69      
IsReadOnly . 1  +System.Windows.Controls.DataGridBoundColumn   Binding 6Z   �� *Id_zaposlenog+   ElementStyle 5      �� 5   "    �� 
TargetType" ��6(   .�5    &   ��  �� Property � �� �� Value$
 Wrap=�6E   �� 5!   &    � ��$ Center=�6L   �� 5"   &    � ��$ Center=�6J   5#   #   5%        5'      $	 Ime��6-   $ Center=�6:    .  6[   �� *ime+ 5(      �� 5)   "   " ��6(   .�5*   &   ��  � ��$
 Wrap=�6E   �� 5+   &    � ��$ Center=�6L   �� 5,   &    � ��$ Center=�6J   5-   #   5/        51      $ Prezime��6-   $ Center=�6>    .  6_   �� *	prezime+ 52      �� 53   "   " ��6(   .�54   &   ��  � ��$
 Wrap=�6E   �� 55   &    � ��$ Center=�6L   �� 56   &    � ��$ Center=�6J   57   #   59        5;      $ Zvanje��6-   $ Center=�6=    .  6^   �� *zvanje+ 5<      �� 5=   "   " ��6(   .�5>   &   ��  � ��$
 Wrap=�6E   �� 5?   &    � ��$ Center=�6L   �� 5@   &    � ��$ Center=�6J   5A   #   5C      4  .System.Windows.Controls.DataGridTemplateColumn  5E      $ Dodaj predmet��61      CellTemplate 5F      �� 5G   "   .R�5H   &   �� {�6-   �� *	Nastavnik+��6M   ��  �� RelativeSource ��  �� Mode$ FindAncestor=� �� AncestorType"   �� Path$) #DataContext.ZaposleniPredmetCommand���6�   �� .��6�   Dodaj Predmet6	  5I   #   5K      5O      5P      �� 5S      $��Ucenici��6   y�6'   �� *AuthorizeAdmin+.��5T        $ * 6�    .   . y�6   �� *AuthorizeAdmin+��6A   �� *	Ucenici+$	 PropertyChanged=�$
 TwoWay=� 6�   �� *SelectedUcenik+ 5U        5V      $ Id��6-   $ Center=�69    .  6Z   �� *
Id_ucenika+ 5W      �� 5X   "   " ��6(   .�5Y   &   ��  � ��$
 Wrap=�6E   �� 5Z   &    � ��$ Center=�6L   �� 5[   &    � ��$ Center=�6J   5\   #   5^        5`      $	 Ime��6-   $ Center=�6:    .  6[   �� *ime+ 5a      �� 5b   "   " ��6(   .�5c   &   ��  � ��$
 Wrap=�6E   �� 5d   &    � ��$ Center=�6L   �� 5e   &    � ��$ Center=�6J   5f   #   5h        5j      $ Prezime��6-   $ Center=�6>    .  6_   �� *	prezime+ 5k      �� 5l   "   " ��6(   .�5m   &   ��  � ��$
 Wrap=�6E   �� 5n   &    � ��$ Center=�6L   �� 5o   &    � ��$ Center=�6J   5p   #   5r        5t      $ Dodaj odeljenje��61    5u      �� 5v   "   .R�5w   &   �� ��6-   ��  �� $ FindAncestor=�"  $( "DataContext.UcenikOdeljenjeCommand���6�   �� .��6�   Dodaj odeljenje6�   5x   #   5z      5}      5~      �� 5�      $��	Odeljenja��6   y�6)   �� *AuthorizeAdmin+.��5�        $ * 6�    .   . y�6   �� *AuthorizeAdmin+��6A   �� *	Odeljenja+$	 PropertyChanged=�$
 TwoWay=� 6�   �� *SelectedOdeljenje+ 5�        5�      $ Id��6-   $ Center=�69    .  6Z   �� *Id_odeljenja+ 5�      �� 5�   "   " ��6(   .�5�   &   ��  � ��$
 Wrap=�6E   �� 5�   &    � ��$ Center=�6L   �� 5�   &    � ��$ Center=�6J   5�   #   5�        5�      $ Razred��6-   $ Center=�6=    .  6^   �� *razred+ 5�      �� 5�   "   " ��6(   .�5�   &   ��  � ��$
 Wrap=�6E   �� 5�   &    � ��$ Center=�6L   �� 5�   &    � ��$ Center=�6J   5�   #   5�        5�      $ Razredni��6-   $ Center=�6?    .  6`   �� *
Razredni+ 5�      �� 5�   "   " ��6(   .�5�   &   ��  � ��$
 Wrap=�6E   �� 5�   &    � ��$ Center=�6L   �� 5�   &    � ��$ Center=�6J   5�   #   5�        5�      $ Dodaj razrednog��61    5�      �� 5�   "   .R�5�   &   �� ��6-   ��  �� $ FindAncestor=�"  $% DataContext.AddRazrednogCommand���6�   �� .��6�   
Razredni6�   5�   #   5�        5�      $  Dodaj nastavnika/učitelja��61    5�      �� 5�   "   .R�5�   &   �� ��6.   ��  �� $ FindAncestor=�"  $% DataContext.AddNastavnikCommand���6�   �� .��6�   Nastavnik/učitelj6�   5�   #   5�      5�      5�      �� 5�      $��Predmeti��6   y�6(   �� *AuthorizeAdmin+.��5�        $ * 6�    .   . y�6   �� *AuthorizeAdmin+��6A   �� *
Predmeti+$	 PropertyChanged=�$
 TwoWay=� 6�   �� *SelectedPredmet+ 5�        5�      $ Id��6-   $ Center=�69    .  6Z   �� *Id_predmeta+ 5�      �� 5�   "   " ��6(   .�5�   &   ��  � ��$
 Wrap=�6E   �� 5�   &    � ��$ Center=�6L   �� 5�   &    � ��$ Center=�6J   5�   #   5�        5�      $ Razred��6-   $ Center=�6=    .  6^   �� *razred+ 5�      �� 5�   "   " ��6(   .�5�   &   ��  � ��$
 Wrap=�6E   �� 5�   &    � ��$ Center=�6L   �� 5�   &    � ��$ Center=�6J   5�   #   5�        5�      $ Naziv��6-   $ Center=�6<    .  6]   �� *naziv+ 5�      �� 5�   "   " ��6(   .�5�   &   ��  � ��$
 Wrap=�6E   �� 5�   &    � ��$ Center=�6L   �� 5�   &    � ��$ Center=�6J   5�   #   5�        5�      $ Razred��6-   $ Center=�6=    .  6^   �� *broj_oblasti+ 5�      �� 5�   "   " ��6(   .�5�   &   ��  � ��$
 Wrap=�6E   �� 5�   &    � ��$ Center=�6L   �� 5�   &    � ��$ Center=�6J   5�   #   5�        5�      $ Dodaj oblast��61    5�      �� 5�   "   .R�5�   &   �� ��6-   ��  �� $ FindAncestor=�"  $" DataContext.AddOblastCommand���6�   �� .��6�   Nova oblast6�   5�   #   5�        5�      $ Izmeni oblast��61    5�      �� 5�   "   .R�5�   &   �� ��6-   ��  �� $ FindAncestor=�"  $% DataContext.ChangeOblastCommand���6�   �� .��6�   Izmeni oblast6�   5�   #   5�      5�      5�      �� 5�      $��Predmeti��6   y�6(   �� *	IsAdmin+.��5�        $ * 6�    .   . y�6   �� *	IsAdmin+��6:   �� *
Predmeti+$	 PropertyChanged=�$
 TwoWay=� 6�   �� *SelectedPredmet+ 5�        5�      $ Id��6-   $ Center=�69    .  6Z   �� *Id_predmeta+ 5      �� 5  "   " ��6(   .�5  &   ��  � ��$
 Wrap=�6E   �� 5  &    � ��$ Center=�6L   �� 5  &    � ��$ Center=�6J   5  #   5       5	     $ Razred��6-   $ Center=�6=    .  6^   �� *razred+ 5
     �� 5  "   " ��6(   .�5  &   ��  � ��$
 Wrap=�6E   �� 5  &    � ��$ Center=�6L   �� 5  &    � ��$ Center=�6J   5  #   5       5     $ Naziv��6-   $ Center=�6<    .  6]   �� *naziv+ 5     �� 5  "   " ��6(   .�5  &   ��  � ��$
 Wrap=�6E   �� 5  &    � ��$ Center=�6L   �� 5  &    � ��$ Center=�6J   5  #   5       5     $ Razred��6-   $ Center=�6=    .  6^   �� *broj_oblasti+ 5     �� 5   "   " ��6(   .�5!  &   ��  � ��$
 Wrap=�6E   �� 5"  &    � ��$ Center=�6L   �� 5#  &    � ��$ Center=�6J   5$  #   5&     5:     5;     �� 5=     $��
Predavanja��6   $��22��6T   $	��Top=�6`   y�6*   �� *AuthorizeZaposleni+.��5>       $ * 6�    .   . y�6   �� *AuthorizeZaposleni+��6E   �� *
Predavanja+$	 PropertyChanged=�$
 TwoWay=� 6�   �� *SelectedPredavanje+ 5?       5@     $ Id��6-   $ Center=�69    .  6Z   �� *Id_predavanja+ 5A     �� 5B  "   " ��6(   .�5C  &   ��  � ��$
 Wrap=�6E   �� 5D  &    � ��$ Center=�6L   �� 5E  &    � ��$ Center=�6J   5F  #   5H       5J     $
 Opis��6-   $ Center=�6;    .  6\   �� *opis+ 5K     �� 5L  "   " ��6(   .�5M  &   ��  � ��$
 Wrap=�6E   �� 5N  &    � ��$ Center=�6L   �� 5O  &    � ��$ Center=�6J   5P  #   5R       5U     $ Datum��6-   $ Center=�6<    .  6]   �� *datum_odrzavanja+ 5V     �� 5W  "   " ��6(   .�5X  &   ��  � ��$
 Wrap=�6E   �� 5Y  &    � ��$ Center=�6L   �� 5Z  &    � ��$ Center=�6J   5[  #   5]       5_     $ Oblast��6-   $ Center=�6=    .  6^   �� *OblastId_oblasti+ 5`     �� 5a  "   " ��6(   .�5b  &   ��  � ��$
 Wrap=�6E   �� 5c  &    � ��$ Center=�6L   �� 5d  &    � ��$ Center=�6J   5e  #   5g     5j     5k     �� 5n     $��Casovi��6   y�6&   �� *AuthorizeZaposleni+.��5o       $ * 6�    .   . y�6   �� *AuthorizeZaposleni+��6E   �� *Casovi+$	 PropertyChanged=�$
 TwoWay=� 6�   �� *SelectedCas+ 5p       5q     $ Id��6-   $ Center=�69    .  6Z   �� *	Id_casa+ 5r     �� 5s  "   " ��6(   .�5t  &   ��  � ��$
 Wrap=�6E   �� 5u  &    � ��$ Center=�6L   �� 5v  &    � ��$ Center=�6J   5w  #   5y       5{     $ Pocetak��6-   $ Center=�6>    .  6_   �� *	pocetak+ 5|     �� 5}  "   " ��6(   .�5~  &   ��  � ��$
 Wrap=�6E   �� 5  &    � ��$ Center=�6L   �� 5�  &    � ��$ Center=�6J   5�  #   5�       5�     $
 Kraj��6-   $ Center=�6;    .  6\   �� *kraj+ 5�     �� 5�  "   " ��6(   .�5�  &   ��  � ��$
 Wrap=�6E   �� 5�  &    � ��$ Center=�6L   �� 5�  &    � ��$ Center=�6J   5�  #   5�       5�     $ Datum��6-   $ Center=�6<    .  6]   �� *datum+ 5�     �� 5�  "   " ��6(   .�5�  &   ��  � ��$
 Wrap=�6E   �� 5�  &    � ��$ Center=�6L   �� 5�  &    � ��$ Center=�6J   5�  #   5�       5�     $ Oblast��6-   $ Center=�6=    .  6^   �� *OblastId_oblasti+ 5�     �� 5�  "   " ��6(   .�5�  &   ��  � ��$
 Wrap=�6E   �� 5�  &    � ��$ Center=�6L   �� 5�  &    � ��$ Center=�6J   5�  #   5�       5�     $ Izmena/Brisanje��61    5�     �� 5�  "   .R�5�  &   �� ��6-   ��  �� $ FindAncestor=�"  $" DataContext.ChangeCasCommand���6�   �� .��6�   Izmeni/Obrisi6�   5�  #   5�     5�     5�     �� 5�     $��Kontrolne tacke��6   y�6/   �� *AuthorizeZaposleni+.��5�       $ * 6�    .   . y�6   �� *AuthorizeZaposleni+��6E   �� *KontrolneTacke+$	 PropertyChanged=�$
 TwoWay=� 6�   �� *
SelectedKT+ 5�       5�     $ Id��6-   $ Center=�69    .  6Z   �� *Id_kontrolne_tacke+ 5�     �� 5�  "   " ��6(   .�5�  &   ��  � ��$
 Wrap=�6E   �� 5�  &    � ��$ Center=�6L   �� 5�  &    � ��$ Center=�6J   5�  #   5�       5�     $ Zadatak��6-   $ Center=�6>    .  6_   �� *	zadatak+ 5�     �� 5�  "   " ��6(   .�5�  &   ��  � ��$
 Wrap=�6E   �� 5�  &    � ��$ Center=�6L   �� 5�  &    � ��$ Center=�6J   5�  #   5�       5�     $ Izmena/Brisanje��61    5�     �� 5�  "   .R�5�  &   �� ��6-   ��  �� $ FindAncestor=�"  $% DataContext.ChangeDomaciCommand���6�   �� .��6�   Izmeni/Obrisi6�   5�  #   5�       5�     $ Oceni��61    5�     �� 5�  "   .R�5�  &   �� ��6-   ��  �� $ FindAncestor=�"  $ DataContext.OceniCommand���6�   �� .��6�   Oceni6�   5�  #   5�     5�     5�     �� 5�     $��	Odeljenja��6   y�6*   �� *	IsAdmin+.��5�       $ * 6�    .   . y�6   �� *	IsAdmin+��6;   �� *	Odeljenja+$	 PropertyChanged=�$
 TwoWay=� 6�   �� *SelectedOdeljenje+ 5        5     $ Id��6-   $ Center=�69    .  6Z   �� *Id_odeljenja+ 5     �� 5  "   " ��6(   .�5  &   ��  � ��$
 Wrap=�6E   �� 5  &    � ��$ Center=�6L   �� 5  &    � ��$ Center=�6J   5  #   5	       5     $ Razred��6-   $ Center=�6=    .  6^   �� *razred+ 5     �� 5  "   " ��6(   .�5  &   ��  � ��$
 Wrap=�6E   �� 5  &    � ��$ Center=�6L   �� 5  &    � ��$ Center=�6J   5  #   5       5     $ Razredni��6-   $ Center=�6?    .  6`   �� *
Razredni+ 5     �� 5  "   " ��6(   .�5  &   ��  � ��$
 Wrap=�6E   �� 5  &    � ��$ Center=�6L   �� 5  &    � ��$ Center=�6J   5  #   5     51     52     57     �� 5:  
   $��NoviZaposleni��6   
������ $��Segoe UI)�6�   ���	#FFFBFB9F
�������$	��181��6�   $��22(�6�   $��
50,267,0,0q�6�   $
��Left=�6   $��44��6  $	��Top=�6'  $ 
0.47,5.777&�6?  ��6)   �� *AddZaposleniCommand+y�6Q   �� *AuthorizeAdmin+6?  �� 5;  
   $��ObrisiZaposlenog��6   $
��Left=�6,   $��44��6�   $��231,267,0,0q�6�   $	��Top=�6�   $	��206��6�   ���	#FFFBFB9F
������ $��Segoe UI)�6  
�������$��22(�68  ��6G   �� *DeleteZaposleniCommand+y�6r   �� *AuthorizeAdmin+68  �� 5<  
   $��
NoviUcenik��6   
������ $��Segoe UI)�6�   ���	#FFFBFB9F
�������$	��149��6�   $��22(�6�   $��
82,316,0,0q�6�   $
��Left=�6�   $��44��6  $	��Top=�6!  $ 
0.47,5.777&�69  ��6&   �� *AddUcenikCommand+y�6K   �� *AuthorizeAdmin+69  �� 5=  
   $��IzmeniUcenika��6   
������ $��Segoe UI)�6�   ���	#FFFBFB9F
�������$	��150��6�   $��22(�6�   $��231,316,0,0q�6�   $
��Left=�6  $��44��6  $	��Top=�6(  $ 
0.47,5.777&�6@  ��6)   �� *ChangeUcenikCommand+y�6Q   �� *AuthorizeAdmin+6@  �� 5>  
   $��ObrisiUcenika��6   
������ $��Segoe UI)�6�   ���	#FFFBFB9F
�������$	��150��6�   $��22(�6�   $��162,365,0,0q�6�   $
��Left=�6  $��44��6  $	��Top=�6(  $ 
0.47,5.777&�6@  ��6)   �� *DeleteUcenikCommand+y�6Q   �� *AuthorizeAdmin+6@  �� 5?  
   $��NovoOdeljenje��6   
������ $��Segoe UI)�6�   ���	#FFFBFB9F
�������$	��162��6�   $��22(�6�   $��
70,414,0,0q�6�   $
��Left=�6   $��44��6  $	��Top=�6'  $ 
0.47,5.777&�6?  ��6)   �� *AddOdeljenjeCommand+y�6Q   �� *AuthorizeAdmin+6?  �� 5@  
   $��IzmeniOdeljenje��6   
������ $��Segoe UI)�6�   ���	#FFFBFB9F
�������$	��167��6�   $��22(�6�   $��231,414,0,0q�6�   $
��Left=�6  $��44��6!  $	��Top=�6-  $ 
0.47,5.777&�6E  ��6+   �� *ChangeOdeljenjeCommand+y�6V   �� *AuthorizeAdmin+6E  �� 5A  
   $��ObrisiOdeljenje��6   
������ $��Segoe UI)�6�   ���	#FFFBFB9F
�������$	��162��6�   $��22(�6�   $��150,463,0,0q�6�   $
��Left=�6  $��44��6!  $	��Top=�6-  $ 
0.47,5.777&�6E  ��6+   �� *DeleteOdeljenjeCommand+y�6V   �� *AuthorizeAdmin+6E  �� 5B  
   $��NoviPredmet��6   
������ $��Segoe UI)�6�   ���	#FFFBFB9F
�������$	��162��6�   $��22(�6�   $��
69,507,0,0q�6�   $
��Left=�6�   $��44��6  $	��Top=�6#  $ 
0.47,5.777&�6;  ��6'   �� *AddPredmetCommand+y�6M   �� *AuthorizeAdmin+6;  �� 5C  
   $��ObrisiPredmet��6   
������ $��Segoe UI)�6�   ���	#FFFBFB9F
�������$	��162��6�   $��22(�6�   $��231,507,0,0q�6�   $
��Left=�6  $��44��6  $	��Top=�6)  $ 
0.47,5.777&�6A  ��6)   �� *DeletePredmetCommand+y�6R   �� *AuthorizeAdmin+6A  �� 5D  
   $��IzmeniPredmet��6   
������ $��Segoe UI)�6�   ���	#FFFBFB9F
�������$	��162��6�   $��22(�6�   $��150,551,0,0q�6�   $
��Left=�6  $��44��6  $	��Top=�6)  $ 
0.47,5.777&�6A  ��6)   �� *ChangePredmetCommand+y�6R   �� *AuthorizeAdmin+6A  �� 5G  
   $��DodajPredavanje��6   $
��Left=�6+   $��44��6�   $��472,160,0,0q�6�   $	��Top=�6�   $	��206��6�   ���	#FFFBFB9F
������ $��Segoe UI)�6  
�������$��22(�61  ��6F   �� *CreatePredavanjeCommand+y�6r   �� *	IsAdmin+61  �� 5H  
   $��IzmeniPredavanje��6   $
��Left=�6,   $��44��6�   $��678,160,0,0q�6�   $	��Top=�6�   $	��206��6�   ���	#FFFBFB9F
������ $��Segoe UI)�6  
�������$��22(�62  ��6G   �� *ChangePredavanjeCommand+y�6s   �� *	IsAdmin+62  �� 5I  
   $��ObrisiPredavanje��6   $
��Left=�6,   $��44��6�   $��884,160,0,0q�6�   $	��Top=�6�   $	��206��6�   ���	#FFFBFB9F
������ $��Segoe UI)�6  
�������$��22(�62  ��6G   �� *DeletePredavanjeCommand+y�6s   �� *	IsAdmin+62  �� 5L  
   $��DodajCas��6   $
��Left=�6$   $��44��6�   $��
472,76,0,0q�6�   $	��Top=�6�   $	��122��6�   ���	#FFFBFB9F
������ $��Segoe UI)�6�   
�������$��22(�6"  ��6?   �� *CreateCasCommand+y�6d   �� *	IsAdmin+6"  �� 5M  
   $��DodajDomaci��6   $
��Left=�6'   $��44��6�   $��
613,76,0,0q�6�   $	��Top=�6�   $	��169��6�   ���	#FFFBFB9F
������ $��Segoe UI)�6�   
�������$��22(�6(  ��6B   �� *CreateDomaciCommand+y�6j   �� *	IsAdmin+6(  �� 5N  
   $��DodajKontrolni��6   $
��Left=�6*   $��44��6�   $��
800,76,0,0q�6�   $	��Top=�6�   $	��170��6�   ���	#FFFBFB9F
������ $��Segoe UI)�6  
�������$��22(�6.  ��6E   �� *CreateKontrolniCommand+y�6p   �� *	IsAdmin+6.  5P     5Q     