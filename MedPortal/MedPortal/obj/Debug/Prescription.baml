   M S B A M L   `   `   `  ����D  @MedPortal, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null%clr-namespace:MedPortal	MedPortal  5          MedPortal.Prescription   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      )localclr-namespace:MedPortal     5        N� Title$  Prescription��5	      .��5      � 
������� � RowDefinitions 5   
   �� 5      �� 5      �� 5      �� 5      �� 5      �� 5      �� 5      �� 5      �� 5      �� 5      �� 5      �� 5      �� 5      �� 5      �� 5      �� 5      �� 5      �� 5       � ColumnDefinitions 5    
   �� 5!      �� 5"      �� 5#      �� 5$      �� 5%      �� 5&      �� 5'      �� 5(      �� 5)      �� 5*      �� 5+      �� 5,      .+�51   
   �� $��16��6   ���	#FF1CADC2$��Stretch=�6:   $��0��6X   ���	#FF1CADC2$��Stretch=�6y    �� RadiusX$ 5��6�    �� RadiusY$ 5��6�   �� 52   
   $��2��6   $��18��6(   
�������$��Stretch=�6L   $��1��6j   
�������$��Stretch=�6�   �� 53   
   ���	#FFF4F4F5$��4��6%   $��4��65   $��Stretch=�6B   $��6��6`   ���	#FF1CADC2$��Stretch=�6�   $��6��6�   $ 10��6�   $ 10��6�   �� 55   
   $��5��6   $��0��6!   $��Center=�61   $��2��6N   $	��Top=�6b   �� 56      -   5        .�56   0   Account Overview58      59      �� 5;   
   -   5         ��Name$ 	userImage��5;      $��1��6#   $��3��60   $��2��6A   $��Center=�6U   $��Center=�6p   ��6�   �� *Image+�� 5<   
   -   5         ��Name$ Welcome��5<      $��4��6%   $��0��63   $��14(�6_   $��DemiBold"�6m   $��Center=�6�   $��Center=�6�   $��2��6�   ��6C   �� *	UserLogin+6�   �� 5>   
   $��Current Medication��6   $��22(�6/   $��DemiBold"�6=   $��4��6S   $��6��6`   $��Center=�6p   $��Center=�6�   $��2��6�   �� 5?   
   $[��USelect the prescription that you want to refill, then click the  Refill button below.��6   $��WrapWithOverflow=�6q   $��5��6�   $��6��6�    �� TextAlignment$ Center=�6�   $��2��6�   $��Center=�6�   $��Center=�6�   &   System.Windows.Controls.DataGrid  5B   
   -   5          Name$ RXGrid��5B      $��6��6#   $��3��60   $��4��6A   $��6��6Q   $��Stretch=�6e   $��Stretch=�6�   	   GridLinesVisibility$
	 None=�6�   
   RowBackground

 �����   AlternatingRowBackground
 ��ح�   AreRowDetailsFrozen .    CanUserResizeColumns .     CanUserResizeRows .     CanUserReorderColumns .     	RowHeight$ 20Q�5D   H      AutoGenerateColumns .     CanUserSortColumns .    CanUserAddRows .  $   HorizontalScrollBarVisibility$ Disabled=�5E         SelectionMode$ Single=�6=      RowHeaderWidth$ 0Q�6T   $��16(�6�   ��5C      Z� ��5D   1   Z�  �� SelectedItem 5E   h   �� *SelectedItem+��6�   �� *	UserObsrv+   Columns 5F      0  *System.Windows.Controls.DataGridTextColumn  5G      ,  &System.Windows.Controls.DataGridColumn   Header$ Prescription Number��6H      
IsReadOnly .    Width5  /System.Windows.Controls.DataGridLengthConverter$ * 6w   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6&   �� *ScriptNumber+6w     5H      $ Prescription��6%   $ * 6`    .  6;   �� *PrescriptionName+6j     5I      $ 	Fill Date��6%   $ * 6U    .  68   �� *
FillDate+6`     5J      $ Expiration Date��6%   $ * 6a    .  6>   �� *ExpirationDate+6k     5K      $ Refills Remaining��6%   $ * 6d    .  6@   �� *RefillAvailable+6n   5M      �� 5O   
   -   5        $ RXText��5O      $��no current prescriptions��6$   $��6��6D   $��5��6Q   $��4��6a   $��Center=�6u   $��24(�6�   $��Medium"�6�   $y�Hidden=�6�   �� 5Q   
   -   5         ��Name$ Refill_Button��5Q      $��Refill Request��6(   $��9��6A   $��9��6N   
�������$��Center=�6v   $��30��6�   $	��100��6�   $��Center=�6�      buttonborder#���   6�   ��6�   �� *Refill_Command+�� 5U   
   -   5        $ Question_Button��5U      $��Stretch=�6*   $��Stretch=�6O   $��0��6m   $��10��6}   $��2��6�   $��Stretch=�6�   
�������$��1q�6�   
�������.��5V      �  5W      �� 5X       5Z      �� 5[      �� 5\      .+�5^      �� {�.  $ ��UserImages/stethoscope.png��6*   $��26��6N   $
��Left=�6Z   $��Center=�6u   5_      �� 5`      $��0��6   $��2��6,   $��Ask The Doctor��6@   $��Center=�6V   $��22(�6s   $��DemiBold"�6�   $��Center=�6�   5a      5b      �� 5c   
   -   5        $��Stretch=�5c      $��6��6/   $��0��6Q   $��2��6a   $��Stretch=�6u   
�������$��1��6�   $��1q�6�   
�������$��Stretch=�6�   .��5d      �  5e      �� 5f       5h      �� 5i      �� 5j      .+�5l      �� $��0��6   $��home-vector.png��6(   {�.  $��30��6S   $
��Left=�6_   $��Center=�6z   5m      �� 5o      $��0��6   $
��Home��6,   $��Center=�68   $��22(�6U   $��2��6c   $��DemiBold"�6w   $��Center=�6�    �� Padding$ 0,0,60,0q�6�   5p      5q      �� 5s   
   -	   5        $ Appointment_Button��5s      $��Stretch=�6-   $��Stretch=�6R   $��7��6p   $��0��6}   $��2��6�   $��Stretch=�6�   
�������$��1q�6�   
�������.��5t      �  5u      �� 5v       5x      �� 5y      �� 5z      .+�5|      �� $��0��6   {�.  $��small-calendar.png��6:   $��25��6V   $
��Left=�6b   $��Center=�6}   5}      �� 5~      $��0��6   $��Appointments��6,   $��Center=�6@   $��22(�6]   $��2��6k   $��DemiBold"�6   $��Center=�6�   $ 20,0,0,0q�6�   5      5�      �� 5�   
   -
   5        $ Presciption_Button��5�      $��Stretch=�6-   $��Stretch=�6R   $��0��6p   $��8��6�   $��2��6�   $��Stretch=�6�   
�������$��1q�6�   
�������.��5�      �  5�      �� 5�       5�      �� 5�      �� 5�      .+�5�      �� $��Stretch=�6   $��Stretch=�6:   $��3��6V   $��75��6j   
����ح�
����ح�6�   �� 5�      {�.  $��	drugs.png��6*   $��25��6=   $
��Left=�6I   $��Center=�6e   5�      �� 5�      $��0��6   $��Prescriptions��6,   $��Center=�6A   $��22(�6^   $��2��6l   $��DemiBold"�6�   $��Center=�6�   $ 5,0,0,0q�6�   5�      5�      �� 5�   
   -   5        $ Billing_Button��5�      $��Stretch=�6)   $��Stretch=�6N   $��0��6l   $��9��6|   $��2��6�   $��Stretch=�6�   
�������$��1q�6�   
�������.��5�      �  5�      �� 5�       5�      �� 5�      �� 5�      .+�5�      �� {�.  $��credit-card.png��6*   $��26��6C   $
��Left=�6O   $��Center=�6j   5�      �� 5�      $��0��6   $��2��6,   $��Bill Payment��6@   $��Center=�6T   $��22(�6q   $��DemiBold"�6   $��Center=�6�   5�      5�      �� 5�   
   $��Logout��6   $��11��6#   $��1��64   $
��Left=�6H   $��Center=�6c   $��14(�6~   $��DemiBold"�6�   �� 5�   
   -   5        $ Logout_Button��5�      $��Stretch=�6(   $��11��6F   $��Stretch=�6W   $��0q�6�     NoMouseOver#���  6�   ��6s   Z� .��5�      �� {�.  $��
logout.png��6&   $��35��6:   5�      5�      5�      5�      