   M S B A M L   `   `   `  ���� H  DImageEdit_WPF, Version=0.9.0.0, Culture=neutral, PublicKeyToken=nullI)clr-namespace:ImageEdit_WPF.HelperClassesImageEdit_WPF.HelperClasses  /    )ImageEdit_WPF.Windows.ContrastEnhancement   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     ;local)clr-namespace:ImageEdit_WPF.HelperClasses       � Title$  Contrast Enhancement��$	��240��$	��210��
������� � 
ResizeMode$ NoResize=�.���  � RowDefinitions �� $
��Auto ��� $
��Auto ��� $
��Auto ��� $
��Auto ��� $
��Auto �.+�� $��0��$��10q�.+��� Brightness:��  �� Padding$ 5,0,0,0q�$��40��$��25������  �� ElementName$ sldBrightness�� �� Path$ Value� �� 	Converter 6   0ImageEdit_WPF.HelperClasses.SliderValueConverter  �� -   $��sldBrightness��$��1��$��5q� � Maximum$	 255Q� � Minimum$ 0Q�	 � Value$	 0Q�
 �� IsSnapToTickEnabled
 .  �� TickFrequency$ 1Q�� $��2��$��10q�.+��� 	Contrast:�� $ 5,0,0,0q�$��40��$��25������ $ sldContrast��$ Value� D   >ImageEdit_WPF.HelperClasses.SliderValueConverter_GradientBased  �� -   $��sldContrast��$��3��$��5q�$	 255Q�$ 0Q�$	 0Q��� $��4��$��10q�$��Center=�.+��� -   $��ok��$��	30,2,30,2q�.��OK