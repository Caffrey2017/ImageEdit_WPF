   M S B A M L   `   `   `  ����   ImageEdit_WPF%    ImageEdit_WPF.Windows.Histogram   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml       � Title$  	Histogram��$	��360��$	��410��
������� � 
ResizeMode$ NoResize=�.���  � RowDefinitions �� $
��Auto ��� $
��Auto ��� $
��Auto ��� $
��Auto �.+��� $��0��$��0��$��10,0,0,0q�.+��� 
Channel:�� $��0��$��0��$��70,0,200,10q�.+�	� -   $
��gray��.��
Luminosity	� -   $	��red��.��Red	� -   $��green��.��Green	� -   $
��blue��.��Blue�� -   $��groupBox��$��1��$��0��$��
Luminosity��$	��380��$	��200��.���� $��1q�
���   �
�������$��10q�._�� -   $��polygon�� �� Stretch$
 Fill=�
���   � � Points ��  �� Path$ M_histogramPoints� �� UpdateSourceTrigger$ PropertyChanged=��� $��1��$��0��$��355,180,10,0q�.��255�� $��1��$��0��$��15,180,350,0q�.��0�� $��2��$��0��.��
Average:�� -   $��	meanValue��$��2��$��0��$��57,5,250,-3q�