   M S B A M L   `   `   `  ����L  Hhw_WPFMiniProject, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null5clr-namespace:hw_WPFMiniProjecthw_WPFMiniProject  5   	   $    hw_WPFMiniProject.AddressEntry   5   	   W SPresentationCore, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   1localclr-namespace:hw_WPFMiniProject     5   	   $��22(�5        � Title$  AddressEntry��5   	   $	��450��6   $	��800��6+   .��5	      �  � ColumnDefinitions 5
   
   �� 5      $��* �6   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $��* �6    � RowDefinitions 5   
   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $��* �6   .+�5   
   �� $��0��6   $��1��6!   $��2��61   $��38(�6E   $��Center=�5      $��0 20 0 0q�61   Address Entry5      �� 5   
   $��1��6   $��1��6!   $��0 20 5 0q�61   $��Right=�5       Street Address6@   �� 5!   
   -   5         ��Name$ streetAddressText��5!      $��1��6-   $��2��6:   $	��200��5"      $	��300��6!   $��0 20 0 0q�60   �� 5$   
   $��2��6   $��1��6!   $��0 20 5 0q�61   $��Right=�5%      City66   �� 5&   
   -   5        $ cityText��5&      $��2��6$   $��2��61   $	��200��5'      $	��300��6!   $��0 10 0 0q�60   �� 5)   
   $��3��6   $��1��6!   $��0 20 5 0q�61   $��Right=�5*      State67   �� 5+   
   -   5        $ 	stateText��5+      $��3��6%   $��2��62   $	��200��5,      $	��300��6!   $��0 20 0 0q�60   �� 5.   
   $��4��6   $��1��6!   $��0 20 5 0q�61   $��Right=�5/      
Zip Code6:   �� 50   
   -   5        $ zipCodeText��50      $��4��6'   $��2��64   $	��200��51      $	��300��6!   $��0 10 0 0q�60   �� 53   
   -   5         ��Name$ saveAddress��53      $��5��6&   $��1��63   $��2��6C   $
��0 20q�54      $
��0 10q�6   .��6H   Save6N   56      57      