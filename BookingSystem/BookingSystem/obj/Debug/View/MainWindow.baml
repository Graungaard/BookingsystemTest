   M S B A M L   `   `   `  ����H  DBookingClient, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null7 clr-namespace:BookingClient.ViewBookingClient.View  5   	   A%clr-namespace:BookingClient.ViewModelBookingClient.ViewModel  5   	   #    BookingClient.View.MainWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   c _Microsoft.Expression.Effects, Version=4.5.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35h dMicrosoft.Expression.Interactions, Version=4.5.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35?ee4http://schemas.microsoft.com/expression/2010/effects   5   	   <d2http://schemas.microsoft.com/expression/blend/2008   5   	   .views clr-namespace:BookingClient.View   5   	   3local%clr-namespace:BookingClient.ViewModel   5   	     � Title$  Booking��5	   	   $	��720��6   $	��800��6&    � 
ResizeMode$ NoResize=�62    � 	Resources 5
       �� DataType/   )BookingClient.ViewModel.OverViewViewModel!   BookingClient.View.Overview,   &BookingClient.ViewModel.StaffViewModel"   BookingClient.View.StaffView0   *BookingClient.ViewModel.TreatmentViewModel&    BookingClient.View.TreatmentView��%�   (��       5      *, +)(�� 7     5      *, +)(�� n     5      *, +)�� 5   
   "  6   .R�5        6   5      �� 5   
   "  6   .R�5        6    5      �� 5   
   "  6   .R�5        6$   5      5      ��5      �� 5       �� EndPoint$ 0.5,1&�6    � MappingMode$ RelativeToBoundingBox=�6)    �� 
StartPoint$ 
0.5,-0.112&�6M   .��5      �  � Color$ 	#FFA4A4A4��6    � Offset$ 1Q�6$   � 5      $
 Gray��6   $ 0.283Q�6   � 5      $ 	#FF616161��6   $ 0.165Q�6$   � 5      $ 	#FFE3E3E3��6   5      .��5      ]� -   5        	 ]�Name$	 	Dockpanel��5      
 J� OpacityMask
 5      �� 5       $ 
0.47,0.423&�6   $ 0.468,0.442&�62   .��5!   	   � $ Black��6   $ 0Q�6$   � 5"   	   $ White��6   $ 1Q�6$   5#   	   .+�5%   
   �� $	��Top=�6   
�������$��0q�6:    �� CornerRadius$ 5��6N   ._�5'      �� $��Center=�6B   $��25(�6_   
�������$��Segoe UI Semibold)�6�   ��6   �� *CurrentPageViewModel.Name+6�   5)      �� 5.   
   $
��Left=�6   
�������$��0q�6;   $ 3��6O   ._�5/      �� ��6   �� *PageViewModels+��50      �� 51      .R�52      �� $��Stretch=�55   !      	JGKButton#���   6?   $��50��6c   
���   �$��Normal"�6�   $��Segoe UI Semibold)�6�   ��52   !   �� *Name+��53   !   �� *DataContext.ChangePageCommand+ �� RelativeSource ��  �� AncestorType" ���54   !   �� 55   �   56      58      59      �� 5:   
   $
��1384��6B   ��6   �� *CurrentPageViewModel+
 5;      �� 5<      $ 0.5,1&�6    $ 0.5,0&�61   .��5=      � $ Black��6   $ 0Q�6(   � 5>      $ White��6   $ 1Q�6(   5?      ��5A      �� 5B      $ 0.747,0.893&�6    $ 0.398,0.056&�67   .��5C      � $ Black��6   � 5D      $ 	#FF9C2C2C��6   $ 1Q�6,   5E      5G      �� 5H   
   
���   �$��1q�6%   $	��681��69   $	��Top=�6F   $	��790��6^   $��2,2,2,0q�6j   5I      5J      