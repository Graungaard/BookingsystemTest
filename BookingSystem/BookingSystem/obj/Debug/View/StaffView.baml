   M S B A M L   `   `   `  ����H  DBookingClient, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullA%clr-namespace:BookingClient.ViewModelBookingClient.ViewModel  5      "    BookingClient.View.StaffView   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      7local%clr-namespace:BookingClient.ViewModel     5        � 	Resources  5	       �� DataType,   &BookingClient.ViewModel.StaffViewModel !  BooleanToVisibilityConverter1��%O   (��       5
      *, +)&	       �� 6
   "  6   6B   �� 5   
   6'   5      .��5      ]� $��5q�6   .+�5   
   ]� $	��Top=�6   $��20��6)   .+�5      �� $�� Create new staffmember ��6   $��0,0,2,0q�68     	JGKButton#���  6{   $
��Left=�6�   ��6I   ��  �� Path$ CreateStaffMemberCommand�6�   �� 5      $�� Delete staff member ��6   $��2,0,0,0q�65   #���  6F   $
��Left=�6j   6�   5      � 5   
    � RowDefinitions 5      �� 5      $��20 �6    �� 5      $
��100* �6    .+�5      �  � ColumnDefinitions 5      �� 5      $	��71* �6'   �� 5      $	��64* �6'   �� 5      $	��68* �6'   �� 5      $	��67* �6'   .+�5       �� ._�5!      �� $��
First Name��6    $��0,0,9,0q�62   5"      �� 5$      $
��Left=�6   $��2��64   $��30,87,0,-87q�6H   $��67��6]   ._�5%      �� $��
Last Name ��6    $��32,-87,-33,0q�62   $��68��6H   $
��Left=�6S   $��19��6n   $	��Top=�6z   5&      �� 5'      $
��Left=�6   $��3��64   $��30,87,0,-87q�6H   $��67��6]   ._�5(      �� $��
Treatment ��6    $��99,-87,-100,0q�62   $��68��6I   $
��Left=�6T   $��19��6o   $	��Top=�6{   5)      5.      �� 50      -   5        $��Lv��50      $��1��51       � IsSharedSizeScope . $	��Top=�55       �� SelectedIndex$ 0��56      ��53      �� *StaffMembers+ �� SelectedItem 54      �� *SelecetedStaff+��58      �� 59      .R�5:      � $	��2,0q�6    5;      �� 5<   "    z� SharedSizeGroup$
 col1��63   $
��Auto �6J   �� 5=   "   $
 col2��63   $
��Auto �6J   �� 5>   "   $
 col3��63   $
��Auto �6J   �� 5?   "   $
 col4��63   $
��Auto �6J   �� 5@   "   $
 col5��63   $
��100* �6J   .+�5B      �� $��0��6(   $	��2,0q�68   ��6E   �� *	FirstName+�� 5C      $��1��6(   $	��2,0q�68   ��6E   �� *
LastName+�� 5D      $��1��6(   $	��2,0q�68   ��6E   �� *TreatmentName+�� 5E      $��Right=�6%   $��3��6A   #���  6Q   $
��Edit��6u   $	��2,0q�6�   ��5F   %   �� 	 �� ElementName$	 Lv��$( "DataContext.EditStaffMemberCommand�y�5G   %   �� 
 �� RelativeSource
 ��  �� AncestorType" ��$ 
IsSelected� �� 	Converter# [  �� 5I      $��Right=�6%   #���  6A   $��4��6e   $��Delete��6u   $	��2,0q�6�   ��5J   %   �� $	 Lv��$* $DataContext.DeleteStaffMemberCommand�y�5K   %   �� 
 �� " ��$ 
IsSelected�# [  5M      5N      5P      5Q      5R      5T      