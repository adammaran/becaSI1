   M S B A M L   `   `   `  ����L  HAutoProdavnicaNew, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null5clr-namespace:AutoProdavnicaNewAutoProdavnicaNew  5   	       AutoProdavnicaNew.Prodaja   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   1localclr-namespace:AutoProdavnicaNew     5   	     � Title$  Prodaja��5   	   $	��450��6   $	��800��6&   .��5	      � .+�5
   
   �� $��Model��6   $
��Left=�6    $��	60,30,0,0q�6;   $	��Top=�6N   �� 5   
   $��Marka��6   $
��Left=�6    $��	60,60,0,0q�6;   $	��Top=�6N   �� 5   
   -   5         ��Name$ txtFudbalerId��5      $
��Left=�6)   $��23��6D   $��	150,0,0,0q�6P    �� TextWrapping$
 Wrap=�6c   $	��Top=�6w   $	��120��6�   $y�Hidden=�6�   �� 5   
   -   5         ��Name$ cbsProdavac��5      $
��Left=�6(   $��
150,88,0,0q�6C   $	��Top=�6W   $	��120��6o   6{   �� 5   
   -   5         ��Name$ btnDodaj��5      $��Dodaj��6#   $
��Left=�63   $��
327,36,0,0q�6N   $	��Top=�6b   $��75��6z   6�   �� 5   
   -   5        $ 	btnObrisi��5      $��Obriši��6$   $
��Left=�65   $��
425,36,0,0q�6P   $	��Top=�6d   $��75��6|   6�   &   System.Windows.Controls.DataGrid  5   
   -   5          Name$ DataGridFudbaler��5         AutoGenerateColumns .  $
��Left=�6I   $	��258��6d   $��
60,132,0,0q�6q   $	��Top=�6�   $	��635��6�      Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$ Prodavac��6H   	   Width5  /System.Windows.Controls.DataGridLengthConverter$	 * 6Z   1  +System.Windows.Controls.DataGridBoundColumn
   Binding
 6%   �� *korisnicko_ime+6Z     5      $ Marka��6?   $	 * 6N   
 6%   �� *marka+6N     5      $ Model��6?   $	 * 6N   
 6%   �� *model+6N   5      �� 5   
   $��Prodavac��6   $
��Left=�6#   $��	60,91,0,0q�6>   $	��Top=�6Q   �� 5   
   -   5        $ modelcbx��5      $
��Left=�6%   $��
151,32,0,0q�6@   $	��Top=�6T   $	��120��6l   6x   �� 5   
   -   5        $ markacbx��5      $
��Left=�6%   $��
151,60,0,0q�6@   $	��Top=�6T   $	��120��6l   6x   �� 5   
   -   5        $ cbsKupac��5      $
��Left=�6%   $��
382,88,0,0q�6@   $	��Top=�6T   $	��120��6l   6x   �� 5   
   $��Kupac��6   $
��Left=�6    $��
302,87,0,0q�6;   $	��Top=�6O   5      5      