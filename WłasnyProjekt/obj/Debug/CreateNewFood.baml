   M S B A M L   `   `   `  ����I  EWłasnyProjekt, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null/clr-namespace:WłasnyProjektWłasnyProjekt  5   	   "    WłasnyProjekt.CreateNewFood   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   .localclr-namespace:WłasnyProjekt     5   	   -   5          �Name$  CreateNewFoodWindow2��5	   	    � Title$ Stwórz nowy posiłek��5   	   $��299.421��6%   $��433.961��66    � 
ResizeMode$ NoResize=�5
   	   .��5      �  � ColumnDefinitions 5   
   �� 5      �� 5       � RowDefinitions 5   
   �� 5      $��5* �6   �� 5      .+�5   
   �� $��10(�6   $
��bold"�6   $��0��60   $��2��6=   $��Center=�6Q   $��Bottom=�6n   .��6�   LJWartość odżywczą oraz makroskładniki należy podać dla 100g posiłku6�   �� 5   
   $��20q�6   .+�5      �� $��2q�6   .��6    Nazwa posiłku:60   �� 5      $��2q�6   .��6    Wartość odżywcza:63   �� 5      $��2q�6   .��6    Ilośc białka:6/   �� 5      $��2q�6   .��6    Ilość węglowodanów:65   �� 5      $��2q�6   .��6    Ilość tłuszczy:61   �� 5      $��2q�6   .��6    
Kategoria:6,   5       �� 5"   
   $��1��6   $��20q�6%   .+�5$      �� -   5         ��Name$ addFoodName��5$   !   $��2q�6   $	��150��66   $��Right=�6B   $��26��6^   6l   �� 5%      -   5        $ addKcal��5%   !   $��2q�6   $	��150��62   $��Right=�6>   $��26��6Z   6h   �� 5&      -   5        $ 
addProtein��5&   !   $��2q�6   $	��150��65   $��Right=�6A   $��26��6]   6k   �� 5'      -   5        $ addCarbs��5'   !   $��2q�6   $	��150��63   $��Right=�6?   $��26��6[   6i   �� 5(      -   5        $ addFats��5(   !   $��2q�6   $	��150��62   $��Right=�6>   $��26��6Z   6h   �� 5)      -   5         ��Name$ chooseCategory��5)   "   $��2q�6   $	��150��6:   $��Right=�6F   $��26��6b   6p   5*      � 5,   
   $��2��6   $��1��6#   $��
20,0,20,20q�60   .+�5-   
   �� -   5         ��Name$ addNewFoodAddButton��5-      $��20��6/   $	��150��6;   $	��Top=�6G   $
��Left=�6_   .��6�   Dodaj6�   �� 5.   
   $��1��6   $��20��6   $	��150��6*   $	��Top=�67   $��Right=�6O   $��1��6k   .��6{   Anuluj6�   5/      50      51      