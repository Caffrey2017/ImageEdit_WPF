   M S B A M L   `   `   `  ����H  DImageEdit_WPF, Version=0.9.0.0, Culture=neutral, PublicKeyToken=nullI)clr-namespace:ImageEdit_WPF.HelperClassesImageEdit_WPF.HelperClasses  5   	   %    ImageEdit_WPF.Windows.ShiftBits   5   	   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   ;local)clr-namespace:ImageEdit_WPF.HelperClasses     5   	     � Title$  
Shift Bits��5   	   $	��160��6   $	��250��6)   
������� � 
ResizeMode$ NoResize=�6M   .��5      �  � RowDefinitions 5   
   �� 5      $
��Auto �6   6,   �� 5      $
��Auto �6   6,   �� 5       $
��Auto �6   6,   .+�5"   
   � $��0��6   $��10q�6!   .+�5#      �� " Number of bits to shift (0 - 7):6:   �� 5$       �� Padding$ 5,0,0,0q�6   $��40��6*   $��25��65   ��5%      �� 5&       �� ElementName$ sldBits��6    �� Path$ Value�64    �� 	Converter 5'      6   0ImageEdit_WPF.HelperClasses.SliderValueConverter  5(      5*      5,      5-      �� 5.   
   -   5        $��sldBits��50      $��1��5.      $��5q�5/       � Maximum$ 7Q�51       � Minimum$ 0Q�52      	 � Value$	 0Q�53      
 �� IsSnapToTickEnabled
 .  �� TickFrequency$ 1Q�55      �� 56   
   $��2��6   $��10q�6"   $��Center=�6.   .+�57      �� -   5        $��ok��57      $��	30,2,30,2q�6   .��6D   OK6H   58      59      5:      