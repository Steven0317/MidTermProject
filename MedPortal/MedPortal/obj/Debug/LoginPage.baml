   M S B A M L   `   `   `  ����D  @MedPortal, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null%clr-namespace:MedPortal	MedPortal  5          MedPortal.LoginPage   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      )localclr-namespace:MedPortal     5        N� Title$  	LoginPage��5	      .��5      � 
������� � RowDefinitions 5   
   �� 5      �� 5      �� 5      �� 5      �� 5      �� 5      �� 5      �� 5      �� 5      �� 5      �� 5      �� 5       � ColumnDefinitions 5   
   �� 5      �� 5      �� 5      �� 5      �� 5      �� 5       �� 5!      �� 5"      .+�5(   
   �� ���	#FFF4F4F5$��2��6%   $��3��65   $��Center=�6B   $��4��6_   $	��375��6p   ���	#FF1CADC2$��Stretch=�6�   $��4��6�    �� RadiusY$ 10��6�    �� RadiusX$ 10��6�   �� 5)   
   -   5         ��Name$ error��5)      $$��Incorrect password or username��6#   $��20(�6I   $��2��6X   $��1��6h   $��4��6u   $��Center=�6�   $y�	Collapsed=�6�   
���  ��$��Center=�6�   �� 5-   
   -   5         ��Name$ username��5-      
 � Tag$ 
Username: ��6$   $��DemiBold"�65    �� TextAlignment$ Center=�6K   $��4��6b   $��3��6o   $��2��6   $��Center=�6�   $	��275��6�   $��Center=�6�      CW-Inline-TextBox#��[  6�   G� 5.   
   -   5        	 G�Name$	 password��5.      $ 
Password: ��6(   $��Center=�69   $��5��6]   $��3��6j   $��2��6z   $��Center=�6�   $	��275��6�   $	��Top=�6�     PW-Inline-TextBox#��[ 6�   �� 51   
   -   5        
 ��Name$
 login_button��51      $��Bottom=�6'   $��Center=�6B   $	��200��6_   $��5��6l   $��3��6y   $��25��6�   $��2��6�   $��Login��6�   
�������  buttonborder#���  6�   ���	#FF32C8FF J� OpacityMask �	#FF32C8FF �� 	IsDefault . 6A  �� 53   
   $��6��6   $��3��6!   $��Center=�61   $��2��6N   $��Center=�6b   �� 54      -   5        .�54   0   Create New User56      57      �� 59   
   $��3��6   $��3��6   $��Center=�6-   $	��300��6J   $��2��6V   $ ��imageedit_1_2882203914.png��6j   5;      5=      5>      