   M S B A M L   `   `   `  ����H  DBookingClient, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullA%clr-namespace:BookingClient.ViewModelBookingClient.ViewModel  5      :    4BookingClient.View.TreatmentViews.CreatTreatmentView   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      7local%clr-namespace:BookingClient.ViewModel     5        � Title$  Create Treatments��5      $	��220��6'   $	��300��64   
���   ����	#FF5DA7D3 � 	Resources 5
       �� DataType0   *BookingClient.ViewModel.TreatmentViewModel��%-   (��       5      *, +)�� 6
   "  6   5      .��5      � $��Stretch=�6   $��10q�6)    � ColumnDefinitions 5   
   �� 5      $
��Auto �6   $��68��6,   �� 5      $��199.083 �6    � RowDefinitions 5   
   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $��* �6   �� 5      $��* �6   .+�5   
   �� $��0��6   $��0��6!   $��Treatment Name��61   $��Center=�6G   $	��5,6q�6b   $��15.96��6o   �� 5   
   $��0��6   $��1��6   $��5q�6/   ��5      �� *TreatmentName+ �� UpdateSourceTrigger$ PropertyChanged=� �� ValidatesOnDataErrors . �� 5   
   -   5         ��Name$ button��5      $��4��6!   $��1��6.   $��Right=�6>   $	��Top=�6Z   $��20��6r   $��20��6~   $��80��6�   $��0,0,36,0q�6�   $��Add Treatment��6�   $	��101��5   ,      	JGKButton#���   68    J� RenderTransformOrigin$ 0.5,0.5&�6\   ��6   �� *AddTreatmentCommand+5       5"      5#      