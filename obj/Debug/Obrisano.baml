   M S B A M L   `   `   `  ����L  HAutoProdavnicaNew, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null5clr-namespace:AutoProdavnicaNewAutoProdavnicaNew  5   	        AutoProdavnicaNew.Obrisano   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   1localclr-namespace:AutoProdavnicaNew     5   	     � Title$  Obrisano��5   	   $	��450��6   $	��800��6'   .��5	      � .+�5
   
   �� -   5         ��Name$ txtFudbalerId��5
      $
��Left=�6)   $��23��6D   $��	150,0,0,0q�6P    �� TextWrapping$
 Wrap=�6c   $	��Top=�6w   $	��120��6�   $y�Hidden=�6�   �� 5   
   -   5         ��Name$ cbsKorisnikId��5      $
��Left=�6*   $��
150,32,0,0q�6E   $	��Top=�6Y   $	��120��6q   6}   �� 5   
   -   5         ��Name$ 
btnIzaberi��5      $��Izaberi��6%   $
��Left=�67   $��
291,33,0,0q�6R   $	��Top=�6f   $��75��6~   6�   &   System.Windows.Controls.DataGrid  5   
   -   5          Name$ DataGridDeleted��5         AutoGenerateColumns .  $
��Left=�6H   $	��314��6c   $��	60,76,0,0q�6p   $	��Top=�6�   $	��635��6�      Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$ Korisnik��6H   	   Width5  /System.Windows.Controls.DataGridLengthConverter$	 * 6Z   1  +System.Windows.Controls.DataGridBoundColumn
   Binding
 6%   �� *korisnicko_ime+6Z     5      $ Marka��6?   $	 * 6N   
 6%   �� *marka+6N     5      $ Model��6?   $	 * 6N   
 6%   �� *model+6N     5      $
 Cena��6>   $	 * 6L   
 6%   �� *cena+6L     5      $ Kilometraza��6E   $	 * 6Z   
 6%   �� *kilometraza+6Z     5      $ Godiste��6A   $	 * 6R   
 6%   �� *	godiste+6R   5      �� 5   
   $��Prodavac��6   $
��Left=�6#   $��	60,30,0,0q�6>   $	��Top=�6Q   5      5      