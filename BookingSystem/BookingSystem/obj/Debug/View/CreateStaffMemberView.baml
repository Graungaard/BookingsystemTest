   M S B A M L   `   `   `  ����H  DBookingClient, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullA%clr-namespace:BookingClient.ViewModelBookingClient.ViewModel  5      7 clr-namespace:BookingClient.ViewBookingClient.View  5      .    (BookingClient.View.CreateStaffMemberView   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      7local%clr-namespace:BookingClient.ViewModel     5      3local1 clr-namespace:BookingClient.View     5        � Title$  CreateStaffView��5	      $	��220��6%   $	��300��62   
���   ����	#FF5DA7D3 � 	Resources 5       �� DataType,   &BookingClient.ViewModel.StaffViewModel   	TestStyle �� 
TargetType �� Property �� Value��%�   (��       5      *, +)&	       �� 6
   "  6   �� 5   
   " ��6"   .�5      ��  � ��$ NoWrap=�6-   �� 5       � ��$
 None=�6-   5      5      .��5      � $��Stretch=�6   $��10q�6)    � ColumnDefinitions 5   
   �� 5      $
��Auto �6   $��68��6,   �� 5      $��199.083 �6    � RowDefinitions 5   
   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $��* �6   �� 5      $��* �6   .+�5!   
   �� $��0��6   $��0��6!   $��
First Name��61   $��Center=�6C   $	��5,6q�6^   $��15.96��6k   �� 5"   
   $��0��6   $��1��6   $��5q�6/   ��5#      �� *	FirstName+ �� UpdateSourceTrigger$ PropertyChanged=�	 �� ValidatesOnDataErrors	 . �� 5&   
   $��1��6   $��0��6!   $��	Last Name��61   $��Center=�6B   $	��5,6q�6]   $��15.96��6j   �� 5'   
   $��1��6   $��1��6   $��5q�6/   ��5(      �� *
LastName+$ PropertyChanged=�	 . �� 5*   
   $
��Role��6   $
��Left=�6   $��3��6:   $	��Top=�6G   $��67.083��6_   $��25.96��6n   �� 5+   
   $��1��6   $
��Left=�6#   $��5,5,0,0q�6>   $��3��6O   $	��Top=�6\   $	��190��6t   
 �� SelectedIndex$
 0��6�   ��6�   �� *TreatmentList+ �� SelectedItem 6�   �� *SelecetedTreatmant+��5,      �� 5-      .R�5.      �� .+�5/      �� ��6$   �� *TreatmentName+50      51      53      �� 54   
   -   5         ��Name$ button��54      $��4��6!   $��1��6.   $��Right=�6>   $	��Top=�6Z   $��20��6r   $��20��6~   $��80��6�   $��0,0,9.999,0q�6�   $��Add Staff Member��6�   $��101.4��55   .     	JGKButton#���  6<    J� RenderTransformOrigin$ 0.5,0.5&�6`   ��6   �� *AddStaffMemberCommand+56      58      59      