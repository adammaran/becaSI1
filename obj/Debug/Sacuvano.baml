   M S B A M L   `   `   `  ����L  HAutoProdavnicaNew, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null5clr-namespace:AutoProdavnicaNewAutoProdavnicaNew  5   	        AutoProdavnicaNew.Sacuvano   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   1localclr-namespace:AutoProdavnicaNew     5   	     � Title$  Sacuvano��5   	   $	��450��6   $	��800��6'   .��5	      � .+�5
   
   �� -   5         ��Name$ txtFudbalerId��5
      $
��Left=�6)   $��23��6D   $��	150,0,0,0q�6P    �� TextWrapping$
 Wrap=�6c   $	��Top=�6w   $	��120��6�   $y�Hidden=�6�   �� 5   
   -   5         ��Name$ cbsKorisnikId��5      $
��Left=�6*   $��
150,26,0,0q�6E   $	��Top=�6Y   $	��120��6q   6}   �� 5   
   -   5         ��Name$ 
btnIzaberi��5      $��Izaberi��6%   $
��Left=�67   $��
400,27,0,0q�6R   $	��Top=�6f   $��76��6~   6�   �� 5   
   -   5        $ 	btnObrisi��5      $��Obriši��6$   $
��Left=�65   $��
302,27,0,0q�6P   $	��Top=�6d   $��76��6|   6�   &   System.Windows.Controls.DataGrid  5   
   -   5          Name$ DataGridSacuvano��5         AutoGenerateColumns .  $
��Left=�6I   $	��330��6d   $��	60,60,0,0q�6q   $	��Top=�6�   $	��635��6�      Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$ Id��6E   	   Width5  /System.Windows.Controls.DataGridLengthConverter$	 * 6Q   1  +System.Windows.Controls.DataGridBoundColumn
   Binding
 6%   �� *sacuvano_ID+6Q     5      $ Marka��6?   $	 * 6N   
 6%   �� *marka+6N     5      $ Model��6?   $	 * 6N   
 6%   �� *model+6N     5      $
 Cena��6>   $	 * 6L   
 6%   �� *cena+6L     5      $ Prodavac��6H   $	 * 6Z   
 6%   �� *korisnicko_ime+6Z   5      �� 5   
   $��Prodavac��6   $
��Left=�6#   $��	60,23,0,0q�6>   $	��Top=�6Q   5      5      