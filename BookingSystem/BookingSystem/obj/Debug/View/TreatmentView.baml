   M S B A M L   `   `   `  ����H  DBookingClient, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullA%clr-namespace:BookingClient.ViewModelBookingClient.ViewModel  5      &     BookingClient.View.TreatmentView   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      7local%clr-namespace:BookingClient.ViewModel     5        � 	Resources  5	       �� DataType,   &BookingClient.ViewModel.StaffViewModel !  BooleanToVisibilityConverter1��%O   (��       5
      *, +)&	       �� 6
   "  6   6B   �� 5   
   6'   5      .��5      ]� $��5q�6   .+�5   
   ]� $	��Top=�6   $��20��6)   .+�5      �� $�� Create new Treatment ��6   $��0,0,2,0q�66     	JGKButton#���  6w   $
��Left=�6�   ��6G   ��  �� Path$ CreateTreatmentCommand�6�   �� 5      $�� Delete Treatmenet ��6   $��2,0,0,0q�63   #���  6D   $
��Left=�6h   ��6�   �� $ DeleteTreatmentCommand�6�   5      � 5   
    � RowDefinitions 5      �� 5      $��20 �6    �� 5      $
��100* �6    .+�5      �  � ColumnDefinitions 5      �� 5      $	��76* �6'   �� 5      $	��69* �6'   �� 5      $	��37* �6'   �� 5      $	��36* �6'   �� 5      $	��72* �6'   .+�5!      �� ._�5"      �� $��
Treatments��6    $��0,0,9,0q�62   5#      �� 5%      $
��Left=�6   $��2��64   $��30,87,0,-87q�6H   $��67��6]   5*      �� 5,      -   5        $��Lv��5,      $��1��5-       � IsSharedSizeScope . $	��Top=�51       �� SelectedIndex$ 0��52      ��5/      �� *TreatmentTypes+ �� SelectedItem 50      �� *SelectedTreatment+��54      �� 55      .R�56      � $	��2,0q�6    57      �� 58   "    z� SharedSizeGroup$
 col1��63   $
��Auto �6J   �� 59   "   $
 col2��63   $
��Auto �6J   �� 5:   "   $
 col3��63   $
��Auto �6J   �� 5;   "   $
 col4��63   $
��Auto �6J   �� 5<   "   $
 col5��63   $
��100* �6J   .+�5>      �� $��0��6(   $	��2,0q�68   ��6E   �� *TreatmentName+�� 5?      $��Right=�6%   $��3��6A   #���  6Q   $
��Edit��6u   $	��2,0q�6�   ��5@   %   �� 	 �� ElementName$	 Lv��$&  DataContext.EditTreatmentCommand�y�5A   %   �� 
 �� RelativeSource
 ��  �� AncestorType" ��$ 
IsSelected� �� 	Converter# [  �� 5C      $��Right=�6%   #���  6A   $��4��6e   $��Delete��6u   $	��2,0q�6�   ��5D   %   �� $	 Lv��$( "DataContext.DeleteTreatmentCommand�y�5E   %   �� 
 �� " ��$ 
IsSelected�# [  5G      5H      5J      5K      5L      5N      