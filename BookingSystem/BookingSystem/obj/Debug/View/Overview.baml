   M S B A M L   `   `   `  ����H  DBookingClient, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullA%clr-namespace:BookingClient.ViewModelBookingClient.ViewModel  5      !    BookingClient.View.Overview   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      7local%clr-namespace:BookingClient.ViewModel     5        � 	Resources  5	       �� DataType/   )BookingClient.ViewModel.OverViewViewModel��%2   (��       5
      *, +)�� 6
   "  6   6E   5      .��5      �  � ColumnDefinitions 5      �� 5      .+�5   
   ]� $
��Left=�6   $	��265��6/   ��.  $	��Top=�6R   $	��300��6j   .+�5      �� $	��265��6   $	��Top=�6#   $	��115��6;   .+�5      &   System.Windows.Controls.Calendar  $
��Left=�6   $	��Top=�66   $	��185��6N   $��	0,0,-70,0q�6Z      SelectedDate 6m   �� *SelectedDate+ �� UpdateSourceTrigger$ PropertyChanged=��� 5      $��Add Appointment��6   $
��Left=�6g   $	��Top=�6�   $	��115��6�   ��6.   �� *$"OpenCreateAppointmentActionCommand+6�   5      �� 5      $	��265��6   $	��Top=�6#   $	��115��6;   $��Right=�6G   $��Right=�6^   .+�5      �� ��6   �� *Appointments+��5      �� 5      .R�5   "   �� 
���   �$��1q�6=   $	��100��6Q   $��0,0,0,2q�6^   ._�5   &   �� .+�5   *   �� 
���   �$��1q�6E   ._�5      �� $
��Bold"�6@   ���	#FF8CDBFF��6$   �� *	Subject+6R   5   '   �� 5   &   $��8(�6I   ��6,   �� *
Location+6I   �� 5      $��8(�6B   ��6$   �� *	StartTime+6B   �� 5       $��10.667(�6=   ��6$   �� *Body+6=   5!      5"   $   5#      5%      5&      5'      �� 5(   
   $
��Left=�61   $��
20,270,0,0q�6L   $	��Top=�6`   ��6   �� *SelectedDate+6`   5)      5*      