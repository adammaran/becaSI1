   M S B A M L   `   `   `  ����L  HAutoProdavnicaNew, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null5clr-namespace:AutoProdavnicaNewAutoProdavnicaNew  5   	   !    AutoProdavnicaNew.Korisnici   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   1localclr-namespace:AutoProdavnicaNew     5   	     � Title$  	Korisnici��5   	   $	��450��6   $	��800��6(   .��5	      � .+�5
   
   �� $��Korisnicko ime��6   $
��Left=�6)   $��	60,30,0,0q�6D   $	��Top=�6W   �� 5   
   $��Sifra��6   $
��Left=�6    $��	60,60,0,0q�6;   $	��Top=�6N   �� 5   
   -   5         ��Name$ txtIme��5      $
��Left=�6"   $��23��6=   $��
150,30,0,0q�6I    �� TextWrapping$
 Wrap=�6]   $	��Top=�6q   $	��120��6�   �� 5   
   -   5        $ 
txtPrezime��5      $
��Left=�6&   $��23��6A   $��
150,60,0,0q�6M   $
 Wrap=�6a   $	��Top=�6u   $	��120��6�   �� 5   
   -   5         ��Name$ cbsKorisnikId��5      $
��Left=�6*   $��
150,88,0,0q�6E   $	��Top=�6Y   $	��120��6q   6}   �� 5   
   -   5         ��Name$ btnDodaj��5      $��Dodaj��6#   $
��Left=�63   $��
327,36,0,0q�6N   $	��Top=�6b   $��75��6z   6�   �� 5   
   -   5        $ 
btnIzaberi��5      $��Izaberi��6%   $
��Left=�67   $��
620,35,0,0q�6R   $	��Top=�6f   $��75��6~   6�   �� 5   
   -   5        $ 	btnIzmeni��5      $��Izmeni��6$   $
��Left=�65   $��
426,36,0,0q�6P   $	��Top=�6d   $��75��6|   6�   �� 5   
   -   5        $ 	btnObrisi��5      $��Obriši��6$   $
��Left=�65   $��
522,35,0,0q�6P   $	��Top=�6d   $��75��6|   6�   &   System.Windows.Controls.DataGrid  5   
   -   5          Name$ DataGridFudbaler��5         AutoGenerateColumns .  $
��Left=�6I   $	��258��6d   $��
60,132,0,0q�6q   $	��Top=�6�   $	��635��6�      Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$ Id korisnika��6E   	   Width5  /System.Windows.Controls.DataGridLengthConverter$	 * 6[   1  +System.Windows.Controls.DataGridBoundColumn
   Binding
 6%   �� *korisnik_id+6[     5      $	 Ime��6H   $	 * 6U   
 6%   �� *korisnicko_ime+6U     5      $ Sifra��6?   $	 * 6N   
 6%   �� *sifra+6N   5      �� 5   
   $��	Korisnick��6   $
��Left=�6$   $��	60,91,0,0q�6?   $	��Top=�6R   5      5      