   M S B A M L   `   `   `  ����F  BAtomReaktor, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null)clr-namespace:AtomReaktorAtomReaktor  5   	       AtomReaktor.MainWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   +localclr-namespace:AtomReaktor     5   	   -   5          � Title$  
MainWindow��5   	   $	��450��6   $	��900��6)   $��20(�65    � 
ResizeMode$ NoResize=�6C   .��5	      �  � ColumnDefinitions 5
   
   �� 5      $��1* �6   �� 5      $��3* �6   �� 5      $��5* �6   �� 5      $��1* �6    � RowDefinitions 5   
   �� 5      $��1* �6   �� 5      $��2* �6   �� 5      $��1* �6   �� 5      $��1* �6   .+�5   
   �� $��1��6   $��1��6%   .+�5      �� -   5         ��Name$ lbOnOff��5      $��A reaktor működik��6%   �� 5      -   5        $ lbhofok��5      $��Hőfok: °C��6%   �� 5      -   5        $ lbgeneraltenergia��5      $��Generált Energia: GW��6/   5      �� 5   
   -   5         ��Name$ 
imgReaktor��5      $��2��6$   $��1��64   �� 5   
   $��1��6   $��2��6%    �� Orientation$ 
Horizontal=�62   $��2��6K   $��Center=�6_   .+�5      �� -   5         ��Name$ btnBeinditas��5      $��Beindítás��6+   $��10 20q�6?   6N   �� 5      -   5        $ btnLeallitas��5      $��Leállítás��6+   $��10 20q�6?   6N   �� 5      -   5        $ btnGeneraltEnergia��5      $"��Generált energia mennyiség��61   $��10 20q�6V   6e   �� 5       -	   5        $ btnHutovizBeengedese��5       $��Hűtővíz beengedése��63   $��10 20q�6P   6_   5!      �� 5"   
   -
   5        $ 
btnKilepes��5"      $��	Kilépés��6%   $��2��67   $��3��6G   $��Right=�6T   $��10 20 30 30q�6p   6�   5#      5$      