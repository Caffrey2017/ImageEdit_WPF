   M S B A M L   `   `   `  ����H  DImageEdit_WPF, Version=0.9.0.0, Culture=neutral, PublicKeyToken=nullI)clr-namespace:ImageEdit_WPF.HelperClassesImageEdit_WPF.HelperClasses  5   	   )    #ImageEdit_WPF.Windows.CartoonEffect   5   	   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   ;local)clr-namespace:ImageEdit_WPF.HelperClasses     5   	     � Title$  Cartoon effect��5   	   $	��200��6    $	��250��6-   
������� � 
ResizeMode$ NoResize=�6R   .��5      �  � RowDefinitions 5   
   �� 5      $
��Auto �6   6,   �� 5      $
��Auto �6   6,   �� 5       $
��Auto �6   6,   �� 5!      $
��Auto �6   6,   .+�5#   
   � $��0��6   .+�5$      �� $��10q�6   Choose a filter:66   �� 5%      -   5        $��
cmbFilters��5%   "   $��5q�6   66   5&      � 5'   
   $��1��6   $��10q�6!   .+�5(      �� 
Threshold:6$   �� 5)       �� Padding$ 5,0,0,0q�6   $��40��6*   $��25��65   ��5*      �� 5+       �� ElementName$ sldThreshold��6    �� Path$ Value�69    �� 	Converter 5,      6   0ImageEdit_WPF.HelperClasses.SliderValueConverter  5-      5/      51      52      �� 53   
   -   5        $��sldThreshold��55      $��2��53      $��5q�54       � Maximum$	 200Q�56       � Minimum$ 0Q�57      	 � Value$	 0Q�58      
 �� IsSnapToTickEnabled
 .  �� TickFrequency$ 1Q�5:      �� 5;   
   $��3��6   $��10q�6"   $��Center=�6.   .+�5<      �� -   5        $��ok��5<      $��	30,2,30,2q�6   .��6F   OK6J   5=      5>      5?      