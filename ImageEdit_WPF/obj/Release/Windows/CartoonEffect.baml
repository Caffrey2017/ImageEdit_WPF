   M S B A M L   `   `   `  ���� H  DImageEdit_WPF, Version=0.9.0.0, Culture=neutral, PublicKeyToken=nullI)clr-namespace:ImageEdit_WPF.HelperClassesImageEdit_WPF.HelperClasses  )    #ImageEdit_WPF.Windows.CartoonEffect   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     ;local)clr-namespace:ImageEdit_WPF.HelperClasses       � Title$  Cartoon effect��$	��200��$	��250��
������� � 
ResizeMode$ NoResize=�.���  � RowDefinitions �� $
��Auto ��� $
��Auto ��� $
��Auto ��� $
��Auto �.+�� $��0��.+��� $��10q�Choose a filter:�� -   $��
cmbFilters��$��5q�� $��1��$��10q�.+��� 
Threshold:��  �� Padding$ 5,0,0,0q�$��40��$��25������  �� ElementName$ sldThreshold�� �� Path$ Value� �� 	Converter 6   0ImageEdit_WPF.HelperClasses.SliderValueConverter  �� -   $��sldThreshold��$��2��$��5q� � Maximum$	 200Q� � Minimum$ 0Q�	 � Value$	 0Q�
 �� IsSnapToTickEnabled
 .  �� TickFrequency$ 1Q��� $��3��$��10q�$��Center=�.+��� -   $��ok��$��	30,2,30,2q�.��OK