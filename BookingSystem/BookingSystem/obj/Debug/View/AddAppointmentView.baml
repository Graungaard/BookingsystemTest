   M S B A M L   `   `   `  ����H  DBookingClient, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null7 clr-namespace:BookingClient.ViewBookingClient.View  5      A%clr-namespace:BookingClient.ViewModelBookingClient.ViewModel  5      +    %BookingClient.View.AddAppointmentView   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      2view1 clr-namespace:BookingClient.View     5      7local%clr-namespace:BookingClient.ViewModel     5      $	��319��5      $	��324��6,     � 	Resources  5	       �� DataType/   )BookingClient.ViewModel.OverViewViewModel��%2   (��       5
      *, +)�� 6
   "  6   6E   5      .��5      � $��0,0,2,-4q�6    � RowDefinitions 5   
   �� 5      $	��35* �6   �� 5      $	��37* �6    � ColumnDefinitions 5   
   �� 5      $	��80* �6   �� 5      $	��77* �6   .+�5   
   �� $
��Left=�6   $	��110��6-   $��80,0,0,0q�6:    �� TextWrapping$
 Wrap=�6L   $	��Top=�6v   $	��225��6�   $��2��6�   $��1��6�   ��6`   �� *Body+6�   �� 5   
   $
��Save��6   $
��Left=�6T   $��
69,115,0,0q�6o   $	��Top=�6�   $��75��6�   $��1��6�   $��1��6�   $��20��6�   ��6    ��  �� Path$  AddApointmentActionCommand�6�   ]� 5   
   $
��Left=�6   $	��100��6/   ��.  $	��Top=�6R   $	��315��6j   $��2��6v   $��	0,10,-1,0q�6�   .+�5      �� $
��Left=�6   $	��100��64   $	��Top=�6A   $	��160��6Y   .+�5      �� $��Subject��6   $
��Left=�6*   $	��Top=�6E   �� 5      $��Location��6   $
��Left=�6+   $	��Top=�6F   �� 5      $��
Start date��6   $
��Left=�6-   $	��Top=�6H   �� 5      $��End date��6   $
��Left=�6+   $	��Top=�6F   5      �� 5      $��Center=�6   $	��100��66   $	��Top=�6C   $	��150��6[   $��Right=�6g   .+�5       �� $��Right=�6   $��23��66   $��0,0,10,2q�6B   $
 Wrap=�6T   $	��Top=�6�   $	��120��6�   ��6h   �� *	Subject+ �� UpdateSourceTrigger$ PropertyChanged=�6�   �� 5!      $��Right=�6   $��23��66   $��0,0,10,2q�6B   $
 Wrap=�6T   $	��Top=�6�   $	��120��6�   ��6h   �� *
Location+6�   (  "System.Windows.Controls.DatePicker  5"      $��Right=�6   $��0,0,10,2q�69   $	��Top=�6K      FirstDayOfWeek$ Monday=�6c      SelectedDateFormat$
 Long=�6{   $	��120��6�   	   SelectedDate	 6�   �� *SelectedDate+6�     5#      $��Right=�6   $��0,0,10,2q�69   $	��Top=�6K   $ Monday=�6c   $
 Long=�6{   $	��120��6�   	 6�   �� *	EndTime+6�   5$      5%      �� 5&   
   $��Description��6   $
��Left=�6&   $��-0.254,140,0,0q�6A   $	��Top=�6Y   $��2��6q   5(      5)      