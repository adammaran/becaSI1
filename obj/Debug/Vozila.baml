   M S B A M L   `   `   `  ����L  HAutoProdavnicaNew, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null5clr-namespace:AutoProdavnicaNewAutoProdavnicaNew  5   	       AutoProdavnicaNew.Vozila   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   1localclr-namespace:AutoProdavnicaNew     5   	     � Title$  Vozila��5   	   $	��450��6   $	��800��6%   .��5	      � .+�5
   
   �� $��Marka��6   $
��Left=�6    $��	60,30,0,0q�6;   $	��Top=�6N   �� 5   
   $
��Cena��6   $
��Left=�6   $��	60,60,0,0q�6:   $	��Top=�6M   �� 5   
   $��Model��6   $
��Left=�6    $��	60,90,0,0q�6;   $	��Top=�6N   �� 5   
   -   5         ��Name$ txtMarka��5      $
��Left=�6$   $��23��6?   $��
150,30,0,0q�6K    �� TextWrapping$
 Wrap=�6_   $	��Top=�6s   $	��120��6�   �� 5   
   -   5        $ txtCena��5      $
��Left=�6#   $��23��6>   $��
150,60,0,0q�6J   $
 Wrap=�6^   $	��Top=�6r   $	��120��6�   �� 5   
   -   5        $ txtModel��5      $
��Left=�6$   $��23��6?   $��
150,90,0,0q�6K   $
 Wrap=�6_   $	��Top=�6s   $	��120��6�   �� 5   
   -   5        $ 
txtGodiste��5      $
��Left=�6&   $��23��6A   $��150,123,0,0q�6M   $
 Wrap=�6b   $	��Top=�6v   $	��120��6�   �� 5   
   -   5        $ txtKilometraza��5      $
��Left=�6*   $��23��6E   $��150,156,0,0q�6Q   $
 Wrap=�6f   $	��Top=�6z   $	��120��6�   �� 5   
   -   5         ��Name$ btnDodaj��5      $��Dodaj��6#   $
��Left=�63   $��
400,27,0,0q�6N   $	��Top=�6b   $��75��6z   6�   �� 5   
   -   5        $ 	btnIzmeni��5      $��Izmeni��6$   $
��Left=�65   $��
400,63,0,0q�6P   $	��Top=�6d   $��75��6|   6�   �� 5   
   -   5        $ 	btnObrisi��5      $��Obriši��6$   $
��Left=�65   $��
400,98,0,0q�6P   $	��Top=�6d   $��75��6|   6�   &   System.Windows.Controls.DataGrid  5   
   -	   5          Name$ DataGridVozila��5         AutoGenerateColumns .  $
��Left=�6G   $	��150��6b   $��
60,240,0,0q�6o   $	��Top=�6�   $	��635��6�      Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$ Marka��6?      Width5  /System.Windows.Controls.DataGridLengthConverter$ * 6N   1  +System.Windows.Controls.DataGridBoundColumn	   Binding	 6%   �� *marka+6N     5      $
 Cena��6>   $ * 6L   	 6%   �� *cena+6L     5      $ Model��6?   $ * 6N   	 6%   �� *model+6N     5      $ Godiste��6A   $ * 6R   	 6%   �� *	godiste+6R     5      $ Kilometraza��6E   $ * 6Z   	 6%   �� *kilometraza+6Z     5      $ Vlasnik��6H   $ * 6Y   	 6%   �� *korisnicko_ime+6Y   5      �� 5   
   $��Godiste��6   $
��Left=�6"   $��
60,121,0,0q�6=   $	��Top=�6Q   �� 5    
   $��Kilometraza��6   $
��Left=�6&   $��
60,151,0,0q�6A   $	��Top=�6U   �� 5!   
   -
   5        
 ��Name$
 cbsKorisnikId��5!      $
��Left=�6*   $��487,183,0,0q�6E   $	��Top=�6Z   $	��120��6r   6~   �� 5"   
   $��Vlasnik��6   $
��Left=�6"   $��400,180,0,0q�6=   $	��Top=�6R   �� 5#   
   -   5        $ 
btnIzaberi��5#      $��Izaberi��6%   $
��Left=�67   $��400,131,0,0q�6R   $	��Top=�6g   $��75��6   6�   �� 5$   
   -   5        $
 cbsProdavac��5$      $
��Left=�6(   $��150,191,0,0q�6C   $	��Top=�6X   $	��120��6p   6|   �� 5%   
   $��Prodavac��6   $
��Left=�6#   $��
63,188,0,0q�6>   $	��Top=�6R   �� 5&   
   -   5        $ 
btnSacuvaj��5&      $��Sacuvaj��6%   $
��Left=�67   $��400,159,0,0q�6R   $	��Top=�6g   $��75��6   6�   5'      5(      