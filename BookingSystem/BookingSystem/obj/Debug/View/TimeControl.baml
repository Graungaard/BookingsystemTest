   M S B A M L   `   `   `  ����O  Kmscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e0891&clr-namespace:System;assembly=mscorlibSystem  5	       BookingClient$   BookingClient.View.TimeControl   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      6sys&clr-namespace:System;assembly=mscorlib     5	      -   5          >�Name$  UserControl��5       $
��Auto��6   $
��Auto��6   .��5      � -   5         �Name$ 
LayoutRoot��5      $
��Auto��6   $
��Auto��6,    � ColumnDefinitions 5   
   �� 5      $
��0.2* �6   �� 5      $��0.05* �6   �� 5      $
��0.2* �6   �� 5      $��0.05* �6   �� 5      $
��0.2* �6   .+�5   
   � -   5        $
 hour��5      |�. .+�5   
   �� -   5         ��Name$ mmTxt��5      $
��Left=�6"   $��-3,0,0,0q�6=   $	��Top=�6O   $��28��6g   .@�5      ��07:00:00��6%   ��5       8��6   5"      5$      � 5&   
   $��1��6   � 5(   
   -   5        $	 min��5(       $��2��6   |�. .+�5*      �� -   5         ��Name$ ddTxt��5*       �� TextWrapping$
 Wrap=�6'    �� TextAlignment$ Center=�5,      $��Center=�6*   $��Goudy Stout)�6E   $��14(�6^   ��5*   ;   ��  �� Path$ Minutes� �� ElementName$ UserControl��	 �� Mode$	 Default=�5,   ^   5.      � 50   
   $��3��6   � 52   
   -   5        $	��sec��52       $��4��6   |�. .+�54      �� -   5        $ yyTxt��54      $
 Wrap=�6&   $ Center=�56      $��Center=�6)   $��Goudy Stout)�6D   $��14(�6]   ��54   :   �� $ Seconds�$ UserControl��$	 Default=�56   ]   58      5<      5>      